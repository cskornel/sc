namespace SimpleCounter.Controls
{
    partial class UCCounterTypeChanger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbtnDigitalClock = new System.Windows.Forms.RadioButton();
            this.rbtnCounter = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            this.rbtnAnalogClock = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnDigitalClock
            // 
            this.rbtnDigitalClock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnDigitalClock.BackColor = System.Drawing.Color.Black;
            this.rbtnDigitalClock.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnDigitalClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnDigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnDigitalClock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnDigitalClock.Location = new System.Drawing.Point(87, 22);
            this.rbtnDigitalClock.Name = "rbtnDigitalClock";
            this.rbtnDigitalClock.Size = new System.Drawing.Size(84, 46);
            this.rbtnDigitalClock.TabIndex = 22;
            this.rbtnDigitalClock.Text = "Óra (digitális)";
            this.rbtnDigitalClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnDigitalClock.UseVisualStyleBackColor = false;
            this.rbtnDigitalClock.CheckedChanged += new System.EventHandler(this.CounterType_CheckedChanged);
            // 
            // rbtnCounter
            // 
            this.rbtnCounter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnCounter.Checked = true;
            this.rbtnCounter.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnCounter.Location = new System.Drawing.Point(1, 22);
            this.rbtnCounter.Name = "rbtnCounter";
            this.rbtnCounter.Size = new System.Drawing.Size(84, 46);
            this.rbtnCounter.TabIndex = 21;
            this.rbtnCounter.TabStop = true;
            this.rbtnCounter.Text = "Számláló";
            this.rbtnCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCounter.UseVisualStyleBackColor = true;
            this.rbtnCounter.CheckedChanged += new System.EventHandler(this.CounterType_CheckedChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.DimGray;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(260, 20);
            this.labelTitle.TabIndex = 23;
            this.labelTitle.Text = "Kimenet típusa";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, 0);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 24;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // rbtnAnalogClock
            // 
            this.rbtnAnalogClock.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnAnalogClock.BackColor = System.Drawing.Color.Black;
            this.rbtnAnalogClock.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnAnalogClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAnalogClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnAnalogClock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnAnalogClock.Location = new System.Drawing.Point(173, 22);
            this.rbtnAnalogClock.Name = "rbtnAnalogClock";
            this.rbtnAnalogClock.Size = new System.Drawing.Size(84, 46);
            this.rbtnAnalogClock.TabIndex = 25;
            this.rbtnAnalogClock.Text = "Óra (analóg)";
            this.rbtnAnalogClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnAnalogClock.UseVisualStyleBackColor = false;
            this.rbtnAnalogClock.CheckedChanged += new System.EventHandler(this.CounterType_CheckedChanged);
            // 
            // UCCounterTypeChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rbtnAnalogClock);
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.rbtnDigitalClock);
            this.Controls.Add(this.rbtnCounter);
            this.Controls.Add(this.labelTitle);
            this.Name = "UCCounterTypeChanger";
            this.Size = new System.Drawing.Size(260, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnDigitalClock;
        private System.Windows.Forms.RadioButton rbtnCounter;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinimizeMaximize;
        private System.Windows.Forms.RadioButton rbtnAnalogClock;
    }
}
