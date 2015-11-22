using System.Drawing;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter
{
    public partial class FormTimer : Form
    {

        private Counter _counter;

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
            labelTime.Text = "";
        }


        public void TimerUpdate()
        {
            labelTime.Font = new Font(FontFamily.GenericSansSerif, _counter.FontSize);
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
    }
}
