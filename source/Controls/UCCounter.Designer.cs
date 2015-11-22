namespace SimpleCounter.Controls
{
    partial class UCCounter
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
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.chbHideText = new System.Windows.Forms.CheckBox();
            this.chbSzovegesOra = new System.Windows.Forms.CheckBox();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.BackColor = System.Drawing.Color.SeaGreen;
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTimer.Location = new System.Drawing.Point(0, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(260, 118);
            this.labelTimer.TabIndex = 27;
            this.labelTimer.Text = "labelTimer";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Előnézet";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // chbHideText
            // 
            this.chbHideText.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbHideText.Dock = System.Windows.Forms.DockStyle.Right;
            this.chbHideText.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbHideText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbHideText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbHideText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chbHideText.Location = new System.Drawing.Point(130, 0);
            this.chbHideText.Name = "chbHideText";
            this.chbHideText.Size = new System.Drawing.Size(130, 30);
            this.chbHideText.TabIndex = 29;
            this.chbHideText.Text = "Számok elrejtése";
            this.chbHideText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbHideText.UseVisualStyleBackColor = true;
            this.chbHideText.CheckedChanged += new System.EventHandler(this.chbHideText_CheckedChanged);
            // 
            // chbSzovegesOra
            // 
            this.chbSzovegesOra.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbSzovegesOra.BackColor = System.Drawing.Color.Black;
            this.chbSzovegesOra.Checked = true;
            this.chbSzovegesOra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSzovegesOra.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbSzovegesOra.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbSzovegesOra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbSzovegesOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chbSzovegesOra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chbSzovegesOra.Location = new System.Drawing.Point(0, 0);
            this.chbSzovegesOra.Name = "chbSzovegesOra";
            this.chbSzovegesOra.Size = new System.Drawing.Size(130, 30);
            this.chbSzovegesOra.TabIndex = 28;
            this.chbSzovegesOra.Text = "Szöveges kijelzés";
            this.chbSzovegesOra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chbSzovegesOra.UseVisualStyleBackColor = false;
            this.chbSzovegesOra.CheckedChanged += new System.EventHandler(this.chbSzovegesOra_CheckedChanged);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, 0);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 30;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.chbSzovegesOra);
            this.panelBottom.Controls.Add(this.chbHideText);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 88);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(260, 30);
            this.panelBottom.TabIndex = 31;
            // 
            // UCCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.labelTimer);
            this.Name = "UCCounter";
            this.Size = new System.Drawing.Size(260, 118);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox chbHideText;
        private System.Windows.Forms.CheckBox chbSzovegesOra;
        private System.Windows.Forms.Label labelMinimizeMaximize;
        private System.Windows.Forms.Panel panelBottom;
    }
}
