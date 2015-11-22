using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter.Controls
{
    public partial class UCMonitorControlBox : UserControl
    {

        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer;
        private GlobalSettings _globalSettings;

        int _maxHeight = 138;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;


        //hol jelenjen meg a control a főablakban (sorrend beállításához kell)
        private int _windowPriority;

        #endregion

        #region Constructor & Properties

        public UCMonitorControlBox()
        {
            InitializeComponent();
            _counter = new Counter();
            _globalSettings = new GlobalSettings();


            nupdMonitor.Minimum = 1;
            nupdMonitor.Maximum = _counter.MonitorQuantity;

            _minimized = false;
            _maximized = true;

            _formTimer = new FormTimer(_counter);
            _formTimer.Hide();


            _windowPriority = 3;
        }

        public Counter Counter
        {
            set
            {
                _counter = value;
                nupdMonitor.Value = _counter.CurrentMonitor+1;
                ///beolvasásnál ellenőrizve
                //if (_counter.CurrentMonitor <= Screen.AllScreens.Length)
                //{
                //    nupdMonitor.Value = _counter.CurrentMonitor; 
                //}
                //else
                //{
                //    nupdMonitor.Value = 1;
                //    _counter.CurrentMonitor = 0;
                //}

            }
        }

        public int WindowPriority
        {
            get { return _windowPriority; }
            //set { _windowPriority = value; }
        }

        public FormTimer TimerForm
        {
            get { return _formTimer; }
            set { _formTimer = value; }
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

        public FormTimer FormTimer
        {
            get { return _formTimer; }
            set { _formTimer = value; }
        }

        public GlobalSettings GlobalSettings
        {
            get { return _globalSettings; }
            set { _globalSettings = value; }
        }

        #endregion

        #region Events


        private void btnMonitorDown_Click(object sender, EventArgs e)
        {
            if (nupdMonitor.Value > nupdMonitor.Minimum)
            {
                nupdMonitor.Value--;
            }
        }

        private void btnMonitorUp_Click(object sender, EventArgs e)
        {
            if (nupdMonitor.Value < nupdMonitor.Maximum)
            {
                nupdMonitor.Value++;
            }
        }

        private void rbtnShow_Click(object sender, EventArgs e)
        {
            if (!_counter.OnScreen)
            {
                _formTimer.Show();
                _formTimer.TimerUpdate();
                _formTimer.setScreen(_counter.CurrentMonitor);
                _counter.OnScreen = true;
            }
        }

        private void rbtnHide_Click(object sender, EventArgs e)
        {
            if (_counter.OnScreen)
            {
                _formTimer.Hide();
                _counter.OnScreen = false;
            }
        }

        //ha a fejlécre vagy a szélén lévő label-re kattint
        private void MinimizeMaximize(object sender, EventArgs e)
        {
            if (_minimized)
            {
                Maximize();
            }
            else
            {
                Minimize();
            }
        }

        #endregion

        #region Public Methods

        public void Maximize()
        {
            Height = _maxHeight;
            _minimized = false;
            _maximized = true;
            labelMinimizeMaximize.Text = " ˄ ";
        }

        public void Minimize()
        {
            Height = _minHeight;
            _minimized = true;
            _maximized = false;
            labelMinimizeMaximize.Text = " ˅ ";
        }

        #endregion

        private void nupdMonitor_ValueChanged(object sender, EventArgs e)
        {
            _counter.CurrentMonitor = (int)nupdMonitor.Value - 1;
        }

        private void rbtnShow_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
