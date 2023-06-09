﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using System.IO;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;
using System.Configuration;

namespace ZuartControl
{
    public partial class ZuartControl : UserControl
    {


        #region 自定义属性
        [Category("显示设置"), Description("自动换行显示开关"), Browsable(true)]
        public bool AutoLine
        {
            get
            {
                return chkAutoLine.Checked;
            }
            set
            {
                chkAutoLine.Checked = value;
            }
        }

        private Label labLog;
        [Category("控件绑定"), Description("设置显示log的Label"), Browsable(true)]
        public Label Labellog
        {
            get
            {
                return labLog;
            }
            set
            {
                labLog = value;

            }
        }

        private RichTextBox rtxShowData;
        [Category("控件绑定"), Description("设置接收文本的RichTextBox"), Browsable(true)]
        public RichTextBox RichTextBoxShowData
        {
            get
            {
                return rtxShowData;
            }
            set
            {
                rtxShowData = value;
                if (rtxShowData != null)
                {
                    rtxShowData.HideSelection = true;
                    rtxShowData.AcceptsTab = true;
                    rtxShowData.KeyPress += txtShowData_KeyPress;
                }
            }
        }
        private TextBox txtSendData;
        [Category("控件绑定"), Description("设置发送文本的TextBox"), Browsable(true)]
        public TextBox TextBoxSendData
        {
            get
            {
                return txtSendData;
            }
            set
            {
                txtSendData = value;
                if (txtSendData == null) return;
                //txtSendData.DataBindings.Add(new Binding("Text", Properties.Settings.Default, "txtSendData", true, DataSourceUpdateMode.OnPropertyChanged));
                IniFile ini = new IniFile(IniPath);
                txtSendData.Text = ini.Read("txtSendData", "COM") ?? "";
                // txtSendData.AcceptsTab = true;
                txtSendData.KeyPress += txtSendData_KeyPress;
                txtSendData.KeyDown += txtSendData_KeyDown;

            }
        }


        private Button btnSend;
        [Category("控件绑定"), Description("绑定发送按钮Button"), Browsable(true)]
        public Button ButtonSend
        {
            get
            {
                return btnSend;
            }
            set
            {
                if (btnSend != null)
                    btnSend.Click -= btnSend_Click;
                btnSend = value;
                if (btnSend != null)
                {
                    btnSend.Enabled = ComDevice.IsOpen;
                    btnSend.Click += btnSend_Click;
                }
            }
        }


        private string iniFileName;
        [Category("控件绑定"), Description("设置保存ini文件名称"), Browsable(true)]
        public string INIFileName
        {
            get
            {
                return iniFileName;
            }
            set
            {
                iniFileName = value;
                if (!iniFileName.EndsWith(".ini")) iniFileName += ".ini";
            }
        }
        #endregion


        #region 自定义事件
        #region 串口开关事件回调
        public class ComConnectState_EventArgs : EventArgs
        {
            public bool IsComOpen { get; set; }
        }
        protected EventHandler<ComConnectState_EventArgs> OnComConnectState;
        [Category("控件事件"), Description("串口开关状态变化时调用"), Browsable(true)]
        public event EventHandler<ComConnectState_EventArgs> ComConnectState
        {
            add
            {
                if (OnComConnectState != null)
                {
                    foreach (Delegate d in OnComConnectState.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComConnectState = (EventHandler<ComConnectState_EventArgs>)Delegate.Combine(OnComConnectState, value);
            }
            remove
            {
                OnComConnectState = (EventHandler<ComConnectState_EventArgs>)Delegate.Remove(OnComConnectState, value);
            }

        }
        #endregion

        #region 串口接收事件回调
        public class ComData_EventArgs : EventArgs
        {
            public byte[] data { get; set; }
            public string recived_string { get; set; }
        }
        protected EventHandler<ComData_EventArgs> OnComDataReceived;
        [Category("控件事件"), Description("串口接收到数据后调用"), Browsable(true)]
        public event EventHandler<ComData_EventArgs> ComDataReceivedProperties
        {
            add
            {
                if (OnComDataReceived != null)
                {
                    foreach (Delegate d in OnComDataReceived.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComDataReceived = (EventHandler<ComData_EventArgs>)Delegate.Combine(OnComDataReceived, value);
            }
            remove
            {
                OnComDataReceived = (EventHandler<ComData_EventArgs>)Delegate.Remove(OnComDataReceived, value);
            }

        }
        #endregion
        #region 串口发送事件回调

        protected EventHandler<ComData_EventArgs> OnComDataSend;
        [Category("控件事件"), Description("串口发送数据后调用"), Browsable(true)]
        public event EventHandler<ComData_EventArgs> ComDataSend
        {
            add
            {
                if (OnComDataSend != null)
                {
                    foreach (Delegate d in OnComDataSend.GetInvocationList())
                    {
                        if (object.ReferenceEquals(d, value)) return;
                    }
                }
                OnComDataSend = (EventHandler<ComData_EventArgs>)Delegate.Combine(OnComDataSend, value);
            }
            remove
            {
                OnComDataSend = (EventHandler<ComData_EventArgs>)Delegate.Remove(OnComDataSend, value);
            }

        }
        #endregion
        #endregion

        public UInt64 RevCount { get; set; }    //接收计数
        public UInt64 SendCount { get; set; }    //发送计数
        public string SendFileName { get; set; }    //外部文件源
        public bool IsComOpen
        {
            get
            {
                return ComDevice.IsOpen;
            }
        }
        private string IniPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Zip", "zuartControl.ini");


        public ZuartControl()
        {
            System.Diagnostics.Debug.WriteLine("ZuartControl");
            InitializeComponent();
            init();
            RevCount = 0;
            SendCount = 0;
        }



        #region 初始化

        private void init()
        {
            if (iniFileName == null) iniFileName = "zuartControl.ini";
            IniPath = Path.Combine(Path.GetDirectoryName(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming).FilePath), iniFileName);
            #region 控件初始化
            cbbComList.Items.AddRange(SerialPort.GetPortNames());
            if (this.ParentForm != null) this.ParentForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setting_save);

            System.Diagnostics.Debug.WriteLine($"init");
            #endregion
            #region 设置保存初始化

            IniFile ini = new IniFile(IniPath);

            cbbComList.Text = ini.Read("cbbComList", "COM");
            cbbBaudRate.Text = ini.Read("cbbBaudRate", "COM") ?? "115200";
            cbbDataBits.Text = ini.Read("cbbDataBits", "COM") ?? "8";
            cbbStopBits.Text = ini.Read("cbbStopBits", "COM") ?? "1";
            cbbParity.Text = ini.Read("cbbParity", "COM") ?? "None";

            if (txtSendData != null) txtSendData.Text = ini.Read("txtSendData", "COM") ?? "";
            txtAutoSendms.Text = ini.Read("txtAutoSendms", "COM") ?? "100";

            chkAutoLine.Checked = (ini.Read("chkAutoLine", "COM") ?? "").Equals("True");
            chkShowTime.Checked = (ini.Read("chkShowTime", "COM") ?? "").Equals("True");
            chkRecSend.Checked = (ini.Read("chkRecSend", "COM") ?? "").Equals("True");
            chkTrans.Checked = (ini.Read("chkTrans", "COM") ?? "").Equals("True");
            //chkfromFileSend.Checked = (ini.Read("chkfromFileSend", "COM") ?? "").Equals("True");
            chkAutoAddSend.Checked = (ini.Read("chkAutoAddSend", "COM") ?? "").Equals("True");
            chkAutoCleanSend.Checked = (ini.Read("chkAutoCleanSend", "COM") ?? "").Equals("True");
            chkAutoSend.Checked = (ini.Read("chkAutoSend", "COM") ?? "").Equals("True");

            rbtnHex.Checked = (ini.Read("rbtnHex", "COM") ?? "").Equals("True");
            rbtnASCII.Checked = (ini.Read("rbtnASCII", "COM") ?? "True").Equals("True");
            rbtnUTF8.Checked = (ini.Read("rbtnUTF8", "COM") ?? "").Equals("True");
            rbtnUnicode.Checked = (ini.Read("rbtnUnicode", "COM") ?? "").Equals("True");
            rbtnSendHex.Checked = (ini.Read("rbtnSendHex", "COM") ?? "").Equals("True");
            rbtnSendASCII.Checked = (ini.Read("rbtnSendASCII", "COM") ?? "True").Equals("True");
            rbtnSendUTF8.Checked = (ini.Read("rbtnSendUTF8", "COM") ?? "").Equals("True");
            rbtnSendUnicode.Checked = (ini.Read("rbtnSendUnicode", "COM") ?? "").Equals("True");

            toolStripMenuItem1.Checked = (ini.Read("toolStripMenuItem1", "COM") ?? "True").Equals("True");
            toolStripMenuItem2.Checked = (ini.Read("toolStripMenuItem2", "COM") ?? "").Equals("True");
            toolStripMenuItem3.Checked = (ini.Read("toolStripMenuItem3", "COM") ?? "").Equals("True");
            toolStripMenuItem4.Checked = (ini.Read("toolStripMenuItem4", "COM") ?? "").Equals("True");

            btnOpen.Focus();
            #endregion
        }
        #endregion

        public void setting_save(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("setting_save");

            IniFile ini = new IniFile(IniPath);
            ini.Write("cbbComList", cbbComList.Text, "COM");
            ini.Write("cbbBaudRate", cbbBaudRate.Text, "COM");
            ini.Write("cbbDataBits", cbbDataBits.Text, "COM");
            ini.Write("cbbStopBits", cbbStopBits.Text, "COM");
            ini.Write("cbbParity", cbbParity.Text, "COM");

            if (txtSendData != null) ini.Write("txtSendData", txtSendData.Text, "COM");
            ini.Write("txtAutoSendms", txtAutoSendms.Text, "COM");

            ini.Write("chkAutoLine", chkAutoLine.Checked.ToString(), "COM");
            ini.Write("chkShowTime", chkShowTime.Checked.ToString(), "COM");
            ini.Write("chkRecSend", chkRecSend.Checked.ToString(), "COM");
            ini.Write("chkTrans", chkTrans.Checked.ToString(), "COM");
            //ini.Write("chkfromFileSend",chkfromFileSend.Checked.ToString(), "COM") 
            ini.Write("chkAutoAddSend", chkAutoAddSend.Checked.ToString(), "COM");
            ini.Write("chkAutoCleanSend", chkAutoCleanSend.Checked.ToString(), "COM");
            ini.Write("chkAutoSend", chkAutoSend.Checked.ToString(), "COM");

            ini.Write("rbtnHex", rbtnHex.Checked.ToString(), "COM");
            ini.Write("rbtnASCII", rbtnASCII.Checked.ToString(), "COM");
            ini.Write("rbtnUTF8", rbtnUTF8.Checked.ToString(), "COM");
            ini.Write("rbtnUnicode", rbtnUnicode.Checked.ToString(), "COM");
            ini.Write("rbtnSendHex", rbtnSendHex.Checked.ToString(), "COM");
            ini.Write("rbtnSendASCII", rbtnSendASCII.Checked.ToString(), "COM");
            ini.Write("rbtnSendUTF8", rbtnSendUTF8.Checked.ToString(), "COM");
            ini.Write("rbtnSendUnicode", rbtnSendUnicode.Checked.ToString(), "COM");

            ini.Write("toolStripMenuItem1", toolStripMenuItem1.Checked.ToString(), "COM");
            ini.Write("toolStripMenuItem2", toolStripMenuItem2.Checked.ToString(), "COM");
            ini.Write("toolStripMenuItem3", toolStripMenuItem3.Checked.ToString(), "COM");
            ini.Write("toolStripMenuItem4", toolStripMenuItem4.Checked.ToString(), "COM");
        }

        private void Log(string s)
        {
            if (Labellog == null) return;
            Labellog.Text = s;
        }

        #region 打开串口按钮
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cbbComList.Items.Count <= 0)
            {
                //MessageBox.Show("没有发现串口,请检查线路！");
                Log("没有发现串口,请检查线路！");
                return;
            }

            try
            {
                //if (ComDevice.IsOpen == false)
                if (btnOpen.Text.Trim() == "打开串口")
                {
                    ComDevice.PortName = cbbComList.Text.ToString();
                    ComDevice.BaudRate = Convert.ToInt32(cbbBaudRate.Text.ToString());
                    ComDevice.Parity = (Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                    ComDevice.DataBits = Convert.ToInt32(cbbDataBits.Text.ToString());
                    ComDevice.StopBits = (StopBits)Convert.ToInt32(cbbStopBits.Text.ToString());

                    ComDevice.Open();
                }
                else
                {
                    ComDevice.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddContent("串口打开错误:" + ex.Message + "\r\n");

            }
            finally
            {
                if (ComDevice.IsOpen == false)
                {
                    if (btnSend != null)
                        btnSend.Enabled = false;
                    chkDTR.Enabled = false;
                    chkRTS.Enabled = false;
                    btnOpen.Text = "打开串口";
                    btnOpen.Image = Properties.Resources.close;
                    Log("串口已关闭");
                }
                else
                {
                    if (btnSend != null)
                        btnSend.Enabled = true;
                    btnOpen.Text = "关闭串口";
                    btnOpen.Image = Properties.Resources.open;
                    // 串口号,波特率,数据位,停止位.校验位
                    Log("串口已开启:" + cbbComList.Text + "," + cbbBaudRate.Text + "," + cbbDataBits.Text + "," + cbbStopBits.Text + "," + cbbParity.Text);

                    chkDTR.Enabled = true;
                    chkRTS.Enabled = true;
                    ComDevice.DtrEnable = chkDTR.Checked;
                    ComDevice.RtsEnable = chkRTS.Checked;
                }

                ComConnectState_EventArgs comConnectState_EventArgs = new ComConnectState_EventArgs();
                comConnectState_EventArgs.IsComOpen = ComDevice.IsOpen;
                if (OnComConnectState != null) OnComConnectState(this, comConnectState_EventArgs);
            }


        }
        private void chkRTS_DTR_CheckedChanged(object sender, EventArgs e)
        {
            ComDevice.DtrEnable = chkDTR.Checked;
            ComDevice.RtsEnable = chkRTS.Checked;
        }
        #endregion
        #region 串口参数设置监听 打开串口后设置串口参数立即生效(关闭后重新打开串口)
        private void cbbComList_DropDown(object sender, EventArgs e)
        {
            cbbComList.Items.Clear();
            cbbComList.Items.AddRange(SerialPort.GetPortNames());
        }
        private void cbbComSetChange(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen)
            {
                btnOpen_Click(null, null);
                btnOpen_Click(null, null);
            }

        }
        #endregion



        #region 发送数据
        public bool SendData(byte[] data)
        {
            return SendData(data, 0, data.LongLength);
        }
        public bool SendData(byte[] data, int data_offset, long data_lenght)
        {
            if (ComDevice.IsOpen)
            {
                try
                {

                    byte[] data_temp = new byte[4096];

                    long offect = 0;
                    long length = 4096;

                    for (offect = data_offset; offect < data.LongLength && offect < data_offset + data_lenght; offect += length)
                    {
                        length = 4096;
                        if (length > data_lenght - offect) length = data_lenght - offect;
                        Array.Copy(data, offect, data_temp, 0, length);
                        ComDevice.Write(data_temp, 0, (int)length);//发送数据
                        SendCount += (UInt64)length;
                    }

                    //ComDevice.Write(data, 0, data.Length);//发送数据
                    //SendCount += (UInt64)data.Length;

                    if (OnComDataSend != null)
                    {
                        ComData_EventArgs comData_EventArgs = new ComData_EventArgs();
                        comData_EventArgs.data = data;
                        OnComDataSend(this, comData_EventArgs);
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddContent("串口未打开\r\n");
            }
            return false;
        }
        #endregion



        #region 发送数据button事件
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (chkfromFileSend.Checked && SendFileName != null && File.Exists(SendFileName))
            {
                byte[] file = File.ReadAllBytes(SendFileName);
                SendData(file);//TODO 发送大量数据时容易出问题 需要优化

                if (chkShowTime.Checked)
                {
                    if (rtxShowData.Text.Length > 0)
                    {
                        rtxShowData.AppendText("\r\n");
                    }
                    rtxShowData.SelectionColor = Color.FromArgb(0X6d6d6d);
                    rtxShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send file:" + "\r\n发送文件数据源:" + SendFileName);
                    if (chkAutoScroll.Checked) rtxShowData.ScrollToCaret();//将滚动条滚动到当前焦点处
                }
                return;
            }
            if (txtSendData == null) return;
            if (txtSendData.Text.Length < 1)
            {
                MessageBox.Show("发送数据为空!", "错误");
                return;
            }
            if (chkAutoSend.Checked)
            {
                if (txtAutoSendms.Text.Length < 1) txtAutoSendms.Text = "500";
                timerAutoSend.Interval = Convert.ToInt32(txtAutoSendms.Text);
                if (timerAutoSend.Enabled)
                {
                    timerAutoSend.Enabled = false;
                    groupBoxComSetting.Enabled = true;
                    groupboxSendSetting.Enabled = true;
                    if (btnSend != null) btnSend.Text = "发送";
                }
                else
                {
                    timerAutoSend.Enabled = true;
                    groupBoxComSetting.Enabled = false;
                    groupboxSendSetting.Enabled = false;
                    if (btnSend != null) btnSend.Text = "停止发送";
                }
            }
            else
            {
                if (SendStr(txtSendData.Text, rbtnSendHex.Checked))
                {
                    if (chkAutoCleanSend.Checked)
                    {
                        txtSendData.Text = "";
                    }
                }
            }
        }
        #endregion


        #region 选择编码发送字符串
        public bool SendStr(String str)
        {
            return SendStr(str, false);
        }
        public bool SendStr(String str, bool ishex)
        {

            byte[] sendData = null;

            if (ishex)
            {
                try
                {
                    sendData = strToHexByte(str.Trim());

                    if (chkShowTime.Checked)
                    {
                        if (rtxShowData.Text.Length > 0)
                        {
                            rtxShowData.AppendText("\r\n");
                        }
                        rtxShowData.SelectionColor = Color.FromArgb(0X6d6d6d);
                        rtxShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send Hex:" + "\r\n");
                        rtxShowData.SelectionColor = Color.FromArgb(0X0000FF);
                        rtxShowData.AppendText(str.Trim());
                        if (chkAutoScroll.Checked) rtxShowData.ScrollToCaret();//将滚动条滚动到当前焦点处
                    }

                }
                catch (Exception)
                {
                    //throw;
                    MessageBox.Show("字符串转十六进制有误,请检测输入格式.", "错误!");
                    return false;
                }
            }
            else
            {
                if (chkShowTime.Checked)
                {
                    if (rtxShowData.Text.Length > 0)
                    {
                        rtxShowData.AppendText("\r\n");
                    }
                    rtxShowData.SelectionColor = Color.FromArgb(0X6d6d6d);
                    rtxShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Send Str:" + "\r\n");
                    rtxShowData.SelectionColor = Color.FromArgb(0X0000FF);
                    rtxShowData.AppendText(str);
                    if (chkAutoScroll.Checked) rtxShowData.ScrollToCaret();//将滚动条滚动到当前焦点处
                }

                #region 转义字符的处理
                if (chkTrans.Checked)
                {//转义字符的处理
                    string s = "";
                    char c_temp = (char)0;
                    int is_trans_status = 0;
                    foreach (char c in str)
                    {
                        switch (is_trans_status)
                        {
                            case 0:
                                {
                                    if (c != '\\')
                                    {
                                        s += c;
                                    }
                                    else
                                    {
                                        is_trans_status = 1;
                                    }
                                    c_temp = (char)0;
                                    continue;
                                }
                            case 1:
                                switch (c)
                                {
                                    case 'a': s += '\x07'; is_trans_status = 0; break;
                                    case 'b': s += '\x08'; is_trans_status = 0; break;
                                    case 'f': s += '\x0C'; is_trans_status = 0; break;
                                    case 'n': s += '\x0A'; is_trans_status = 0; break;
                                    case 'r': s += '\x0D'; is_trans_status = 0; break;
                                    case 't': s += '\x09'; is_trans_status = 0; break;
                                    case 'v': s += '\x0B'; is_trans_status = 0; break;
                                    case '\\': s += '\\'; is_trans_status = 0; break;
                                    case '\'': s += '\''; is_trans_status = 0; break;
                                    case '\"': s += '\x22'; is_trans_status = 0; break;
                                    case '?': s += '?'; is_trans_status = 0; break;
                                    //case '0': s += '\x00'; is_trans_status = 0; break;
                                    case 'x': is_trans_status = 2; break;
                                    case '0': goto CASE_7;
                                    case '1': goto CASE_7;
                                    case '2': goto CASE_7;
                                    case '3': goto CASE_7;
                                    case '4': goto CASE_7;
                                    case '5': goto CASE_7;
                                    case '6': goto CASE_7;
                                    case '7':
                                    CASE_7:
                                        c_temp = (char)(c - '0');
                                        is_trans_status = 4;
                                        break;
                                    default:
                                        s += c;
                                        is_trans_status = 0;
                                        break;
                                }
                                break;
                            case 2:
                                {
                                    is_trans_status++;
                                    if (c <= 'F' && c >= 'A')
                                    {
                                        c_temp = (char)(c - 'A' + 10);
                                    }
                                    else if (c <= 'f' && c >= 'a')
                                    {
                                        c_temp = (char)(c - 'a' + 10);
                                    }
                                    if (c <= '9' && c >= '0')
                                    {
                                        c_temp = (char)(c - '0');
                                    }
                                    else
                                    {   //\x后非十六进制,着则忽略\符号
                                        s += 'x' + c;
                                        is_trans_status = 0;
                                    }
                                }
                                break;
                            case 3:
                                {
                                    if (c <= 'F' && c >= 'A')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - 'A' + 10));
                                    }
                                    else if (c <= 'f' && c >= 'a')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - 'a' + 10));
                                    }
                                    if (c <= '9' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 16 + (c - '0'));
                                    }

                                    s += c_temp;

                                    if (!((c <= 'F' && c >= 'A') || (c <= 'f' && c >= 'a') || (c <= '9' && c >= '0')))
                                    {
                                        s += c;
                                    }

                                    is_trans_status = 0;
                                }
                                break;

                            case 4://\d[d]
                                {
                                    if (c < '8' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 8 + c - '0');
                                        is_trans_status++;
                                    }
                                    else
                                    {   //\d后非8进制
                                        s += c_temp;
                                        s += c;
                                        is_trans_status = 0;
                                    }
                                }
                                break;
                            case 5: //\dd[d]最后一个字符
                                {
                                    if (c < '8' && c >= '0')
                                    {
                                        c_temp = (char)(c_temp * 8 + c - '0');
                                    }
                                    s += c_temp;

                                    if (!(c < '8' && c >= '0'))
                                    {
                                        s += c;
                                    }
                                    is_trans_status = 0;
                                }
                                break;
                        }
                    }

                    if (is_trans_status >= 2 && is_trans_status <= 5) s += c_temp;


                    str = s;
                    //str = Regex.Replace(str, @"(?<!\\)\\a", "\a");
                    //str = Regex.Replace(str, @"(?<!\\)\\b", "\b");
                    //str = Regex.Replace(str, @"(?<!\\)\\f", "\f");
                    //str = Regex.Replace(str, @"(?<!\\)\\n", "\n");
                    //str = Regex.Replace(str, @"(?<!\\)\\r", "\r");
                    //str = Regex.Replace(str, @"(?<!\\)\\t", "\t");
                    //str = Regex.Replace(str, @"(?<!\\)\\v", "\v");
                    //str = Regex.Replace(str, @"(?<!\\)\\\\", "\\");
                    //str = Regex.Replace(str, @"(?<!\\)\\'", "\'");
                    //str = Regex.Replace(str, @"(?<!\\)\\""", "\"");
                    //str = Regex.Replace(str, @"(?<!\\)\\?", "?");
                    //str = Regex.Replace(str, @"(?<!\\)\\0", "\0");

                    #endregion

                }
                if (rbtnSendASCII.Checked)
                {
                    //sendData = Encoding.ASCII.GetBytes(str);
                    sendData = Encoding.GetEncoding("GBK").GetBytes(str);
                }
                else if (rbtnSendUTF8.Checked)
                {
                    sendData = Encoding.UTF8.GetBytes(str);
                }
                else if (rbtnSendUnicode.Checked)
                {
                    sendData = Encoding.Unicode.GetBytes(str);
                }
                else
                {
                    sendData = Encoding.GetEncoding("GBK").GetBytes(str);
                }
            }

            if (this.SendData(sendData))//发送数据成功计数
            {
                return true;
            }

            return false;
        }
        #endregion

        #region 字符串转换16进制字节数组
        private byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0) hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
            return returnBytes;
        }
        #endregion

        #region 接收数据监听
        private void Com_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            this.BeginInvoke(new MethodInvoker(delegate
            {
                RevCount += (UInt64)ReDatas.Length;
                string str = this.AddData(ReDatas);//输出数据
                ComData_EventArgs comDataReceived_EventArgs = new ComData_EventArgs();
                comDataReceived_EventArgs.data = ReDatas;
                comDataReceived_EventArgs.recived_string = str;
                if (OnComDataReceived != null) OnComDataReceived(this, comDataReceived_EventArgs);
            }));
        }
        #endregion
        #region 接收文本框,输入监听,供输入直接发送
        private void txtShowData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkRecSend.Checked && ComDevice.IsOpen)
            {
                //if ((e.KeyChar >= ' ' && e.KeyChar <= '~') || e.KeyChar == '\r')//这是允许输入退格键允许输入0-9数字
                //{
                SendStr(e.KeyChar.ToString(), false);
                e.Handled = true;
                //}
            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion
        #region 发送文本框,输入监听,供设置发送/换行按键
        private bool eHandled = false;
        private void txtSendData_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = eHandled;

            if (rbtnSendHex.Checked && !eHandled)
            {   //\u0016\u0001\u0018\u0003\u001a
                if (!"\r\babcdefABCDEF 0123456789".Contains(e.KeyChar.ToString()) && e.KeyChar > '\u0020')
                {
                    e.Handled = true;
                }
            }
        }
        private void txtSendData_KeyDown(object sender, KeyEventArgs e)
        {
            eHandled = false;
            if (e.KeyCode == Keys.Enter && e.Control && !e.Shift)
            {
                //Console.WriteLine("Ctrl+Enter");
                if (toolStripMenuItem3.CheckState == CheckState.Checked)
                {//Ctrl+Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            else if (e.KeyCode == Keys.Enter && !e.Control && e.Shift)
            {
                //Console.WriteLine("Shift+Enter");
                if (toolStripMenuItem4.CheckState == CheckState.Checked)
                {//Shift+Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            else if (e.KeyCode == Keys.Enter && !e.Shift && !e.Control && !e.Alt)
            {
                //Console.WriteLine("Enter");
                if (toolStripMenuItem1.CheckState == CheckState.Checked || toolStripMenuItem2.CheckState == CheckState.Checked)
                {//Enter 发送
                    e.Handled = true;
                    btnSend_Click(null, null);
                }
            }
            eHandled = e.Handled;
        }
        #endregion
        #region 接收文本框字符处理
        public string Byte2String(byte[] data)
        {
            string str;
            if (rbtnHex.Checked)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.AppendFormat("{0:x2}" + " ", data[i]);
                }
                str = sb.ToString().ToUpper();
            }
            else if (rbtnUTF8.Checked)
            {
                str = new UTF8Encoding().GetString(data);
            }
            else if (rbtnUnicode.Checked)
            {
                str = new UnicodeEncoding().GetString(data);
            }
            else// if (rbtnASCII.Checked)
            {
                str = Encoding.GetEncoding("GBK").GetString(data);
                //AddContent(new ASCIIEncoding().GetString(data));
            }
            return str;
        }
        public string AddData(byte[] data)
        {
            string str;
            str = Byte2String(data);
            if (chkIsShow.Checked) return str;
            AddContent(str);
            return str;
        }




        //输入到显示区域
        public void AddContent(string content)
        {
            AddContent(content, true);
        }
        public void AddContent(string content, bool isChkAutoLine)
        {
            //this.BeginInvoke(new MethodInvoker(delegate
            //{
            string str = "";
            if (rtxShowData == null) return;

            if (chkAutoLine.Checked && rtxShowData.Text.Length > 0 && isChkAutoLine)
            {
                //str = "\r\n";
                rtxShowData.AppendText("\r\n");
            }

            if (chkShowTime.Checked)
            {
                //str += " [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "] Rec:" + "\r\n";
                rtxShowData.SelectionColor = Color.FromArgb(0X6d6d6d);
                rtxShowData.AppendText(" [" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "]" + "\r\n");
            }

            rtxShowData.SelectionColor = Color.FromArgb(0X008000);
            str += content;

            rtxShowData.AppendText(str);
            if (chkAutoScroll.Checked) rtxShowData.ScrollToCaret();//将滚动条滚动到当前焦点处

            //}));
        }
        #endregion

        #region 清空接收区
        private void lkbClearRev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rtxShowData != null)
                rtxShowData.Clear();
        }
        #endregion
        #region 清空发送
        private void lkbClearSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtSendData != null) txtSendData.Clear();

        }
        #endregion

        #region 显示接受时间监听
        private void chkShowTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowTime.Checked)
            {
                chkAutoLine.Checked = true;
                chkAutoLine.Enabled = false;
                chkShowTime.Checked = true;
            }
            else
            {
                chkAutoLine.Enabled = true;
            }
        }
        #endregion

        #region 保存数据
        private void lkbSaveRev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (rtxShowData.Text.Length < 1)
            //{
            //    MessageBox("");
            //    return;
            //}
            if (rtxShowData == null) return;
            StreamWriter myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "文本文档(*.txt)|*.txt|所有文件(*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "保存接受区数据";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                myStream = new StreamWriter(saveFileDialog1.FileName);
                myStream.Write(rtxShowData.Text); //写入
                myStream.Close();//关闭流
            }
        }


        #endregion

        #region 外部文件源载入 
        private void chkfromFileSend_CheckedChanged(object sender, EventArgs e)
        {
            if (chkfromFileSend.Checked)
            {
                OpenFileDialog ofdg = new OpenFileDialog();
                if (ofdg.ShowDialog(this) == DialogResult.OK)
                {
                    SendFileName = ofdg.FileName;//得到选择的文件的完整路径
                                                 //if (txtSendData != null) txtSendData.Text = System.IO.File.ReadAllText(file, Encoding.Default);//把读出来的数据显示在textbox中

                    if (txtSendData != null)
                    {
                        //txtSendData.Enabled = false;
                        txtSendData.Tag = txtSendData.Text;
                        txtSendData.Text = "启用外部文件数据源:\r\n" + ofdg.FileName;
                    }
                }
                else
                {
                    chkfromFileSend.Checked = false;
                }
            }
            txtSendData.Enabled = !chkfromFileSend.Checked;
            if (txtSendData.Enabled)
            {
                txtSendData.Text = (string)txtSendData.Tag;
                SendFileName = null;
            }

        }
        #endregion



        #region 自动定时发送
        #region 自动发送定时器函数
        private void timerAutoSend_Tick(object sender, EventArgs e)
        {
            if (txtSendData != null)
            {
                SendStr(txtSendData.Text, rbtnSendHex.Checked);
            }
        }
        #endregion
        #region 自动发送间隔时间,只能输入数字
        private void txtAutoSendms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b' && ((e.KeyChar < '0') || (e.KeyChar > '9')))//这是允许输入退格键允许输入0-9数字
            {
                e.Handled = true;
            }
        }
        #endregion

        #endregion


        #region 编码RadioButton控件单击监听
        private void rbtnSend_Click(object sender, EventArgs e)
        {
            rbtnSendHex.Checked = false;
            rbtnSendASCII.Checked = false;
            rbtnSendUTF8.Checked = false;
            rbtnSendUnicode.Checked = false;
            ((RadioButton)sender).Checked = true;
        }
        private void rbtn_Click(object sender, EventArgs e)
        {
            rbtnHex.Checked = false;
            rbtnASCII.Checked = false;
            rbtnUTF8.Checked = false;
            rbtnUnicode.Checked = false;
            ((RadioButton)sender).Checked = true;
        }
        #endregion

        private void lkbSendKey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menuSendKey.Show(lkbSendKey, 0, lkbSendKey.Height);

        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.CheckState = CheckState.Unchecked;
            toolStripMenuItem2.CheckState = CheckState.Unchecked;
            toolStripMenuItem3.CheckState = CheckState.Unchecked;
            toolStripMenuItem4.CheckState = CheckState.Unchecked;

            ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;

        }

        private void toolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (((ToolStripMenuItem)sender).CheckState == CheckState.Checked)
                lkbSendKey.Text = ((ToolStripMenuItem)sender).Text;
        }

        int X = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                ((Timer)sender).Enabled = false;
                this.ParentForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setting_save);
            }
        }
    }
}
