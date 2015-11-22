namespace SimpleCounter.Controls
{
    partial class UCMonitorPreviewBox
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnScreenshot = new System.Windows.Forms.Button();
            this.labelMinimizeMaximize = new System.Windows.Forms.Label();
            this.checkBoxScreenVideo = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.DimGray;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(260, 20);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Monitorkép";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(22, 23);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(210, 124);
            this.pictureBoxPreview.TabIndex = 2;
            this.pictureBoxPreview.TabStop = false;
            // 
            // btnScreenshot
            // 
            this.btnScreenshot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnScreenshot.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnScreenshot.Location = new System.Drawing.Point(3, 151);
            this.btnScreenshot.Name = "btnScreenshot";
            this.btnScreenshot.Size = new System.Drawing.Size(120, 23);
            this.btnScreenshot.TabIndex = 3;
            this.btnScreenshot.Text = "Képernyőkép";
            this.btnScreenshot.UseVisualStyleBackColor = true;
            this.btnScreenshot.Click += new System.EventHandler(this.btnGetPreview_Click);
            // 
            // labelMinimizeMaximize
            // 
            this.labelMinimizeMaximize.BackColor = System.Drawing.Color.DimGray;
            this.labelMinimizeMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMinimizeMaximize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelMinimizeMaximize.Location = new System.Drawing.Point(236, 0);
            this.labelMinimizeMaximize.Name = "labelMinimizeMaximize";
            this.labelMinimizeMaximize.Size = new System.Drawing.Size(23, 20);
            this.labelMinimizeMaximize.TabIndex = 4;
            this.labelMinimizeMaximize.Text = " ˄ ";
            this.labelMinimizeMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinimizeMaximize.Click += new System.EventHandler(this.MinimizeMaximize);
            // 
            // checkBoxScreenVideo
            // 
            this.checkBoxScreenVideo.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxScreenVideo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxScreenVideo.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.checkBoxScreenVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxScreenVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxScreenVideo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBoxScreenVideo.Location = new System.Drawing.Point(129, 150);
            this.checkBoxScreenVideo.Name = "checkBoxScreenVideo";
            this.checkBoxScreenVideo.Size = new System.Drawing.Size(126, 24);
            this.checkBoxScreenVideo.TabIndex = 5;
            this.checkBoxScreenVideo.Text = "Video ( KI )";
            this.checkBoxScreenVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxScreenVideo.UseVisualStyleBackColor = true;
            this.checkBoxScreenVideo.CheckedChanged += new System.EventHandler(this.checkBoxScreenVideo_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCMonitorPreviewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxScreenVideo);
            this.Controls.Add(this.labelMinimizeMaximize);
            this.Controls.Add(this.btnScreenshot);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.labelHeader);
            this.Name = "UCMonitorPreviewBox";
            this.Size = new System.Drawing.Size(260, 177);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnScreenshot;
        private System.Windows.Forms.Label labelMinimizeMaximize;
        private System.Windows.Forms.CheckBox checkBoxScreenVideo;
        private System.Windows.Forms.Timer timer1;

    }
}
