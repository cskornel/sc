namespace SimpleCounter.Controls
{
    partial class UCTimeDirection
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
            this.rbtnVissza = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtnVissza
            // 
            this.rbtnVissza.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnVissza.BackColor = System.Drawing.Color.Black;
            this.rbtnVissza.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbtnVissza.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnVissza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnVissza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnVissza.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnVissza.Location = new System.Drawing.Point(130, 20);
            this.rbtnVissza.Name = "rbtnVissza";
            this.rbtnVissza.Size = new System.Drawing.Size(130, 29);
            this.rbtnVissza.TabIndex = 19;
            this.rbtnVissza.Text = "Visszafelé";
            this.rbtnVissza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnVissza.UseVisualStyleBackColor = false;
            this.rbtnVissza.Click += new System.EventHandler(this.SetCounterDirection);
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnNormal.Checked = true;
            this.rbtnNormal.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnNormal.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.rbtnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnNormal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rbtnNormal.Location = new System.Drawing.Point(0, 20);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(130, 29);
            this.rbtnNormal.TabIndex = 18;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Előre (normál)";
            this.rbtnNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnNormal.UseVisualStyleBackColor = true;
            this.rbtnNormal.Click += new System.EventHandler(this.SetCounterDirection);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Számlálás iránya";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, 0);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 21;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // UCTimeDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.rbtnVissza);
            this.Controls.Add(this.rbtnNormal);
            this.Controls.Add(this.label5);
            this.Name = "UCTimeDirection";
            this.Size = new System.Drawing.Size(260, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnVissza;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMinimizeMaximize;
    }
}
