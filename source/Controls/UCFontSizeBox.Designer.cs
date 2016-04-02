namespace SimpleCounter.Controls
{
    partial class UCFontSizeBox
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnFontSizeUp = new System.Windows.Forms.Button();
            this.btnFontSizeDown = new System.Windows.Forms.Button();
            this.nupdFontSize = new System.Windows.Forms.NumericUpDown();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupdFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DimGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Betűméret:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // btnFontSizeUp
            // 
            this.btnFontSizeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontSizeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFontSizeUp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFontSizeUp.Location = new System.Drawing.Point(168, 25);
            this.btnFontSizeUp.Name = "btnFontSizeUp";
            this.btnFontSizeUp.Size = new System.Drawing.Size(86, 46);
            this.btnFontSizeUp.TabIndex = 19;
            this.btnFontSizeUp.Text = ">>";
            this.btnFontSizeUp.UseVisualStyleBackColor = true;
            this.btnFontSizeUp.Click += new System.EventHandler(this.btnFontSizeUp_Click);
            // 
            // btnFontSizeDown
            // 
            this.btnFontSizeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFontSizeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFontSizeDown.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFontSizeDown.Location = new System.Drawing.Point(7, 25);
            this.btnFontSizeDown.Name = "btnFontSizeDown";
            this.btnFontSizeDown.Size = new System.Drawing.Size(86, 46);
            this.btnFontSizeDown.TabIndex = 18;
            this.btnFontSizeDown.Text = "<<";
            this.btnFontSizeDown.UseVisualStyleBackColor = true;
            this.btnFontSizeDown.Click += new System.EventHandler(this.btnFontSizeDown_Click);
            // 
            // nupdFontSize
            // 
            this.nupdFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdFontSize.Location = new System.Drawing.Point(97, 33);
            this.nupdFontSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdFontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdFontSize.Name = "nupdFontSize";
            this.nupdFontSize.Size = new System.Drawing.Size(67, 29);
            this.nupdFontSize.TabIndex = 17;
            this.nupdFontSize.Value = new decimal(new int[] {
            219,
            0,
            0,
            0});
            this.nupdFontSize.ValueChanged += new System.EventHandler(this.nupdFontSize_ValueChanged);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, -1);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 20;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // UCFontSizeBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.btnFontSizeUp);
            this.Controls.Add(this.btnFontSizeDown);
            this.Controls.Add(this.nupdFontSize);
            this.Controls.Add(this.label4);
            this.Name = "UCFontSizeBox";
            this.Size = new System.Drawing.Size(260, 77);
            ((System.ComponentModel.ISupportInitialize)(this.nupdFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFontSizeUp;
        private System.Windows.Forms.Button btnFontSizeDown;
        private System.Windows.Forms.NumericUpDown nupdFontSize;
        private System.Windows.Forms.Label labelMinimizeMaximize;
    }
}
