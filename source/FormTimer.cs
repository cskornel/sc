using System.Drawing;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter
{
    public partial class FormTimer : Form
    {

        private Counter _counter;
        private int _fontSize;
        private bool _onScreen;

        public int FontSize
        {
            get
            {
                return _fontSize;
            }

            set
            {
                _fontSize = value;
            }
        }

        public bool OnScreen
        {
            get
            {
                return _onScreen;
            }

            set
            {
                _onScreen = value;
            }
        }

        public FormTimer()
        {
            InitializeComponent();
        }

        //public FormTimer(Counter counter, int screen)
        //{
        //    InitializeComponent();

        //    Location = Screen.AllScreens[screen].WorkingArea.Location;
        //    FormBorderStyle = FormBorderStyle.None;
        //    WindowState = FormWindowState.Maximized;
        //    _counter = counter;
        //    labelTime.Text = "";
        //}

        public FormTimer(Counter counter)
        {
            InitializeComponent();

            Location = Screen.AllScreens[counter.CurrentMonitor].WorkingArea.Location;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            _counter = counter;
            _onScreen = false;
            labelTime.Text = "";
            FontSize = 219;
        }


        public void TimerUpdate()
        {
            labelTime.Font = new Font(FontFamily.GenericSansSerif, FontSize);
            labelTime.ForeColor = _counter.FontColor;
            labelTime.Text = _counter.ToString();
        }

        public void SetTime()
        {
            labelTime.Text = _counter.ToString();
        }

        public void setScreen(int screen)
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.Manual;
            BringToFront();
            Location = Screen.AllScreens[screen].WorkingArea.Location;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void HideText()
        {
            _counter.FontColor = _counter.BackColor;
            labelTime.ForeColor = _counter.FontColor;
            _counter.HideText = true;
        }

        public void ShowText()
        {
            _counter.FontColor = Color.WhiteSmoke;
            labelTime.ForeColor = _counter.FontColor;
            _counter.HideText = false;
        }

        public void SetCounterColor(Color fontColor, Color backColor)
        {
            _counter.FontColor = fontColor;
            _counter.BackColor = backColor;
            labelTime.ForeColor = _counter.FontColor;
            labelTime.BackColor = _counter.BackColor;
        }

        public void SetCounterDefaultColors()
        {
            SetCounterColor(Color.WhiteSmoke, Color.Black);
        }
    }
}
