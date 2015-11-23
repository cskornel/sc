namespace SimpleCounter.Controls
{
    partial class UCEffectBox
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
            this.components = new System.ComponentModel.Container();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.chbEffectBackCounter = new System.Windows.Forms.CheckBox();
            this.nupdColorEffectTime = new System.Windows.Forms.NumericUpDown();
            this.chbFlash = new System.Windows.Forms.CheckBox();
            this.nupdSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerEffect = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupdColorEffectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(235, 0);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 32;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
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
            this.labelTitle.TabIndex = 31;
            this.labelTitle.Text = "Effektek";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // chbEffectBackCounter
            // 
            this.chbEffectBackCounter.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbEffectBackCounter.BackColor = System.Drawing.Color.Black;
            this.chbEffectBackCounter.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbEffectBackCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbEffectBackCounter.ForeColor = System.Drawing.Color.White;
            this.chbEffectBackCounter.Location = new System.Drawing.Point(12, 35);
            this.chbEffectBackCounter.Name = "chbEffectBackCounter";
            this.chbEffectBackCounter.Size = new System.Drawing.Size(115, 50);
            this.chbEffectBackCounter.TabIndex = 33;
            this.chbEffectBackCounter.Text = "Visszaszámlálásnál figyelmeztetés ( KI )";
            this.chbEffectBackCounter.UseVisualStyleBackColor = false;
            this.chbEffectBackCounter.CheckedChanged += new System.EventHandler(this.chbEffectBackCounter_CheckedChanged);
            // 
            // nupdColorEffectTime
            // 
            this.nupdColorEffectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdColorEffectTime.Location = new System.Drawing.Point(153, 45);
            this.nupdColorEffectTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdColorEffectTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdColorEffectTime.Name = "nupdColorEffectTime";
            this.nupdColorEffectTime.Size = new System.Drawing.Size(80, 40);
            this.nupdColorEffectTime.TabIndex = 35;
            this.nupdColorEffectTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdColorEffectTime.ValueChanged += new System.EventHandler(this.nupdColorEffectTime_ValueChanged);
            // 
            // chbFlash
            // 
            this.chbFlash.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbFlash.BackColor = System.Drawing.Color.Black;
            this.chbFlash.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFlash.ForeColor = System.Drawing.Color.White;
            this.chbFlash.Location = new System.Drawing.Point(12, 98);
            this.chbFlash.Name = "chbFlash";
            this.chbFlash.Size = new System.Drawing.Size(115, 50);
            this.chbFlash.TabIndex = 36;
            this.chbFlash.Text = "Villog, ha lejárt az idő ( KI )";
            this.chbFlash.UseVisualStyleBackColor = false;
            this.chbFlash.CheckedChanged += new System.EventHandler(this.chbFlash_CheckedChanged);
            // 
            // nupdSpeed
            // 
            this.nupdSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdSpeed.Location = new System.Drawing.Point(153, 108);
            this.nupdSpeed.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nupdSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdSpeed.Name = "nupdSpeed";
            this.nupdSpeed.Size = new System.Drawing.Size(80, 40);
            this.nupdSpeed.TabIndex = 37;
            this.nupdSpeed.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupdSpeed.ValueChanged += new System.EventHandler(this.nupdSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(150, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sebesség:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(150, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Idő:";
            // 
            // timerEffect
            // 
            this.timerEffect.Tick += new System.EventHandler(this.timerEffect_Tick);
            // 
            // UCEffectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupdSpeed);
            this.Controls.Add(this.chbFlash);
            this.Controls.Add(this.nupdColorEffectTime);
            this.Controls.Add(this.chbEffectBackCounter);
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.labelTitle);
            this.Name = "UCEffectBox";
            this.Size = new System.Drawing.Size(260, 160);
            ((System.ComponentModel.ISupportInitialize)(this.nupdColorEffectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinimizeMaximize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox chbEffectBackCounter;
        private System.Windows.Forms.NumericUpDown nupdColorEffectTime;
        private System.Windows.Forms.CheckBox chbFlash;
        private System.Windows.Forms.NumericUpDown nupdSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerEffect;
    }
}
