using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter.Controls
{
    public partial class UCMonitorPreviewBox : UserControl
    {

        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;

        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        private Image currentImage;
        private GlobalSettings _globalSettings;

        int _maxHeight = 177;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;
        //private bool _boxSizeChanged;

        #endregion

        #region Constructor & Properties

        public UCMonitorPreviewBox()
        {
            InitializeComponent();
            Counter = new Counter();
            GlobalSettings = new GlobalSettings();
            //_boxSizeChanged = false;
        }

        public bool Minimized
        {
            get { return _minimized; }
            //set { _minimized = value; }
        }

        public bool Maximized
        {
            get { return _maximized; }
            //set { _maximized = value; }
        }

        public Counter Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        public GlobalSettings GlobalSettings
        {
            get
            {
                return _globalSettings;
            }

            set
            {
                _globalSettings = value;

                if (_globalSettings.UCMonitorPreviewBoxAutostrtVideo)
                {
                    btnScreenshot.Visible = false;
                    checkBoxScreenVideo.Checked = true;
                    checkBoxScreenVideo.Visible = false;
                    pictureBoxPreview.Top = 25;
                    pictureBoxPreview.Left = 5;
                    pictureBoxPreview.Height = pictureBoxPreview.Height + 20;
                    pictureBoxPreview.Width = pictureBoxPreview.Width + 38;

                }
            }
        }

        //public bool BoxSizeChanged
        //{
        //    get { return _boxSizeChanged; }
        //    set { _boxSizeChanged = value; }
        //}

        #endregion

        #region Public Methods

        public void Maximize()
        {
            Height = _maxHeight;
            _minimized = false;
            _maximized = true;
            labelMinimizeMaximize.Text = " ˄ ";
            //_boxSizeChanged = true;
        }

        public void Minimize()
        {
            Height = _minHeight;
            _minimized = true;
            _maximized = false;
            labelMinimizeMaximize.Text = " ˅ ";
            //_boxSizeChanged = true;
        }

        #endregion

        #region Private Methods

        //képernyőkép készítése, videó módban is ezt használjuk
        private void setPicture(int screen)
        {
            using (Bitmap bmpScreenshot2 = new Bitmap(Screen.AllScreens[screen].Bounds.Width, Screen.AllScreens[screen].Bounds.Height, PixelFormat.Format24bppRgb))
            {
                Graphics gfxScreenshot2 = Graphics.FromImage(bmpScreenshot2);
                gfxScreenshot2.CopyFromScreen(Screen.AllScreens[screen].Bounds.X, Screen.AllScreens[screen].Bounds.Y, 0, 0, Screen.AllScreens[screen].Bounds.Size, CopyPixelOperation.SourceCopy);
                currentImage = ScaleImage(bmpScreenshot2, pictureBoxPreview.Width, pictureBoxPreview.Height);
                pictureBoxPreview.Image = currentImage;

                bmpScreenshot2.Dispose();

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        //kép méretarányos átméretezése
        public static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        #endregion

        #region Events

        private void btnGetPreview_Click(object sender, EventArgs e)
        {
            setPicture(_counter.CurrentMonitor);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setPicture(_counter.CurrentMonitor);
        }

        //Videó mód be/kikapcsolás
        private void checkBoxScreenVideo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxScreenVideo.Checked)
            {
                checkBoxScreenVideo.Text = "Video ( BE )";
                timer1.Enabled = true;
                btnScreenshot.Enabled = false;
                //pictureBoxPreview.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                checkBoxScreenVideo.Text = "Video ( KI )";
                timer1.Enabled = false;
                btnScreenshot.Enabled = true;
                //pictureBoxPreview.BorderStyle = BorderStyle.None;
            }
        }

        //ha a fejlécre vagy a szélén lévő label-re kattint
        private void MinimizeMaximize(object sender, EventArgs e)
        {
            if (Minimized)
            {
                Maximize();
            }
            else
            {
                Minimize();
            }
        }

        #endregion

        public void StartVideo() {
            timer1.Enabled = true;
        }

        public void StopVideo()
        {
            timer1.Enabled = false;
        }

    }
}
