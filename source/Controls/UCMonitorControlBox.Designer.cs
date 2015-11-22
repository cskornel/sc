namespace SimpleCounter.Controls
{
    partial class UCMonitorControlBox
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
            this.rbtnShow = new System.Windows.Forms.RadioButton();
            this.rbtnHide = new System.Windows.Forms.RadioButton();
            this.btnMonitorDown = new System.Windows.Forms.Button();
            this.btnMonitorUp = new System.Windows.Forms.Button();
            this.nupdMonitor = new System.Windows.Forms.NumericUpDown();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupdMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnShow
            // 
            this.rbtnShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnShow.Location = new System.Drawing.Point(169, 23);
            this.rbtnShow.Name = "rbtnShow";
            this.rbtnShow.Size = new System.Drawing.Size(86, 109);
            this.rbtnShow.TabIndex = 17;
            this.rbtnShow.Text = "MUTAT";
            this.rbtnShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnShow.UseVisualStyleBackColor = true;
            this.rbtnShow.CheckedChanged += new System.EventHandler(this.rbtnShow_CheckedChanged);
            this.rbtnShow.Click += new System.EventHandler(this.rbtnShow_Click);
            // 
            // rbtnHide
            // 
            this.rbtnHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnHide.Checked = true;
            this.rbtnHide.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnHide.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnHide.Location = new System.Drawing.Point(4, 23);
            this.rbtnHide.Name = "rbtnHide";
            this.rbtnHide.Size = new System.Drawing.Size(77, 109);
            this.rbtnHide.TabIndex = 16;
            this.rbtnHide.TabStop = true;
            this.rbtnHide.Text = "ELREJT";
            this.rbtnHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnHide.UseVisualStyleBackColor = true;
            this.rbtnHide.Click += new System.EventHandler(this.rbtnHide_Click);
            // 
            // btnMonitorDown
            // 
            this.btnMonitorDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMonitorDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMonitorDown.Location = new System.Drawing.Point(87, 97);
            this.btnMonitorDown.Name = "btnMonitorDown";
            this.btnMonitorDown.Size = new System.Drawing.Size(75, 35);
            this.btnMonitorDown.TabIndex = 15;
            this.btnMonitorDown.Text = "˅";
            this.btnMonitorDown.UseVisualStyleBackColor = true;
            this.btnMonitorDown.Click += new System.EventHandler(this.btnMonitorDown_Click);
            // 
            // btnMonitorUp
            // 
            this.btnMonitorUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMonitorUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMonitorUp.Location = new System.Drawing.Point(88, 23);
            this.btnMonitorUp.Name = "btnMonitorUp";
            this.btnMonitorUp.Size = new System.Drawing.Size(75, 35);
            this.btnMonitorUp.TabIndex = 14;
            this.btnMonitorUp.Text = "˄";
            this.btnMonitorUp.UseVisualStyleBackColor = true;
            this.btnMonitorUp.Click += new System.EventHandler(this.btnMonitorUp_Click);
            // 
            // nupdMonitor
            // 
            this.nupdMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdMonitor.Location = new System.Drawing.Point(87, 62);
            this.nupdMonitor.Name = "nupdMonitor";
            this.nupdMonitor.Size = new System.Drawing.Size(76, 31);
            this.nupdMonitor.TabIndex = 12;
            this.nupdMonitor.ValueChanged += new System.EventHandler(this.nupdMonitor_ValueChanged);
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
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Monitor beállítása";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, -1);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 18;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // UCMonitorControlBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.rbtnShow);
            this.Controls.Add(this.rbtnHide);
            this.Controls.Add(this.btnMonitorDown);
            this.Controls.Add(this.btnMonitorUp);
            this.Controls.Add(this.nupdMonitor);
            this.Controls.Add(this.labelTitle);
            this.Name = "UCMonitorControlBox";
            this.Size = new System.Drawing.Size(260, 138);
            ((System.ComponentModel.ISupportInitialize)(this.nupdMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnShow;
        private System.Windows.Forms.RadioButton rbtnHide;
        private System.Windows.Forms.Button btnMonitorDown;
        private System.Windows.Forms.Button btnMonitorUp;
        private System.Windows.Forms.NumericUpDown nupdMonitor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMinimizeMaximize;
    }
}
