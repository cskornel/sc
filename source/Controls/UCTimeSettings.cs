using System;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter.Controls
{
    public partial class UCTimeSettings : UserControl
    {

        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer1;
        private FormTimer _formTimer2;
        private GlobalSettings _globalSettings;
        private UCCounter _ucCounter;

        int _maxHeight = 137;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCTimeSettings()
        {
            InitializeComponent();
            Counter = new Counter();
            _formTimer1 = new FormTimer(Counter);
            _formTimer1.Hide();
            _formTimer2 = new FormTimer(Counter);
            _formTimer2.Hide();
            GlobalSettings = new GlobalSettings();
            UcCounter = new UCCounter();

        }

        public Counter Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }

        public FormTimer FormTimer1
        {
            get { return _formTimer1; }
            set { _formTimer1 = value; }
        }

        public GlobalSettings GlobalSettings
        {
            get { return _globalSettings; }
            set { _globalSettings = value; }
        }

        public bool Minimized
        {
            get { return _minimized; }
            set { _minimized = value; }
        }

        public bool Maximized
        {
            get { return _maximized; }
            set { _maximized = value; }
        }

        public UCCounter UcCounter
        {
            get { return _ucCounter; }
            set { _ucCounter = value; }
        }

        public FormTimer FormTimer2
        {
            get
            {
                return _formTimer2;
            }

            set
            {
                _formTimer2 = value;
            }
        }

        #endregion

        #region Events

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

        #region Public Methods

        public void Maximize()
        {
            Height = _maxHeight;
            Minimized = false;
            Maximized = true;
            labelMinimizeMaximize.Text = " ˄ ";
        }

        public void Minimize()
        {
            Height = _minHeight;
            Minimized = true;
            Maximized = false;
            labelMinimizeMaximize.Text = " ˅ ";
        }

        #endregion

        private void btnTimeUp_Click(object sender, EventArgs e)
        {
            nupdTime.Value++;
        }

        private void btnTimeDown_Click(object sender, EventArgs e)
        {
            nupdTime.Value--;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _counter.UserTime += ((int)nupdTime.Value * 60);
            _formTimer1.TimerUpdate();
            _formTimer2.TimerUpdate();
            _ucCounter.UpdateTime();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            _counter.UserTime = ((int)nupdTime.Value * 60);
            _formTimer1.TimerUpdate();
            _formTimer1.SetCounterDefaultColors();
            _formTimer2.TimerUpdate();
            _formTimer2.SetCounterDefaultColors();
            _ucCounter.UpdateTime();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nupdTime.Value = 0;
            //TODO: if a global settings miatt (csak a numericupdawn értéke legyen nulla vagy a számlálóé is?)
            _counter.UserTime = ((int)nupdTime.Value * 60);
            _formTimer1.TimerUpdate();
            _formTimer2.TimerUpdate();
            _formTimer1.SetCounterDefaultColors();
            _formTimer2.SetCounterDefaultColors();

            if (_counter.HideText)
            {
                _formTimer1.HideText();
                _formTimer2.HideText();
            } 

            _ucCounter.UpdateTime();
        }

        private void btnMinussz_Click(object sender, EventArgs e)
        {
            _counter.UserTime -= ((int)nupdTime.Value * 60);
            _formTimer1.TimerUpdate();
            _formTimer2.TimerUpdate();
            _ucCounter.UpdateTime();
        }
    }
}
