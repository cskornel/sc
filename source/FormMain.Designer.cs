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
            SimpleCounter.CounterClasses.Counter counter2 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter3 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings1 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter4 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter5 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.Counter counter6 = new SimpleCounter.CounterClasses.Counter();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings2 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.GlobalSettings globalSettings3 = new SimpleCounter.CounterClasses.GlobalSettings();
            SimpleCounter.CounterClasses.Counter counter7 = new SimpleCounter.CounterClasses.Counter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.checkBoxTopWindow = new System.Windows.Forms.CheckBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSetPozition = new System.Windows.Forms.Button();
            this.panelStopStart = new System.Windows.Forms.Panel();
            this.btnStopStart = new System.Windows.Forms.Button();
            this.chbStopZero = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMainControls = new System.Windows.Forms.Panel();
            this.ucEffectBox1 = new SimpleCounter.Controls.UCEffectBox();
            this.ucTimeDirection1 = new SimpleCounter.Controls.UCTimeDirection();
            this.ucTimeSettings1 = new SimpleCounter.Controls.UCTimeSettings();
            this.ucCounter1 = new SimpleCounter.Controls.UCCounter();
            this.ucCounterTypeChanger1 = new SimpleCounter.Controls.UCCounterTypeChanger();
            this.ucFontSizeBox1 = new SimpleCounter.Controls.UCFontSizeBox();
            this.ucMonitorControlBox1 = new SimpleCounter.Controls.UCMonitorControlBox();
            this.ucMonitorPreviewBox1 = new SimpleCounter.Controls.UCMonitorPreviewBox();
            this.panelTop.SuspendLayout();
            this.panelStopStart.SuspendLayout();
            this.panelMainControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTopWindow
            // 
            this.checkBoxTopWindow.AutoSize = true;
            this.checkBoxTopWindow.Checked = true;
            this.checkBoxTopWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTopWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxTopWindow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxTopWindow.Location = new System.Drawing.Point(2, 3);
            this.checkBoxTopWindow.Name = "checkBoxTopWindow";
            this.checkBoxTopWindow.Size = new System.Drawing.Size(173, 19);
            this.checkBoxTopWindow.TabIndex = 1;
            this.checkBoxTopWindow.Text = "Az ablak mindig látszik";
            this.checkBoxTopWindow.UseVisualStyleBackColor = true;
            this.checkBoxTopWindow.Click += new System.EventHandler(this.checkBoxTopWindow_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DimGray;
            this.panelTop.Controls.Add(this.btnSetPozition);
            this.panelTop.Controls.Add(this.checkBoxTopWindow);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(287, 26);
            this.panelTop.TabIndex = 12;
            // 
            // btnSetPozition
            // 
            this.btnSetPozition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetPozition.Location = new System.Drawing.Point(183, 0);
            this.btnSetPozition.Name = "btnSetPozition";
            this.btnSetPozition.Size = new System.Drawing.Size(83, 32);
            this.btnSetPozition.TabIndex = 5;
            this.btnSetPozition.Text = "Pozícionálás";
            this.btnSetPozition.UseVisualStyleBackColor = true;
            this.btnSetPozition.Visible = false;
            this.btnSetPozition.Click += new System.EventHandler(this.btnSave_Click);
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
            // panelMainControls
            // 
            this.panelMainControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainControls.AutoScroll = true;
            this.panelMainControls.AutoScrollMinSize = new System.Drawing.Size(269, 850);
            this.panelMainControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMainControls.BackColor = System.Drawing.Color.Black;
            this.panelMainControls.Controls.Add(this.ucEffectBox1);
            this.panelMainControls.Controls.Add(this.ucTimeDirection1);
            this.panelMainControls.Controls.Add(this.ucTimeSettings1);
            this.panelMainControls.Controls.Add(this.ucCounter1);
            this.panelMainControls.Controls.Add(this.ucCounterTypeChanger1);
            this.panelMainControls.Controls.Add(this.ucFontSizeBox1);
            this.panelMainControls.Controls.Add(this.ucMonitorControlBox1);
            this.panelMainControls.Controls.Add(this.ucMonitorPreviewBox1);
            this.panelMainControls.Location = new System.Drawing.Point(0, 28);
            this.panelMainControls.MaximumSize = new System.Drawing.Size(400, 5000);
            this.panelMainControls.MinimumSize = new System.Drawing.Size(50, 50);
            this.panelMainControls.Name = "panelMainControls";
            this.panelMainControls.Size = new System.Drawing.Size(287, 588);
            this.panelMainControls.TabIndex = 23;
            this.panelMainControls.Resize += new System.EventHandler(this.panelMainControls_Resize);
            // 
            // ucEffectBox1
            // 
            this.ucEffectBox1.BackColor = System.Drawing.Color.Black;
            this.ucEffectBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter1.BackColor = System.Drawing.Color.Black;
            counter1.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter1.CurrentMonitor = 0;
            counter1.Direction = true;
            counter1.Enabled = false;
            counter1.FigyelmeztetIdo = 60;
            counter1.FigylmeztetVisszaszamlalasnal = false;
            counter1.FontColor = System.Drawing.Color.WhiteSmoke;
            counter1.FontSize = 219;
            counter1.HideText = false;
            counter1.Id = 1;
            counter1.OnScreen = false;
            counter1.SzovegesOra = true;
            counter1.UserTime = 0;
            counter1.VillogasEffect = false;
            counter1.VillogasEffectSebesseg = 500;
            this.ucEffectBox1.Counter = counter1;
            this.ucEffectBox1.Location = new System.Drawing.Point(7, 1664);
            this.ucEffectBox1.Maximized = false;
            this.ucEffectBox1.Minimized = false;
            this.ucEffectBox1.Name = "ucEffectBox1";
            this.ucEffectBox1.Size = new System.Drawing.Size(260, 160);
            this.ucEffectBox1.TabIndex = 32;
            this.ucEffectBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucTimeDirection1
            // 
            this.ucTimeDirection1.BackColor = System.Drawing.Color.Black;
            this.ucTimeDirection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter2.BackColor = System.Drawing.Color.Black;
            counter2.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter2.CurrentMonitor = 0;
            counter2.Direction = true;
            counter2.Enabled = false;
            counter2.FigyelmeztetIdo = 60;
            counter2.FigylmeztetVisszaszamlalasnal = false;
            counter2.FontColor = System.Drawing.Color.WhiteSmoke;
            counter2.FontSize = 219;
            counter2.HideText = false;
            counter2.Id = 1;
            counter2.OnScreen = false;
            counter2.SzovegesOra = true;
            counter2.UserTime = 0;
            counter2.VillogasEffect = false;
            counter2.VillogasEffectSebesseg = 500;
            this.ucTimeDirection1.Counter = counter2;
            this.ucTimeDirection1.Location = new System.Drawing.Point(7, 1466);
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
            counter3.BackColor = System.Drawing.Color.Black;
            counter3.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter3.CurrentMonitor = 0;
            counter3.Direction = true;
            counter3.Enabled = false;
            counter3.FigyelmeztetIdo = 60;
            counter3.FigylmeztetVisszaszamlalasnal = false;
            counter3.FontColor = System.Drawing.Color.WhiteSmoke;
            counter3.FontSize = 219;
            counter3.HideText = false;
            counter3.Id = 1;
            counter3.OnScreen = false;
            counter3.SzovegesOra = true;
            counter3.UserTime = 0;
            counter3.VillogasEffect = false;
            counter3.VillogasEffectSebesseg = 500;
            this.ucTimeSettings1.Counter = counter3;
            globalSettings1.LeptekBetumeretValtoztatashoz = 4;
            globalSettings1.RagadosAblak = true;
            this.ucTimeSettings1.GlobalSettings = globalSettings1;
            this.ucTimeSettings1.Location = new System.Drawing.Point(7, 1521);
            this.ucTimeSettings1.Maximized = false;
            this.ucTimeSettings1.Minimized = false;
            this.ucTimeSettings1.Name = "ucTimeSettings1";
            this.ucTimeSettings1.Size = new System.Drawing.Size(260, 137);
            this.ucTimeSettings1.TabIndex = 30;
            this.ucTimeSettings1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucCounter1
            // 
            this.ucCounter1.BackColor = System.Drawing.Color.Black;
            this.ucCounter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter4.BackColor = System.Drawing.Color.Black;
            counter4.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter4.CurrentMonitor = 0;
            counter4.Direction = true;
            counter4.Enabled = false;
            counter4.FigyelmeztetIdo = 60;
            counter4.FigylmeztetVisszaszamlalasnal = false;
            counter4.FontColor = System.Drawing.Color.WhiteSmoke;
            counter4.FontSize = 219;
            counter4.HideText = false;
            counter4.Id = 1;
            counter4.OnScreen = false;
            counter4.SzovegesOra = true;
            counter4.UserTime = 0;
            counter4.VillogasEffect = false;
            counter4.VillogasEffectSebesseg = 500;
            this.ucCounter1.Counter = counter4;
            this.ucCounter1.Location = new System.Drawing.Point(7, 1342);
            this.ucCounter1.Maximized = false;
            this.ucCounter1.Minimized = false;
            this.ucCounter1.Name = "ucCounter1";
            this.ucCounter1.Size = new System.Drawing.Size(260, 118);
            this.ucCounter1.TabIndex = 29;
            this.ucCounter1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucCounterTypeChanger1
            // 
            this.ucCounterTypeChanger1.BackColor = System.Drawing.Color.Black;
            this.ucCounterTypeChanger1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter5.BackColor = System.Drawing.Color.Black;
            counter5.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter5.CurrentMonitor = 0;
            counter5.Direction = true;
            counter5.Enabled = false;
            counter5.FigyelmeztetIdo = 60;
            counter5.FigylmeztetVisszaszamlalasnal = false;
            counter5.FontColor = System.Drawing.Color.WhiteSmoke;
            counter5.FontSize = 219;
            counter5.HideText = false;
            counter5.Id = 1;
            counter5.OnScreen = false;
            counter5.SzovegesOra = true;
            counter5.UserTime = 0;
            counter5.VillogasEffect = false;
            counter5.VillogasEffectSebesseg = 500;
            this.ucCounterTypeChanger1.Counter = counter5;
            this.ucCounterTypeChanger1.Location = new System.Drawing.Point(6, 1264);
            this.ucCounterTypeChanger1.Minimized = false;
            this.ucCounterTypeChanger1.Name = "ucCounterTypeChanger1";
            this.ucCounterTypeChanger1.Size = new System.Drawing.Size(260, 72);
            this.ucCounterTypeChanger1.TabIndex = 31;
            this.ucCounterTypeChanger1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
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
            counter6.FontSize = 219;
            counter6.HideText = false;
            counter6.Id = 1;
            counter6.OnScreen = false;
            counter6.SzovegesOra = true;
            counter6.UserTime = 0;
            counter6.VillogasEffect = false;
            counter6.VillogasEffectSebesseg = 500;
            this.ucFontSizeBox1.Counter = counter6;
            this.ucFontSizeBox1.FormTimer = null;
            globalSettings2.LeptekBetumeretValtoztatashoz = 4;
            globalSettings2.RagadosAblak = true;
            this.ucFontSizeBox1.GlobalSettings = globalSettings2;
            this.ucFontSizeBox1.Location = new System.Drawing.Point(6, 1181);
            this.ucFontSizeBox1.Name = "ucFontSizeBox1";
            this.ucFontSizeBox1.Size = new System.Drawing.Size(260, 77);
            this.ucFontSizeBox1.TabIndex = 26;
            this.ucFontSizeBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucMonitorControlBox1
            // 
            this.ucMonitorControlBox1.BackColor = System.Drawing.Color.Black;
            this.ucMonitorControlBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucMonitorControlBox1.FormTimer = null;
            globalSettings3.LeptekBetumeretValtoztatashoz = 4;
            globalSettings3.RagadosAblak = true;
            this.ucMonitorControlBox1.GlobalSettings = globalSettings3;
            this.ucMonitorControlBox1.Location = new System.Drawing.Point(2, 1037);
            this.ucMonitorControlBox1.Name = "ucMonitorControlBox1";
            this.ucMonitorControlBox1.Size = new System.Drawing.Size(260, 138);
            this.ucMonitorControlBox1.TabIndex = 24;
            this.ucMonitorControlBox1.TimerForm = null;
            this.ucMonitorControlBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // ucMonitorPreviewBox1
            // 
            this.ucMonitorPreviewBox1.BackColor = System.Drawing.Color.Black;
            this.ucMonitorPreviewBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            counter7.BackColor = System.Drawing.Color.Black;
            counter7.CounterType = SimpleCounter.CounterClasses.CounterTypeEnum.Counter;
            counter7.CurrentMonitor = 0;
            counter7.Direction = true;
            counter7.Enabled = false;
            counter7.FigyelmeztetIdo = 60;
            counter7.FigylmeztetVisszaszamlalasnal = false;
            counter7.FontColor = System.Drawing.Color.WhiteSmoke;
            counter7.FontSize = 219;
            counter7.HideText = false;
            counter7.Id = 1;
            counter7.OnScreen = false;
            counter7.SzovegesOra = true;
            counter7.UserTime = 0;
            counter7.VillogasEffect = false;
            counter7.VillogasEffectSebesseg = 500;
            this.ucMonitorPreviewBox1.Counter = counter7;
            this.ucMonitorPreviewBox1.Location = new System.Drawing.Point(2, 854);
            this.ucMonitorPreviewBox1.Name = "ucMonitorPreviewBox1";
            this.ucMonitorPreviewBox1.Size = new System.Drawing.Size(260, 177);
            this.ucMonitorPreviewBox1.TabIndex = 27;
            this.ucMonitorPreviewBox1.ClientSizeChanged += new System.EventHandler(this.uc_ClientSizeChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(287, 698);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMainControls);
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
            this.panelTop.PerformLayout();
            this.panelStopStart.ResumeLayout(false);
            this.panelMainControls.ResumeLayout(false);
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
        private Controls.UCMonitorPreviewBox ucMonitorPreviewBox1;
        private Controls.UCTimeDirection ucTimeDirection1;
        private Controls.UCCounter ucCounter1;
        private Controls.UCTimeSettings ucTimeSettings1;
        private Controls.UCCounterTypeChanger ucCounterTypeChanger1;
        private Controls.UCEffectBox ucEffectBox1;
    }
}

