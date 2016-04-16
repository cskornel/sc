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
        private int _formatum;

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

        public int Formatum
        {
            get
            {
                return _formatum;
            }

            set
            {
                _formatum = value;
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
            Formatum = 0;
        }


        public void TimerUpdate()
        {
            if (_formatum != 0 && _counter.CounterType != CounterTypeEnum.Counter)
            {
                labelTime.Font = new Font(FontFamily.GenericSansSerif, FontSize);
                labelTime.ForeColor = _counter.FontColor;
                labelTime.Text = _counter.StringFormat2();
            }
            else
            {
                labelTime.Font = new Font(FontFamily.GenericSansSerif, FontSize);
                labelTime.ForeColor = _counter.FontColor;
                labelTime.Text = _counter.ToString();
            }

        }

        public void SetTime()
        {
            if (_formatum != 0 && _counter.CounterType != CounterTypeEnum.Counter)
            {
                labelTime.Text = _counter.StringFormat2();
            }
            else
            {
                labelTime.Text = _counter.ToString();
            }

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
            if (_counter.CounterType == CounterTypeEnum.Counter)
            {
                SetCounterColor(Color.SpringGreen, Color.Black);
            }
            else
            {
                SetCounterColor(Color.WhiteSmoke, Color.Black);
            }
            
        }
    }
}
