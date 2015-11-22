namespace SimpleCounter.Controls
{
    partial class UCTimeSettings
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTimeDown = new System.Windows.Forms.Button();
            this.btnTimeUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nupdTime = new System.Windows.Forms.NumericUpDown();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupdTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(167, 81);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 52);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Nulláz";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTimeDown
            // 
            this.btnTimeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTimeDown.Location = new System.Drawing.Point(86, 98);
            this.btnTimeDown.Name = "btnTimeDown";
            this.btnTimeDown.Size = new System.Drawing.Size(75, 35);
            this.btnTimeDown.TabIndex = 29;
            this.btnTimeDown.Text = "˅";
            this.btnTimeDown.UseVisualStyleBackColor = true;
            this.btnTimeDown.Click += new System.EventHandler(this.btnTimeDown_Click);
            // 
            // btnTimeUp
            // 
            this.btnTimeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTimeUp.Location = new System.Drawing.Point(87, 24);
            this.btnTimeUp.Name = "btnTimeUp";
            this.btnTimeUp.Size = new System.Drawing.Size(75, 35);
            this.btnTimeUp.TabIndex = 28;
            this.btnTimeUp.Text = "˄";
            this.btnTimeUp.UseVisualStyleBackColor = true;
            this.btnTimeUp.Click += new System.EventHandler(this.btnTimeUp_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(3, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 109);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nupdTime
            // 
            this.nupdTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdTime.ForeColor = System.Drawing.Color.IndianRed;
            this.nupdTime.Location = new System.Drawing.Point(88, 63);
            this.nupdTime.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupdTime.Name = "nupdTime";
            this.nupdTime.Size = new System.Drawing.Size(74, 31);
            this.nupdTime.TabIndex = 24;
            // 
            // btnSetTime
            // 
            this.btnSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetTime.Location = new System.Drawing.Point(167, 24);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(87, 52);
            this.btnSetTime.TabIndex = 25;
            this.btnSetTime.Text = "Beállít";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Idő (perc)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, -1);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 31;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // UCTimeSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTimeDown);
            this.Controls.Add(this.btnTimeUp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nupdTime);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.label6);
            this.Name = "UCTimeSettings";
            this.Size = new System.Drawing.Size(260, 137);
            ((System.ComponentModel.ISupportInitialize)(this.nupdTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTimeDown;
        private System.Windows.Forms.Button btnTimeUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nupdTime;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMinimizeMaximize;
    }
}
