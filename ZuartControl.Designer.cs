namespace ZuartControl
{
    partial class ZuartControl
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_Setting = new System.Windows.Forms.Panel();
            this.groupboxRecSetting = new System.Windows.Forms.GroupBox();
            this.chkIsShow = new System.Windows.Forms.CheckBox();
            this.chkAutoScroll = new System.Windows.Forms.CheckBox();
            this.chkRecSend = new System.Windows.Forms.CheckBox();
            this.lkbSaveRev = new System.Windows.Forms.LinkLabel();
            this.rbtnUnicode = new System.Windows.Forms.RadioButton();
            this.rbtnUTF8 = new System.Windows.Forms.RadioButton();
            this.rbtnASCII = new System.Windows.Forms.RadioButton();
            this.rbtnHex = new System.Windows.Forms.RadioButton();
            this.lkbClearRev = new System.Windows.Forms.LinkLabel();
            this.chkShowTime = new System.Windows.Forms.CheckBox();
            this.chkAutoLine = new System.Windows.Forms.CheckBox();
            this.tabControlComNet = new System.Windows.Forms.TabControl();
            this.tabComSetting = new System.Windows.Forms.TabPage();
            this.chkDTR = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRTS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnComOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.cbbComList = new System.Windows.Forms.ComboBox();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.tabNetSetting = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbNetList = new System.Windows.Forms.ComboBox();
            this.groupboxSendSetting = new System.Windows.Forms.GroupBox();
            this.chkfromFileSend = new System.Windows.Forms.CheckBox();
            this.txtAutoSendms = new System.Windows.Forms.TextBox();
            this.chkAutoCleanSend = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.chkAutoAddSend = new System.Windows.Forms.CheckBox();
            this.rbtnSendUnicode = new System.Windows.Forms.RadioButton();
            this.rbtnSendHex = new System.Windows.Forms.RadioButton();
            this.rbtnSendASCII = new System.Windows.Forms.RadioButton();
            this.rbtnSendUTF8 = new System.Windows.Forms.RadioButton();
            this.lkbSendKey = new System.Windows.Forms.LinkLabel();
            this.lkbClearSend = new System.Windows.Forms.LinkLabel();
            this.ComDevice = new System.IO.Ports.SerialPort(this.components);
            this.timerAutoSend = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuSendKey = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbLocalIP = new System.Windows.Forms.ComboBox();
            this.btNetOpen = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.panel_Setting.SuspendLayout();
            this.groupboxRecSetting.SuspendLayout();
            this.tabControlComNet.SuspendLayout();
            this.tabComSetting.SuspendLayout();
            this.tabNetSetting.SuspendLayout();
            this.groupboxSendSetting.SuspendLayout();
            this.menuSendKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Setting
            // 
            this.panel_Setting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Setting.BackColor = System.Drawing.SystemColors.Control;
            this.panel_Setting.Controls.Add(this.groupboxRecSetting);
            this.panel_Setting.Controls.Add(this.tabControlComNet);
            this.panel_Setting.Controls.Add(this.groupboxSendSetting);
            this.panel_Setting.Location = new System.Drawing.Point(0, 0);
            this.panel_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Setting.Name = "panel_Setting";
            this.panel_Setting.Size = new System.Drawing.Size(161, 579);
            this.panel_Setting.TabIndex = 0;
            // 
            // groupboxRecSetting
            // 
            this.groupboxRecSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxRecSetting.Controls.Add(this.chkIsShow);
            this.groupboxRecSetting.Controls.Add(this.chkAutoScroll);
            this.groupboxRecSetting.Controls.Add(this.chkRecSend);
            this.groupboxRecSetting.Controls.Add(this.lkbSaveRev);
            this.groupboxRecSetting.Controls.Add(this.rbtnUnicode);
            this.groupboxRecSetting.Controls.Add(this.rbtnUTF8);
            this.groupboxRecSetting.Controls.Add(this.rbtnASCII);
            this.groupboxRecSetting.Controls.Add(this.rbtnHex);
            this.groupboxRecSetting.Controls.Add(this.lkbClearRev);
            this.groupboxRecSetting.Controls.Add(this.chkShowTime);
            this.groupboxRecSetting.Controls.Add(this.chkAutoLine);
            this.groupboxRecSetting.Location = new System.Drawing.Point(4, 206);
            this.groupboxRecSetting.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxRecSetting.Name = "groupboxRecSetting";
            this.groupboxRecSetting.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxRecSetting.Size = new System.Drawing.Size(153, 161);
            this.groupboxRecSetting.TabIndex = 2;
            this.groupboxRecSetting.TabStop = false;
            this.groupboxRecSetting.Text = "接收区设置";
            // 
            // chkIsShow
            // 
            this.chkIsShow.AutoSize = true;
            this.chkIsShow.Location = new System.Drawing.Point(15, 81);
            this.chkIsShow.Margin = new System.Windows.Forms.Padding(4);
            this.chkIsShow.Name = "chkIsShow";
            this.chkIsShow.Size = new System.Drawing.Size(108, 16);
            this.chkIsShow.TabIndex = 4;
            this.chkIsShow.Text = "接收数据不显示";
            this.chkIsShow.UseVisualStyleBackColor = true;
            // 
            // chkAutoScroll
            // 
            this.chkAutoScroll.AutoSize = true;
            this.chkAutoScroll.Checked = true;
            this.chkAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoScroll.Location = new System.Drawing.Point(15, 65);
            this.chkAutoScroll.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoScroll.Name = "chkAutoScroll";
            this.chkAutoScroll.Size = new System.Drawing.Size(72, 16);
            this.chkAutoScroll.TabIndex = 3;
            this.chkAutoScroll.Text = "自动滚屏";
            this.chkAutoScroll.UseVisualStyleBackColor = true;
            // 
            // chkRecSend
            // 
            this.chkRecSend.AutoSize = true;
            this.chkRecSend.Location = new System.Drawing.Point(15, 49);
            this.chkRecSend.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecSend.Name = "chkRecSend";
            this.chkRecSend.Size = new System.Drawing.Size(96, 16);
            this.chkRecSend.TabIndex = 2;
            this.chkRecSend.Text = "输入直接发送";
            this.chkRecSend.UseVisualStyleBackColor = true;
            // 
            // lkbSaveRev
            // 
            this.lkbSaveRev.AutoSize = true;
            this.lkbSaveRev.Location = new System.Drawing.Point(12, 140);
            this.lkbSaveRev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkbSaveRev.Name = "lkbSaveRev";
            this.lkbSaveRev.Size = new System.Drawing.Size(53, 12);
            this.lkbSaveRev.TabIndex = 9;
            this.lkbSaveRev.TabStop = true;
            this.lkbSaveRev.Text = "保存数据";
            this.lkbSaveRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSaveRev_LinkClicked);
            // 
            // rbtnUnicode
            // 
            this.rbtnUnicode.AutoSize = true;
            this.rbtnUnicode.Location = new System.Drawing.Point(70, 117);
            this.rbtnUnicode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnUnicode.Name = "rbtnUnicode";
            this.rbtnUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnUnicode.TabIndex = 8;
            this.rbtnUnicode.Text = "Unicode";
            this.rbtnUnicode.UseVisualStyleBackColor = true;
            this.rbtnUnicode.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnUTF8
            // 
            this.rbtnUTF8.AutoSize = true;
            this.rbtnUTF8.Location = new System.Drawing.Point(13, 117);
            this.rbtnUTF8.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnUTF8.Name = "rbtnUTF8";
            this.rbtnUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnUTF8.TabIndex = 7;
            this.rbtnUTF8.Text = "UTF-8";
            this.rbtnUTF8.UseVisualStyleBackColor = true;
            this.rbtnUTF8.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnASCII
            // 
            this.rbtnASCII.AutoSize = true;
            this.rbtnASCII.Checked = true;
            this.rbtnASCII.Location = new System.Drawing.Point(70, 99);
            this.rbtnASCII.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnASCII.Name = "rbtnASCII";
            this.rbtnASCII.Size = new System.Drawing.Size(41, 16);
            this.rbtnASCII.TabIndex = 6;
            this.rbtnASCII.TabStop = true;
            this.rbtnASCII.Text = "GBK";
            this.rbtnASCII.UseVisualStyleBackColor = true;
            this.rbtnASCII.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // rbtnHex
            // 
            this.rbtnHex.AutoSize = true;
            this.rbtnHex.Location = new System.Drawing.Point(14, 99);
            this.rbtnHex.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnHex.Name = "rbtnHex";
            this.rbtnHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnHex.TabIndex = 5;
            this.rbtnHex.Text = "Hex";
            this.rbtnHex.UseVisualStyleBackColor = true;
            this.rbtnHex.Click += new System.EventHandler(this.rbtn_Click);
            // 
            // lkbClearRev
            // 
            this.lkbClearRev.AutoSize = true;
            this.lkbClearRev.Location = new System.Drawing.Point(76, 140);
            this.lkbClearRev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkbClearRev.Name = "lkbClearRev";
            this.lkbClearRev.Size = new System.Drawing.Size(53, 12);
            this.lkbClearRev.TabIndex = 10;
            this.lkbClearRev.TabStop = true;
            this.lkbClearRev.Text = "清除接收";
            this.lkbClearRev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearRev_LinkClicked);
            // 
            // chkShowTime
            // 
            this.chkShowTime.AutoSize = true;
            this.chkShowTime.Location = new System.Drawing.Point(15, 33);
            this.chkShowTime.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowTime.Name = "chkShowTime";
            this.chkShowTime.Size = new System.Drawing.Size(96, 16);
            this.chkShowTime.TabIndex = 1;
            this.chkShowTime.Text = "日志模式显示";
            this.chkShowTime.UseVisualStyleBackColor = true;
            this.chkShowTime.CheckedChanged += new System.EventHandler(this.chkShowTime_CheckedChanged);
            // 
            // chkAutoLine
            // 
            this.chkAutoLine.AutoSize = true;
            this.chkAutoLine.Location = new System.Drawing.Point(15, 17);
            this.chkAutoLine.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoLine.Name = "chkAutoLine";
            this.chkAutoLine.Size = new System.Drawing.Size(96, 16);
            this.chkAutoLine.TabIndex = 0;
            this.chkAutoLine.Text = "自动换行显示";
            this.chkAutoLine.UseVisualStyleBackColor = true;
            // 
            // tabControlComNet
            // 
            this.tabControlComNet.Controls.Add(this.tabComSetting);
            this.tabControlComNet.Controls.Add(this.tabNetSetting);
            this.tabControlComNet.Location = new System.Drawing.Point(-4, -1);
            this.tabControlComNet.Name = "tabControlComNet";
            this.tabControlComNet.SelectedIndex = 0;
            this.tabControlComNet.Size = new System.Drawing.Size(170, 213);
            this.tabControlComNet.TabIndex = 4;
            this.tabControlComNet.SelectedIndexChanged += new System.EventHandler(this.tabControlComNet_SelectedIndexChanged);
            // 
            // tabComSetting
            // 
            this.tabComSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabComSetting.Controls.Add(this.chkDTR);
            this.tabComSetting.Controls.Add(this.label1);
            this.tabComSetting.Controls.Add(this.chkRTS);
            this.tabComSetting.Controls.Add(this.label3);
            this.tabComSetting.Controls.Add(this.cbbParity);
            this.tabComSetting.Controls.Add(this.label4);
            this.tabComSetting.Controls.Add(this.cbbStopBits);
            this.tabComSetting.Controls.Add(this.label5);
            this.tabComSetting.Controls.Add(this.btnComOpen);
            this.tabComSetting.Controls.Add(this.label2);
            this.tabComSetting.Controls.Add(this.cbbDataBits);
            this.tabComSetting.Controls.Add(this.cbbComList);
            this.tabComSetting.Controls.Add(this.cbbBaudRate);
            this.tabComSetting.Location = new System.Drawing.Point(4, 22);
            this.tabComSetting.Margin = new System.Windows.Forms.Padding(0);
            this.tabComSetting.Name = "tabComSetting";
            this.tabComSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabComSetting.Size = new System.Drawing.Size(162, 187);
            this.tabComSetting.TabIndex = 0;
            this.tabComSetting.Text = "端口设置";
            // 
            // chkDTR
            // 
            this.chkDTR.AutoSize = true;
            this.chkDTR.Checked = true;
            this.chkDTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDTR.Enabled = false;
            this.chkDTR.Location = new System.Drawing.Point(91, 121);
            this.chkDTR.Margin = new System.Windows.Forms.Padding(4);
            this.chkDTR.Name = "chkDTR";
            this.chkDTR.Size = new System.Drawing.Size(42, 16);
            this.chkDTR.TabIndex = 7;
            this.chkDTR.Text = "DTR";
            this.chkDTR.UseVisualStyleBackColor = true;
            this.chkDTR.CheckedChanged += new System.EventHandler(this.chkRTS_DTR_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkRTS
            // 
            this.chkRTS.AutoSize = true;
            this.chkRTS.Checked = true;
            this.chkRTS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRTS.Enabled = false;
            this.chkRTS.Location = new System.Drawing.Point(15, 121);
            this.chkRTS.Margin = new System.Windows.Forms.Padding(4);
            this.chkRTS.Name = "chkRTS";
            this.chkRTS.Size = new System.Drawing.Size(42, 16);
            this.chkRTS.TabIndex = 6;
            this.chkRTS.Text = "RTS";
            this.chkRTS.UseVisualStyleBackColor = true;
            this.chkRTS.CheckedChanged += new System.EventHandler(this.chkRTS_DTR_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "数据位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbParity
            // 
            this.cbbParity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbbParity.Location = new System.Drawing.Point(52, 97);
            this.cbbParity.Margin = new System.Windows.Forms.Padding(4);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(101, 20);
            this.cbbParity.TabIndex = 5;
            this.cbbParity.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "停止位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbStopBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbStopBits.Location = new System.Drawing.Point(52, 73);
            this.cbbStopBits.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(101, 20);
            this.cbbStopBits.TabIndex = 4;
            this.cbbStopBits.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "校验位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnComOpen
            // 
            this.btnComOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnComOpen.Font = new System.Drawing.Font("宋体", 10F);
            this.btnComOpen.Image = global::ZuartControl.Properties.Resources.close;
            this.btnComOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComOpen.Location = new System.Drawing.Point(0, 139);
            this.btnComOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnComOpen.Name = "btnComOpen";
            this.btnComOpen.Padding = new System.Windows.Forms.Padding(11, 0, 33, 0);
            this.btnComOpen.Size = new System.Drawing.Size(162, 41);
            this.btnComOpen.TabIndex = 8;
            this.btnComOpen.Text = " 打开串口";
            this.btnComOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnComOpen.UseVisualStyleBackColor = true;
            this.btnComOpen.Click += new System.EventHandler(this.btnComOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDataBits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbbDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.cbbDataBits.Location = new System.Drawing.Point(52, 49);
            this.cbbDataBits.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(101, 20);
            this.cbbDataBits.TabIndex = 3;
            this.cbbDataBits.Text = "8";
            this.cbbDataBits.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // cbbComList
            // 
            this.cbbComList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbComList.DisplayMember = "1";
            this.cbbComList.Location = new System.Drawing.Point(52, 1);
            this.cbbComList.Margin = new System.Windows.Forms.Padding(4);
            this.cbbComList.Name = "cbbComList";
            this.cbbComList.Size = new System.Drawing.Size(101, 20);
            this.cbbComList.TabIndex = 1;
            this.cbbComList.DropDown += new System.EventHandler(this.cbbComList_DropDown);
            this.cbbComList.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBaudRate.DisplayMember = "1";
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "74880",
            "115200",
            "128000",
            "256000"});
            this.cbbBaudRate.Location = new System.Drawing.Point(52, 25);
            this.cbbBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(101, 20);
            this.cbbBaudRate.TabIndex = 2;
            this.cbbBaudRate.Text = "115200";
            this.cbbBaudRate.ValueMember = "1";
            this.cbbBaudRate.TextChanged += new System.EventHandler(this.cbbComSetChange);
            // 
            // tabNetSetting
            // 
            this.tabNetSetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabNetSetting.Controls.Add(this.btNetOpen);
            this.tabNetSetting.Controls.Add(this.cbbClient);
            this.tabNetSetting.Controls.Add(this.cbbLocalIP);
            this.tabNetSetting.Controls.Add(this.txtLocalPort);
            this.tabNetSetting.Controls.Add(this.label11);
            this.tabNetSetting.Controls.Add(this.txtRemotePort);
            this.tabNetSetting.Controls.Add(this.label9);
            this.tabNetSetting.Controls.Add(this.txtRemoteIP);
            this.tabNetSetting.Controls.Add(this.label7);
            this.tabNetSetting.Controls.Add(this.label10);
            this.tabNetSetting.Controls.Add(this.label8);
            this.tabNetSetting.Controls.Add(this.label6);
            this.tabNetSetting.Controls.Add(this.cbbNetList);
            this.tabNetSetting.Location = new System.Drawing.Point(4, 22);
            this.tabNetSetting.Name = "tabNetSetting";
            this.tabNetSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetSetting.Size = new System.Drawing.Size(162, 187);
            this.tabNetSetting.TabIndex = 1;
            this.tabNetSetting.Text = "网络设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "2.远程主机地址";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "1.协议";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbNetList
            // 
            this.cbbNetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNetList.DisplayMember = "1";
            this.cbbNetList.Items.AddRange(new object[] {
            "UDP",
            "TCP Client",
            "TCP Server"});
            this.cbbNetList.Location = new System.Drawing.Point(49, 2);
            this.cbbNetList.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNetList.Name = "cbbNetList";
            this.cbbNetList.Size = new System.Drawing.Size(107, 20);
            this.cbbNetList.TabIndex = 3;
            this.cbbNetList.SelectedIndexChanged += new System.EventHandler(this.cbbNetList_SelectedIndexChanged);
            this.cbbNetList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLocalIP_KeyPress);
            // 
            // groupboxSendSetting
            // 
            this.groupboxSendSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupboxSendSetting.Controls.Add(this.chkfromFileSend);
            this.groupboxSendSetting.Controls.Add(this.txtAutoSendms);
            this.groupboxSendSetting.Controls.Add(this.chkAutoCleanSend);
            this.groupboxSendSetting.Controls.Add(this.chkAutoSend);
            this.groupboxSendSetting.Controls.Add(this.chkTrans);
            this.groupboxSendSetting.Controls.Add(this.chkAutoAddSend);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUnicode);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendHex);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendASCII);
            this.groupboxSendSetting.Controls.Add(this.rbtnSendUTF8);
            this.groupboxSendSetting.Controls.Add(this.lkbSendKey);
            this.groupboxSendSetting.Controls.Add(this.lkbClearSend);
            this.groupboxSendSetting.Location = new System.Drawing.Point(4, 384);
            this.groupboxSendSetting.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxSendSetting.Name = "groupboxSendSetting";
            this.groupboxSendSetting.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxSendSetting.Size = new System.Drawing.Size(153, 190);
            this.groupboxSendSetting.TabIndex = 3;
            this.groupboxSendSetting.TabStop = false;
            this.groupboxSendSetting.Text = "发送区设置";
            // 
            // chkfromFileSend
            // 
            this.chkfromFileSend.AutoSize = true;
            this.chkfromFileSend.Location = new System.Drawing.Point(4, 38);
            this.chkfromFileSend.Margin = new System.Windows.Forms.Padding(4);
            this.chkfromFileSend.Name = "chkfromFileSend";
            this.chkfromFileSend.Size = new System.Drawing.Size(108, 16);
            this.chkfromFileSend.TabIndex = 1;
            this.chkfromFileSend.Text = "打开文件数据源";
            this.chkfromFileSend.UseVisualStyleBackColor = true;
            this.chkfromFileSend.CheckedChanged += new System.EventHandler(this.chkfromFileSend_CheckedChanged);
            // 
            // txtAutoSendms
            // 
            this.txtAutoSendms.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtAutoSendms.Location = new System.Drawing.Point(98, 93);
            this.txtAutoSendms.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutoSendms.MaxLength = 5;
            this.txtAutoSendms.Name = "txtAutoSendms";
            this.txtAutoSendms.Size = new System.Drawing.Size(41, 21);
            this.txtAutoSendms.TabIndex = 4;
            this.txtAutoSendms.Text = "500";
            this.txtAutoSendms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip1.SetToolTip(this.txtAutoSendms, "建议20-60000范围内");
            this.txtAutoSendms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutoSendms_KeyPress);
            // 
            // chkAutoCleanSend
            // 
            this.chkAutoCleanSend.AutoSize = true;
            this.chkAutoCleanSend.Location = new System.Drawing.Point(4, 76);
            this.chkAutoCleanSend.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoCleanSend.Name = "chkAutoCleanSend";
            this.chkAutoCleanSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoCleanSend.TabIndex = 3;
            this.chkAutoCleanSend.Text = "发送完自动清空";
            this.chkAutoCleanSend.UseVisualStyleBackColor = true;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(4, 95);
            this.chkAutoSend.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(96, 16);
            this.chkAutoSend.TabIndex = 5;
            this.chkAutoSend.Text = "发送周期(ms)";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkTrans.Location = new System.Drawing.Point(4, 19);
            this.chkTrans.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(96, 16);
            this.chkTrans.TabIndex = 0;
            this.chkTrans.Text = "转义字符处理";
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // chkAutoAddSend
            // 
            this.chkAutoAddSend.AutoSize = true;
            this.chkAutoAddSend.Enabled = false;
            this.chkAutoAddSend.Location = new System.Drawing.Point(4, 57);
            this.chkAutoAddSend.Margin = new System.Windows.Forms.Padding(4);
            this.chkAutoAddSend.Name = "chkAutoAddSend";
            this.chkAutoAddSend.Size = new System.Drawing.Size(108, 16);
            this.chkAutoAddSend.TabIndex = 2;
            this.chkAutoAddSend.Text = "自动发送附加位";
            this.chkAutoAddSend.UseVisualStyleBackColor = true;
            // 
            // rbtnSendUnicode
            // 
            this.rbtnSendUnicode.AutoSize = true;
            this.rbtnSendUnicode.Location = new System.Drawing.Point(70, 132);
            this.rbtnSendUnicode.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSendUnicode.Name = "rbtnSendUnicode";
            this.rbtnSendUnicode.Size = new System.Drawing.Size(65, 16);
            this.rbtnSendUnicode.TabIndex = 9;
            this.rbtnSendUnicode.Text = "Unicode";
            this.rbtnSendUnicode.UseVisualStyleBackColor = true;
            this.rbtnSendUnicode.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendHex
            // 
            this.rbtnSendHex.AutoSize = true;
            this.rbtnSendHex.Location = new System.Drawing.Point(13, 116);
            this.rbtnSendHex.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSendHex.Name = "rbtnSendHex";
            this.rbtnSendHex.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendHex.TabIndex = 6;
            this.rbtnSendHex.Text = "Hex";
            this.rbtnSendHex.UseVisualStyleBackColor = true;
            this.rbtnSendHex.CheckedChanged += new System.EventHandler(this.rbtnSendHex_CheckedChanged);
            this.rbtnSendHex.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendASCII
            // 
            this.rbtnSendASCII.AutoSize = true;
            this.rbtnSendASCII.Checked = true;
            this.rbtnSendASCII.Location = new System.Drawing.Point(70, 117);
            this.rbtnSendASCII.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSendASCII.Name = "rbtnSendASCII";
            this.rbtnSendASCII.Size = new System.Drawing.Size(41, 16);
            this.rbtnSendASCII.TabIndex = 7;
            this.rbtnSendASCII.TabStop = true;
            this.rbtnSendASCII.Text = "GBK";
            this.rbtnSendASCII.UseVisualStyleBackColor = true;
            this.rbtnSendASCII.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // rbtnSendUTF8
            // 
            this.rbtnSendUTF8.AutoSize = true;
            this.rbtnSendUTF8.Location = new System.Drawing.Point(13, 132);
            this.rbtnSendUTF8.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSendUTF8.Name = "rbtnSendUTF8";
            this.rbtnSendUTF8.Size = new System.Drawing.Size(53, 16);
            this.rbtnSendUTF8.TabIndex = 8;
            this.rbtnSendUTF8.Text = "UTF-8";
            this.rbtnSendUTF8.UseVisualStyleBackColor = true;
            this.rbtnSendUTF8.Click += new System.EventHandler(this.rbtnSend_Click);
            // 
            // lkbSendKey
            // 
            this.lkbSendKey.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lkbSendKey.Font = new System.Drawing.Font("宋体", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lkbSendKey.Location = new System.Drawing.Point(4, 175);
            this.lkbSendKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkbSendKey.Name = "lkbSendKey";
            this.lkbSendKey.Size = new System.Drawing.Size(145, 11);
            this.lkbSendKey.TabIndex = 10;
            this.lkbSendKey.TabStop = true;
            this.lkbSendKey.Text = "Enter发送,Ctrl+Enter换行";
            this.lkbSendKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lkbSendKey.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbSendKey_LinkClicked);
            // 
            // lkbClearSend
            // 
            this.lkbClearSend.AutoSize = true;
            this.lkbClearSend.Location = new System.Drawing.Point(76, 156);
            this.lkbClearSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkbClearSend.Name = "lkbClearSend";
            this.lkbClearSend.Size = new System.Drawing.Size(53, 12);
            this.lkbClearSend.TabIndex = 10;
            this.lkbClearSend.TabStop = true;
            this.lkbClearSend.Text = "清除发送";
            this.lkbClearSend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkbClearSend_LinkClicked);
            // 
            // ComDevice
            // 
            this.ComDevice.ReadTimeout = 1000;
            this.ComDevice.WriteTimeout = 1000;
            this.ComDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Com_DataReceived);
            // 
            // timerAutoSend
            // 
            this.timerAutoSend.Interval = 1;
            this.timerAutoSend.Tick += new System.EventHandler(this.timerAutoSend_Tick);
            // 
            // menuSendKey
            // 
            this.menuSendKey.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuSendKey.Name = "menuSendKey";
            this.menuSendKey.Size = new System.Drawing.Size(222, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem1.Text = "Enter发送,Ctrl+Enter换行";
            this.toolStripMenuItem1.CheckStateChanged += new System.EventHandler(this.toolStripMenuItem_CheckStateChanged);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem2.Text = "Enter发送,Shift+Enter换行";
            this.toolStripMenuItem2.CheckStateChanged += new System.EventHandler(this.toolStripMenuItem_CheckStateChanged);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem3.Text = "Ctrl+Enter发送,Enter换行";
            this.toolStripMenuItem3.CheckStateChanged += new System.EventHandler(this.toolStripMenuItem_CheckStateChanged);
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 22);
            this.toolStripMenuItem4.Text = "Shift+Enter发送,Enter换行";
            this.toolStripMenuItem4.CheckStateChanged += new System.EventHandler(this.toolStripMenuItem_CheckStateChanged);
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem_Click);
            // 
            // timerDelay
            // 
            this.timerDelay.Enabled = true;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.Location = new System.Drawing.Point(4, 39);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(108, 21);
            this.txtRemoteIP.TabIndex = 4;
            this.txtRemoteIP.Text = "255.255.255.255";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(118, 39);
            this.txtRemotePort.MaxLength = 5;
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(39, 21);
            this.txtRemotePort.TabIndex = 4;
            this.txtRemotePort.Text = "80";
            this.txtRemotePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutoSendms_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = ":";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "3.本地主机地址";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(117, 78);
            this.txtLocalPort.MaxLength = 5;
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(39, 21);
            this.txtLocalPort.TabIndex = 4;
            this.txtLocalPort.Text = "777";
            this.toolTip1.SetToolTip(this.txtLocalPort, "填0为自动");
            this.txtLocalPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutoSendms_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 82);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = ":";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbLocalIP
            // 
            this.cbbLocalIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbLocalIP.DisplayMember = "1";
            this.cbbLocalIP.Location = new System.Drawing.Point(4, 78);
            this.cbbLocalIP.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLocalIP.Name = "cbbLocalIP";
            this.cbbLocalIP.Size = new System.Drawing.Size(108, 20);
            this.cbbLocalIP.TabIndex = 3;
            this.cbbLocalIP.DropDown += new System.EventHandler(this.cbbLocalIP_DropDown);
            this.cbbLocalIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLocalIP_KeyPress);
            // 
            // btNetOpen
            // 
            this.btNetOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNetOpen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNetOpen.Font = new System.Drawing.Font("宋体", 10F);
            this.btNetOpen.Image = global::ZuartControl.Properties.Resources.close;
            this.btNetOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNetOpen.Location = new System.Drawing.Point(0, 139);
            this.btNetOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btNetOpen.Name = "btNetOpen";
            this.btNetOpen.Padding = new System.Windows.Forms.Padding(11, 0, 33, 0);
            this.btNetOpen.Size = new System.Drawing.Size(162, 41);
            this.btNetOpen.TabIndex = 9;
            this.btNetOpen.Text = " 打开服务";
            this.btNetOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNetOpen.UseVisualStyleBackColor = true;
            this.btNetOpen.Click += new System.EventHandler(this.btNetOpen_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 100);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "4.客户端";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbClient
            // 
            this.cbbClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbClient.DisplayMember = "1";
            this.cbbClient.Location = new System.Drawing.Point(4, 116);
            this.cbbClient.Margin = new System.Windows.Forms.Padding(4);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(152, 20);
            this.cbbClient.TabIndex = 3;
            this.cbbClient.DropDown += new System.EventHandler(this.cbbLocalIP_DropDown);
            this.cbbClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLocalIP_KeyPress);
            // 
            // ZuartControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_Setting);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZuartControl";
            this.Size = new System.Drawing.Size(161, 579);
            this.panel_Setting.ResumeLayout(false);
            this.groupboxRecSetting.ResumeLayout(false);
            this.groupboxRecSetting.PerformLayout();
            this.tabControlComNet.ResumeLayout(false);
            this.tabComSetting.ResumeLayout(false);
            this.tabComSetting.PerformLayout();
            this.tabNetSetting.ResumeLayout(false);
            this.tabNetSetting.PerformLayout();
            this.groupboxSendSetting.ResumeLayout(false);
            this.groupboxSendSetting.PerformLayout();
            this.menuSendKey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Setting;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.ComboBox cbbComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComOpen;
        private System.Windows.Forms.GroupBox groupboxRecSetting;
        private System.Windows.Forms.CheckBox chkAutoLine;
        private System.Windows.Forms.CheckBox chkShowTime;
        private System.IO.Ports.SerialPort ComDevice;
        private System.Windows.Forms.LinkLabel lkbSaveRev;
        private System.Windows.Forms.GroupBox groupboxSendSetting;
        private System.Windows.Forms.LinkLabel lkbClearSend;
        private System.Windows.Forms.LinkLabel lkbClearRev;
        private System.Windows.Forms.CheckBox chkAutoCleanSend;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.CheckBox chkAutoAddSend;
        private System.Windows.Forms.Timer timerAutoSend;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkRecSend;
        private System.Windows.Forms.CheckBox chkAutoScroll;
        private System.Windows.Forms.CheckBox chkRTS;
        private System.Windows.Forms.CheckBox chkDTR;
        private System.Windows.Forms.CheckBox chkTrans;
        private System.Windows.Forms.LinkLabel lkbSendKey;
        private System.Windows.Forms.ContextMenuStrip menuSendKey;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.CheckBox chkfromFileSend;
        public System.Windows.Forms.RadioButton rbtnUnicode;
        public System.Windows.Forms.RadioButton rbtnUTF8;
        public System.Windows.Forms.RadioButton rbtnASCII;
        public System.Windows.Forms.RadioButton rbtnHex;
        public System.Windows.Forms.RadioButton rbtnSendUnicode;
        public System.Windows.Forms.RadioButton rbtnSendHex;
        public System.Windows.Forms.RadioButton rbtnSendASCII;
        public System.Windows.Forms.RadioButton rbtnSendUTF8;
        public System.Windows.Forms.TextBox txtAutoSendms;
        private System.Windows.Forms.CheckBox chkIsShow;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.TabControl tabControlComNet;
        private System.Windows.Forms.TabPage tabComSetting;
        private System.Windows.Forms.TabPage tabNetSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbNetList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbLocalIP;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btNetOpen;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.Label label11;
    }
}
