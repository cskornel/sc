namespace SimpleCounter
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            SimpleCounter.CounterClasses.Counter counter1 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings1 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter2 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter3 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings2 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter4 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter5 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings3 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter6 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings4 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter7 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter8 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings5 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings6 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter9 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings7 = new SimpleCounter.CounterClasses.GlobalSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.radioButtonMainSettings = new System.Windows.Forms.RadioButton();
            this.radioButtonSecondPage = new System.Windows.Forms.RadioButton();
            this.radioButtonMainPage = new System.Windows.Forms.RadioButton();
            this.panelStopStart = new System.Windows.Forms.Panel();
            this.btnStopStart = new System.Windows.Forms.Button();
            this.chbStopZero = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTipSettings = new System.Windows.Forms.ToolTip(this.components);
            this.customTabControlMain = new SimpleCounter.Controls.CustomTabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.panelMainControls = new System.Windows.Forms.Panel();
            this.ucMonitorPreviewBox1 = new SimpleCounter.Controls.UCMonitorPreviewBox();
            this.ucCounter1 = new SimpleCounter.Controls.UCCounter();
            this.ucEffectBox1 = new SimpleCounter.Controls.UCEffectBox();
            this.ucMonitorControlBox1 = new SimpleCounter.Controls.UCMonitorControlBox();
            this.ucTimeDirection1 = new SimpleCounter.Controls.UCTimeDirection();
            this.ucTimeSettings1 = new SimpleCounter.Controls.UCTimeSettings();
            this.ucFontSizeBox1 = new SimpleCounter.Controls.UCFontSizeBox();
            this.ucCounterTypeChanger1 = new SimpleCounter.Controls.UCCounterTypeChanger();
            this.tabPageSecond = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ucFontSizeBox2 = new SimpleCounter.Controls.UCFontSizeBox();
            this.ucMonitorControlBox2 = new SimpleCounter.Controls.UCMonitorControlBox();
            this.ucMonitorPreviewBox2 = new SimpleCounter.Controls.UCMonitorPreviewBox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxTopWindow = new System.Windows.Forms.CheckBox();
            this.btnSetPozition = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelStopStart.SuspendLayout();
            this.customTabControlMain.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.panelMainControls.SuspendLayout();
            this.tabPageSecond.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.radioButtonMainSettings);
            this.panelTop.Controls.Add(this.radioButtonSecondPage);
            this.panelTop.Controls.Add(this.radioButtonMainPage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(287, 30);
            this.panelTop.TabIndex = 12;
            // 
            // radioButtonMainSettings
            // 
            this.radioButtonMainSettings.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMainSettings.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonMainSettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.radioButtonMainSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMainSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonMainSettings.Location = new System.Drawing.Point(247, 4);
            this.radioButtonMainSettings.Name = "radioButtonMainSettings";
            this.radioButtonMainSettings.Size = new System.Drawing.Size(23, 23);
            this.radioButtonMainSettings.TabIndex = 7;
            this.radioButtonMainSettings.Text = "B";
            this.radioButtonMainSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMainSettings.UseVisualStyleBackColor = true;
            this.radioButtonMainSettings.CheckedChanged += new System.EventHandler(this.radioButtonTabControl_CheckedChanged);
            // 
            // radioButtonSecondPage
            // 
            this.radioButtonSecondPage.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSecondPage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonSecondPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.radioButtonSecondPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSecondPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonSecondPage.Location = new System.Drawing.Point(41, 4);
            this.radioButtonSecondPage.Name = "radioButtonSecondPage";
            this.radioButtonSecondPage.Size = new System.Drawing.Size(23, 23);
            this.radioButtonSecondPage.TabIndex = 6;
            this.radioButtonSecondPage.Text = "2";
            this.radioButtonSecondPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSecondPage.UseVisualStyleBackColor = true;
            this.radioButtonSecondPage.CheckedChanged += new System.EventHandler(this.radioButtonTabControl_CheckedChanged);
            // 
            // radioButtonMainPage
            // 
            this.radioButtonMainPage.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMainPage.Checked = true;
            this.radioButtonMainPage.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonMainPage.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.radioButtonMainPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonMainPage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radioButtonMainPage.Location = new System.Drawing.Point(12, 4);
            this.radioButtonMainPage.Name = "radioButtonMainPage";
            this.radioButtonMainPage.Size = new System.Drawing.Size(23, 23);
            this.radioButtonMainPage.TabIndex = 5;
            this.radioButtonMainPage.TabStop = true;
            this.radioButtonMainPage.Text = "1";
            this.radioButtonMainPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonMainPage.UseVisualStyleBackColor = true;
            this.radioButtonMainPage.CheckedChanged += new System.EventHandler(this.radioButtonTabControl_CheckedChanged);
            // 
            // panelStopStart
            // 
            this.panelStopStart.BackColor = System.Drawing.Color.Black;
            this.panelStopStart.Controls.Add(this.btnStopStart);
            this.panelStopStart.Controls.Add(this.chbStopZero);
            this.panelStopStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStopStart.Location = new System.Drawing.Point(0, 616);
            this.panelStopStart.Name = "panelStopStart";
            this.panelStopStart.Size = new System.Drawing.Size(287, 82);
            this.panelStopStart.TabIndex = 1;
            // 
            // btnStopStart
            // 
            this.btnStopStart.BackColor = System.Drawing.Color.SeaGreen;
            this.btnStopStart.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnStopStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopStart.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopStart.Location = new System.Drawing.Point(12, 6);
            this.btnStopStart.Name = "btnStopStart";
            this.btnStopStart.Size = new System.Drawing.Size(170, 68);
            this.btnStopStart.TabIndex = 8;
            this.btnStopStart.Text = "Stop / Start";
            this.btnStopStart.UseVisualStyleBackColor = false;
            this.btnStopStart.Click += new System.EventHandler(this.btnStopStart_Click);
            // 
            // chbStopZero
            // 
            this.chbStopZero.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbStopZero.BackColor = System.Drawing.Color.Black;
            this.chbStopZero.Checked = true;
            this.chbStopZero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbStopZero.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.chbStopZero.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.chbStopZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbStopZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbStopZero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chbStopZero.Location = new System.Drawing.Point(188, 6);
            this.chbStopZero.Name = "chbStopZero";
            this.chbStopZero.Size = new System.Drawing.Size(85, 68);
            this.chbStopZero.TabIndex = 9;
            this.chbStopZero.Text = "Auto stop ha nulla (BE)";
            this.chbStopZero.UseVisualStyleBackColor = false;
            this.chbStopZero.CheckedChanged += new System.EventHandler(this.chbStopZero_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customTabControlMain
            // 
            this.customTabControlMain.Controls.Add(this.tabPageMain);
            this.customTabControlMain.Controls.Add(this.tabPageSecond);
            this.customTabControlMain.Controls.Add(this.tabPageSettings);
            this.customTabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTabControlMain.Location = new System.Drawing.Point(0, 30);
            this.customTabControlMain.Name = "customTabControlMain";
            this.customTabControlMain.SelectedIndex = 0;
            this.customTabControlMain.Size = new System.Drawing.Size(287, 586);
            this.customTabControlMain.TabIndex = 33;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.panelMainControls);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(279, 560);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "1";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // panelMainControls
            // 
            this.panelMainControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainControls.AutoScroll = true;
            this.panelMainControls.AutoScrollMinSize = new System.Drawing.Size(269, 850);
            this.panelMainControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainControls.BackColor = System.Drawing.Color.Black;
            this.panelMainControls.Controls.Add(this.ucMonitorPreviewBox1);
            this.panelMainControls.Controls.Add(this.ucCounter1);
            this.panelMainControls.Controls.Add(this.ucEffectBox1);
            this.panelMainControls.Controls.Add(this.ucMonitorControlBox1);
            this.panelMainControls.Controls.Add(this.ucTimeDirection1);
            this.panelMainControls.Controls.Add(this.ucTimeSettings1);
            this.panelMainControls.Controls.Add(this.ucFontSizeBox1);
            this.panelMainControls.Controls.Add(this.ucCounterTypeChanger1);
            this.panelMainControls.Location = new System.Drawing.Point(0, 0);
            this.panelMainControls.MaximumSize = new System.Drawing.Size(400, 5000);
            this.panelMainControls.MinimumSize = new System.Drawing.Size(50, 50);
            this.panelMainControls.Name = "panelMainControls";
            this.panelMainControls.Size = new System.Drawing.Size(287, 610);
            this.panelMainControls.TabIndex = 23;
            this.panelMainControls.Resize += new System.EventHandler(this.panelMainControls_Resize);
            // 
            // ucMonitorPreviewBox1
            // 
            this.ucMonitorPreviewBox1.BackColor = System.Drawing.Color.Black;
            this.ucMonitorPreviewBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter1.BackColor = System.Drawing.Color.Black;
            counter1.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter1.CurrentMonitor = 0;
            counter1.Direction = true;
            counter1.Enabled = false;
            counter1.FigyelmeztetIdo = 60;
            counter1.FigylmeztetVisszaszamlalasnal = false;
            counter1.FontColor = System.Drawing.Color.WhiteSmoke;
            counter1.HideText = false;
            counter1.Id = 1;
            //counter1.OnScreen = false;
            counter1.SzovegesOra = true;
            counter1.UserTime = 0;
            counter1.VillogasEffect = false;
            counter1.VillogasEffectSebesseg = 500;
            this.ucMonitorPreviewBox1.Counter = counter1;
            globalSettings1.LeptekBetumeretValtoztatashoz = 4;
            globalSettings1.RagadosAblak = true;
            globalSettings1.UCMonitorPreviewBoxAutostrtVideo = false;
            this.ucMonitorPreviewBox1.GlobalSettings = globalSettings1;
            this.ucMonitorPreviewBox1.Location = new System.Drawing.Point(8, 6);
            this.ucMonitorPreviewBox1.Name = "ucMonitorPreviewBox1";
            this.ucMonitorPreviewBox1.Size = new System.Drawing.Size(260, 177);
            this.ucMonitorPreviewBox1.TabIndex = 33;
            this.ucMonitorPreviewBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucCounter1
            // 
            this.ucCounter1.BackColor = System.Drawing.Color.Black;
            this.ucCounter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter2.BackColor = System.Drawing.Color.Black;
            counter2.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter2.CurrentMonitor = 0;
            counter2.Direction = true;
            counter2.Enabled = false;
            counter2.FigyelmeztetIdo = 60;
            counter2.FigylmeztetVisszaszamlalasnal = false;
            counter2.FontColor = System.Drawing.Color.WhiteSmoke;
            counter2.HideText = false;
            counter2.Id = 1;
            //counter2.OnScreen = false;
            counter2.SzovegesOra = true;
            counter2.UserTime = 0;
            counter2.VillogasEffect = false;
            counter2.VillogasEffectSebesseg = 500;
            this.ucCounter1.Counter = counter2;
            this.ucCounter1.Location = new System.Drawing.Point(6, 492);
            this.ucCounter1.Maximized = false;
            this.ucCounter1.Minimized = false;
            this.ucCounter1.Name = "ucCounter1";
            this.ucCounter1.Size = new System.Drawing.Size(260, 118);
            this.ucCounter1.TabIndex = 29;
            this.ucCounter1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucEffectBox1
            // 
            this.ucEffectBox1.BackColor = System.Drawing.Color.Black;
            this.ucEffectBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter3.BackColor = System.Drawing.Color.Black;
            counter3.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter3.CurrentMonitor = 0;
            counter3.Direction = true;
            counter3.Enabled = false;
            counter3.FigyelmeztetIdo = 60;
            counter3.FigylmeztetVisszaszamlalasnal = false;
            counter3.FontColor = System.Drawing.Color.WhiteSmoke;
            counter3.HideText = false;
            counter3.Id = 1;
            //counter3.OnScreen = false;
            counter3.SzovegesOra = true;
            counter3.UserTime = 0;
            counter3.VillogasEffect = false;
            counter3.VillogasEffectSebesseg = 500;
            this.ucEffectBox1.Counter = counter3;
            this.ucEffectBox1.Location = new System.Drawing.Point(6, 814);
            this.ucEffectBox1.Maximized = false;
            this.ucEffectBox1.Minimized = false;
            this.ucEffectBox1.Name = "ucEffectBox1";
            this.ucEffectBox1.Size = new System.Drawing.Size(260, 160);
            this.ucEffectBox1.TabIndex = 32;
            this.ucEffectBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucMonitorControlBox1
            // 
            this.ucMonitorControlBox1.BackColor = System.Drawing.Color.Black;
            this.ucMonitorControlBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMonitorControlBox1.FormTimer = null;
            globalSettings2.LeptekBetumeretValtoztatashoz = 4;
            globalSettings2.RagadosAblak = true;
            globalSettings2.UCMonitorPreviewBoxAutostrtVideo = true;
            this.ucMonitorControlBox1.GlobalSettings = globalSettings2;
            this.ucMonitorControlBox1.Location = new System.Drawing.Point(7, 187);
            this.ucMonitorControlBox1.Name = "ucMonitorControlBox1";
            this.ucMonitorControlBox1.Size = new System.Drawing.Size(260, 138);
            this.ucMonitorControlBox1.TabIndex = 24;
            this.ucMonitorControlBox1.TimerForm = null;
            this.ucMonitorControlBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucTimeDirection1
            // 
            this.ucTimeDirection1.BackColor = System.Drawing.Color.Black;
            this.ucTimeDirection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter4.BackColor = System.Drawing.Color.Black;
            counter4.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter4.CurrentMonitor = 0;
            counter4.Direction = true;
            counter4.Enabled = false;
            counter4.FigyelmeztetIdo = 60;
            counter4.FigylmeztetVisszaszamlalasnal = false;
            counter4.FontColor = System.Drawing.Color.WhiteSmoke;
            counter4.HideText = false;
            counter4.Id = 1;
            //counter4.OnScreen = false;
            counter4.SzovegesOra = true;
            counter4.UserTime = 0;
            counter4.VillogasEffect = false;
            counter4.VillogasEffectSebesseg = 500;
            this.ucTimeDirection1.Counter = counter4;
            this.ucTimeDirection1.Location = new System.Drawing.Point(6, 616);
            this.ucTimeDirection1.Maximized = false;
            this.ucTimeDirection1.Minimized = false;
            this.ucTimeDirection1.Name = "ucTimeDirection1";
            this.ucTimeDirection1.Size = new System.Drawing.Size(260, 49);
            this.ucTimeDirection1.TabIndex = 28;
            this.ucTimeDirection1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucTimeSettings1
            // 
            this.ucTimeSettings1.BackColor = System.Drawing.Color.IndianRed;
            this.ucTimeSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter5.BackColor = System.Drawing.Color.Black;
            counter5.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter5.CurrentMonitor = 0;
            counter5.Direction = true;
            counter5.Enabled = false;
            counter5.FigyelmeztetIdo = 60;
            counter5.FigylmeztetVisszaszamlalasnal = false;
            counter5.FontColor = System.Drawing.Color.WhiteSmoke;
            counter5.HideText = false;
            counter5.Id = 1;
            //counter5.OnScreen = false;
            counter5.SzovegesOra = true;
            counter5.UserTime = 0;
            counter5.VillogasEffect = false;
            counter5.VillogasEffectSebesseg = 500;
            this.ucTimeSettings1.Counter = counter5;
            globalSettings3.LeptekBetumeretValtoztatashoz = 4;
            globalSettings3.RagadosAblak = true;
            globalSettings3.UCMonitorPreviewBoxAutostrtVideo = true;
            this.ucTimeSettings1.GlobalSettings = globalSettings3;
            this.ucTimeSettings1.Location = new System.Drawing.Point(6, 671);
            this.ucTimeSettings1.Maximized = false;
            this.ucTimeSettings1.Minimized = false;
            this.ucTimeSettings1.Name = "ucTimeSettings1";
            this.ucTimeSettings1.Size = new System.Drawing.Size(260, 137);
            this.ucTimeSettings1.TabIndex = 30;
            this.ucTimeSettings1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucFontSizeBox1
            // 
            this.ucFontSizeBox1.BackColor = System.Drawing.Color.Black;
            this.ucFontSizeBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter6.BackColor = System.Drawing.Color.Black;
            counter6.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter6.CurrentMonitor = 0;
            counter6.Direction = true;
            counter6.Enabled = false;
            counter6.FigyelmeztetIdo = 60;
            counter6.FigylmeztetVisszaszamlalasnal = false;
            counter6.FontColor = System.Drawing.Color.WhiteSmoke;
            counter6.HideText = false;
            counter6.Id = 1;
            //counter6.OnScreen = false;
            counter6.SzovegesOra = true;
            counter6.UserTime = 0;
            counter6.VillogasEffect = false;
            counter6.VillogasEffectSebesseg = 500;
            this.ucFontSizeBox1.Counter = counter6;
            this.ucFontSizeBox1.FormTimer = null;
            globalSettings4.LeptekBetumeretValtoztatashoz = 4;
            globalSettings4.RagadosAblak = true;
            globalSettings4.UCMonitorPreviewBoxAutostrtVideo = true;
            this.ucFontSizeBox1.GlobalSettings = globalSettings4;
            this.ucFontSizeBox1.Location = new System.Drawing.Point(6, 331);
            this.ucFontSizeBox1.Name = "ucFontSizeBox1";
            this.ucFontSizeBox1.Size = new System.Drawing.Size(260, 77);
            this.ucFontSizeBox1.TabIndex = 26;
            this.ucFontSizeBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucCounterTypeChanger1
            // 
            this.ucCounterTypeChanger1.BackColor = System.Drawing.Color.Black;
            this.ucCounterTypeChanger1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter7.BackColor = System.Drawing.Color.Black;
            counter7.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter7.CurrentMonitor = 0;
            counter7.Direction = true;
            counter7.Enabled = false;
            counter7.FigyelmeztetIdo = 60;
            counter7.FigylmeztetVisszaszamlalasnal = false;
            counter7.FontColor = System.Drawing.Color.WhiteSmoke;
            counter7.HideText = false;
            counter7.Id = 1;
            //counter7.OnScreen = false;
            counter7.SzovegesOra = true;
            counter7.UserTime = 0;
            counter7.VillogasEffect = false;
            counter7.VillogasEffectSebesseg = 500;
            this.ucCounterTypeChanger1.Counter = counter7;
            this.ucCounterTypeChanger1.Location = new System.Drawing.Point(7, 414);
            this.ucCounterTypeChanger1.Minimized = false;
            this.ucCounterTypeChanger1.Name = "ucCounterTypeChanger1";
            this.ucCounterTypeChanger1.Size = new System.Drawing.Size(260, 72);
            this.ucCounterTypeChanger1.TabIndex = 31;
            this.ucCounterTypeChanger1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // tabPageSecond
            // 
            this.tabPageSecond.BackColor = System.Drawing.Color.Black;
            this.tabPageSecond.Controls.Add(this.label1);
            this.tabPageSecond.Controls.Add(this.ucFontSizeBox2);
            this.tabPageSecond.Controls.Add(this.ucMonitorControlBox2);
            this.tabPageSecond.Controls.Add(this.ucMonitorPreviewBox2);
            this.tabPageSecond.Location = new System.Drawing.Point(4, 22);
            this.tabPageSecond.Name = "tabPageSecond";
            this.tabPageSecond.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSecond.Size = new System.Drawing.Size(279, 560);
            this.tabPageSecond.TabIndex = 1;
            this.tabPageSecond.Text = "2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "2-es kimenet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucFontSizeBox2
            // 
            this.ucFontSizeBox2.BackColor = System.Drawing.Color.Black;
            this.ucFontSizeBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter8.BackColor = System.Drawing.Color.Black;
            counter8.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter8.CurrentMonitor = 0;
            counter8.Direction = true;
            counter8.Enabled = false;
            counter8.FigyelmeztetIdo = 60;
            counter8.FigylmeztetVisszaszamlalasnal = false;
            counter8.FontColor = System.Drawing.Color.WhiteSmoke;
            counter8.HideText = false;
            counter8.Id = 1;
            //counter8.OnScreen = false;
            counter8.SzovegesOra = true;
            counter8.UserTime = 0;
            counter8.VillogasEffect = false;
            counter8.VillogasEffectSebesseg = 500;
            this.ucFontSizeBox2.Counter = counter8;
            globalSettings5.LeptekBetumeretValtoztatashoz = 4;
            globalSettings5.RagadosAblak = true;
            globalSettings5.UCMonitorPreviewBoxAutostrtVideo = false;
            this.ucFontSizeBox2.GlobalSettings = globalSettings5;
            this.ucFontSizeBox2.Location = new System.Drawing.Point(10, 362);
            this.ucFontSizeBox2.Name = "ucFontSizeBox2";
            this.ucFontSizeBox2.Size = new System.Drawing.Size(260, 77);
            this.ucFontSizeBox2.TabIndex = 2;
            // 
            // ucMonitorControlBox2
            // 
            this.ucMonitorControlBox2.BackColor = System.Drawing.Color.Black;
            this.ucMonitorControlBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            globalSettings6.LeptekBetumeretValtoztatashoz = 4;
            globalSettings6.RagadosAblak = true;
            globalSettings6.UCMonitorPreviewBoxAutostrtVideo = false;
            this.ucMonitorControlBox2.GlobalSettings = globalSettings6;
            this.ucMonitorControlBox2.Location = new System.Drawing.Point(10, 218);
            this.ucMonitorControlBox2.Name = "ucMonitorControlBox2";
            this.ucMonitorControlBox2.Size = new System.Drawing.Size(260, 138);
            this.ucMonitorControlBox2.TabIndex = 1;
            // 
            // ucMonitorPreviewBox2
            // 
            this.ucMonitorPreviewBox2.BackColor = System.Drawing.Color.Black;
            this.ucMonitorPreviewBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter9.BackColor = System.Drawing.Color.Black;
            counter9.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter9.CurrentMonitor = 0;
            counter9.Direction = true;
            counter9.Enabled = false;
            counter9.FigyelmeztetIdo = 60;
            counter9.FigylmeztetVisszaszamlalasnal = false;
            counter9.FontColor = System.Drawing.Color.WhiteSmoke;
            counter9.HideText = false;
            counter9.Id = 1;
            //counter9.OnScreen = false;
            counter9.SzovegesOra = true;
            counter9.UserTime = 0;
            counter9.VillogasEffect = false;
            counter9.VillogasEffectSebesseg = 500;
            this.ucMonitorPreviewBox2.Counter = counter9;
            globalSettings7.LeptekBetumeretValtoztatashoz = 4;
            globalSettings7.RagadosAblak = true;
            globalSettings7.UCMonitorPreviewBoxAutostrtVideo = false;
            this.ucMonitorPreviewBox2.GlobalSettings = globalSettings7;
            this.ucMonitorPreviewBox2.Location = new System.Drawing.Point(11, 35);
            this.ucMonitorPreviewBox2.Name = "ucMonitorPreviewBox2";
            this.ucMonitorPreviewBox2.Size = new System.Drawing.Size(260, 177);
            this.ucMonitorPreviewBox2.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.Black;
            this.tabPageSettings.Controls.Add(this.checkBoxTopWindow);
            this.tabPageSettings.Controls.Add(this.btnSetPozition);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(279, 560);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "?";
            // 
            // checkBoxTopWindow
            // 
            this.checkBoxTopWindow.AutoSize = true;
            this.checkBoxTopWindow.Checked = true;
            this.checkBoxTopWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTopWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTopWindow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxTopWindow.Location = new System.Drawing.Point(11, 6);
            this.checkBoxTopWindow.Name = "checkBoxTopWindow";
            this.checkBoxTopWindow.Size = new System.Drawing.Size(173, 19);
            this.checkBoxTopWindow.TabIndex = 1;
            this.checkBoxTopWindow.Text = "Az ablak mindig látszik";
            this.checkBoxTopWindow.UseVisualStyleBackColor = true;
            this.checkBoxTopWindow.Click += new System.EventHandler(this.checkBoxTopWindow_Click);
            // 
            // btnSetPozition
            // 
            this.btnSetPozition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPozition.Location = new System.Drawing.Point(6, 31);
            this.btnSetPozition.Name = "btnSetPozition";
            this.btnSetPozition.Size = new System.Drawing.Size(83, 32);
            this.btnSetPozition.TabIndex = 5;
            this.btnSetPozition.Text = "Pozícionálás";
            this.btnSetPozition.UseVisualStyleBackColor = true;
            this.btnSetPozition.Visible = false;
            this.btnSetPozition.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(287, 698);
            this.Controls.Add(this.customTabControlMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelStopStart);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(303, 5000);
            this.MinimumSize = new System.Drawing.Size(303, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelStopStart.ResumeLayout(false);
            this.customTabControlMain.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.panelMainControls.ResumeLayout(false);
            this.tabPageSecond.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTopWindow;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetPozition;
        private System.Windows.Forms.Panel panelStopStart;
        private System.Windows.Forms.CheckBox chbStopZero;
        private System.Windows.Forms.Button btnStopStart;
        private System.Windows.Forms.Panel panelMainControls;
        private Controls.UCMonitorControlBox ucMonitorControlBox;
        private Controls.UCMonitorControlBox ucMonitorControlBox1;
        private Controls.UCFontSizeBox ucFontSizeBox1;
        private Controls.UCTimeDirection ucTimeDirection1;
        private Controls.UCCounter ucCounter1;
        private Controls.UCTimeSettings ucTimeSettings1;
        private Controls.UCCounterTypeChanger ucCounterTypeChanger1;
        private Controls.UCEffectBox ucEffectBox1;
        private Controls.CustomTabControl customTabControlMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageSecond;
        private System.Windows.Forms.TabPage tabPageSettings;
        private Controls.UCFontSizeBox ucFontSizeBox2;
        private Controls.UCMonitorControlBox ucMonitorControlBox2;
        private Controls.UCMonitorPreviewBox ucMonitorPreviewBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipSettings;
        private Controls.UCMonitorPreviewBox ucMonitorPreviewBox1;
        private System.Windows.Forms.RadioButton radioButtonSecondPage;
        private System.Windows.Forms.RadioButton radioButtonMainPage;
        private System.Windows.Forms.RadioButton radioButtonMainSettings;
    }
}

