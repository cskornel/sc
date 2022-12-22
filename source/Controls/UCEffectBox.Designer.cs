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
            this.chbEffectBackCounter2 = new System.Windows.Forms.CheckBox();
            this.nupdColor2EffectTime = new System.Windows.Forms.NumericUpDown();
            this.chbFlash = new System.Windows.Forms.CheckBox();
            this.nupdSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerEffect = new System.Windows.Forms.Timer(this.components);
            this.chbEffectBackCounter1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nupdColor1EffectTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupdColor2EffectTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdColor1EffectTime)).BeginInit();
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
            // chbEffectBackCounter2
            // 
            this.chbEffectBackCounter2.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbEffectBackCounter2.BackColor = System.Drawing.Color.Black;
            this.chbEffectBackCounter2.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbEffectBackCounter2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbEffectBackCounter2.ForeColor = System.Drawing.Color.White;
            this.chbEffectBackCounter2.Location = new System.Drawing.Point(12, 93);
            this.chbEffectBackCounter2.Name = "chbEffectBackCounter2";
            this.chbEffectBackCounter2.Size = new System.Drawing.Size(131, 50);
            this.chbEffectBackCounter2.TabIndex = 33;
            this.chbEffectBackCounter2.Text = "Figyelmeztetés 2 ( KI )";
            this.chbEffectBackCounter2.UseVisualStyleBackColor = false;
            this.chbEffectBackCounter2.CheckedChanged += new System.EventHandler(this.chbEffectBackCounter2_CheckedChanged);
            // 
            // nupdColor2EffectTime
            // 
            this.nupdColor2EffectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdColor2EffectTime.Location = new System.Drawing.Point(164, 103);
            this.nupdColor2EffectTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdColor2EffectTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdColor2EffectTime.Name = "nupdColor2EffectTime";
            this.nupdColor2EffectTime.Size = new System.Drawing.Size(80, 40);
            this.nupdColor2EffectTime.TabIndex = 35;
            this.nupdColor2EffectTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdColor2EffectTime.ValueChanged += new System.EventHandler(this.nupdColorEffectTime2_ValueChanged);
            // 
            // chbFlash
            // 
            this.chbFlash.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbFlash.BackColor = System.Drawing.Color.Black;
            this.chbFlash.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbFlash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbFlash.ForeColor = System.Drawing.Color.White;
            this.chbFlash.Location = new System.Drawing.Point(12, 157);
            this.chbFlash.Name = "chbFlash";
            this.chbFlash.Size = new System.Drawing.Size(131, 50);
            this.chbFlash.TabIndex = 36;
            this.chbFlash.Text = "Villog, ha lejárt az idő( KI )";
            this.chbFlash.UseVisualStyleBackColor = false;
            this.chbFlash.CheckedChanged += new System.EventHandler(this.chbFlash_CheckedChanged);
            // 
            // nupdSpeed
            // 
            this.nupdSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdSpeed.Location = new System.Drawing.Point(164, 167);
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
            this.label1.Location = new System.Drawing.Point(161, 149);
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
            this.label2.Location = new System.Drawing.Point(161, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Idő:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timerEffect
            // 
            this.timerEffect.Tick += new System.EventHandler(this.timerEffect_Tick);
            // 
            // chbEffectBackCounter1
            // 
            this.chbEffectBackCounter1.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbEffectBackCounter1.BackColor = System.Drawing.Color.Black;
            this.chbEffectBackCounter1.FlatAppearance.CheckedBackColor = System.Drawing.Color.SeaGreen;
            this.chbEffectBackCounter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chbEffectBackCounter1.ForeColor = System.Drawing.Color.White;
            this.chbEffectBackCounter1.Location = new System.Drawing.Point(12, 29);
            this.chbEffectBackCounter1.Name = "chbEffectBackCounter1";
            this.chbEffectBackCounter1.Size = new System.Drawing.Size(131, 50);
            this.chbEffectBackCounter1.TabIndex = 40;
            this.chbEffectBackCounter1.Text = "Figyelmeztetés 1 ( KI )";
            this.chbEffectBackCounter1.UseVisualStyleBackColor = false;
            this.chbEffectBackCounter1.CheckedChanged += new System.EventHandler(this.chbEffectBackCounter1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(161, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Idő:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nupdColor1EffectTime
            // 
            this.nupdColor1EffectTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nupdColor1EffectTime.Location = new System.Drawing.Point(164, 39);
            this.nupdColor1EffectTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupdColor1EffectTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupdColor1EffectTime.Name = "nupdColor1EffectTime";
            this.nupdColor1EffectTime.Size = new System.Drawing.Size(80, 40);
            this.nupdColor1EffectTime.TabIndex = 41;
            this.nupdColor1EffectTime.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nupdColor1EffectTime.ValueChanged += new System.EventHandler(this.nupdColorEffectTime1_ValueChanged);
            // 
            // UCEffectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupdColor1EffectTime);
            this.Controls.Add(this.chbEffectBackCounter1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nupdSpeed);
            this.Controls.Add(this.chbFlash);
            this.Controls.Add(this.nupdColor2EffectTime);
            this.Controls.Add(this.chbEffectBackCounter2);
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.labelTitle);
            this.Name = "UCEffectBox";
            this.Size = new System.Drawing.Size(260, 215);
            ((System.ComponentModel.ISupportInitialize)(this.nupdColor2EffectTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupdColor1EffectTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMinimizeMaximize;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox chbEffectBackCounter2;
        private System.Windows.Forms.NumericUpDown nupdColor2EffectTime;
        private System.Windows.Forms.CheckBox chbFlash;
        private System.Windows.Forms.NumericUpDown nupdSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerEffect;
        private System.Windows.Forms.CheckBox chbEffectBackCounter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nupdColor1EffectTime;
    }
}
