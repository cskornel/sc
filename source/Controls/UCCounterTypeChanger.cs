using System;
using System.Windows.Forms;
using SimpleCounter.CounterClasses;

namespace SimpleCounter.Controls
{
    public partial class UCCounterTypeChanger : UserControl
    {
        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer1;
        private FormTimer _formTimer2;
        private UCCounter _ucCounter;


        int _maxHeight = 72;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCCounterTypeChanger()
        {
            InitializeComponent();
            _counter = new Counter();
            FormTimer1 = new FormTimer(_counter);
            FormTimer1.Hide();
            FormTimer2 = new FormTimer(_counter);
            FormTimer2.Hide();
            UcCounter = new UCCounter();
        }

        public Counter Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                if (_counter.CounterType == CounterTypeEnum.Counter)
                {
                    rbtnCounter.Checked = true;
                }
                else
                {

                    rbtnDigitalClock.Checked = true;
                }
            }
        }

        public UCCounter UcCounter
        {
            get { return _ucCounter; }
            set { _ucCounter = value; }
        }

        public bool Minimized
        {
            get { return _minimized; }
            set { _minimized = value; }
        }

        public FormTimer FormTimer1
        {
            get
            {
                return _formTimer1;
            }

            set
            {
                _formTimer1 = value;
            }
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
            _maximized = true;
            labelMinimizeMaximize.Text = " ˄ ";
        }

        public void Minimize()
        {
            Height = _minHeight;
            Minimized = true;
            _maximized = false;
            labelMinimizeMaximize.Text = " ˅ ";
        }

        #endregion

        private void CounterType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCounter.Checked)
            {
                _counter.CounterType = CounterTypeEnum.Counter;
                _formTimer1.TimerUpdate();
                _formTimer2.TimerUpdate();
                _ucCounter.UpdateTime();
                timer1.Enabled = false;

            }
            else
            {
                _counter.CounterType = CounterTypeEnum.DigitalClock;
                _formTimer1.TimerUpdate();
                _formTimer1.SetCounterDefaultColors();
                _formTimer2.TimerUpdate();
                _formTimer2.SetCounterDefaultColors();
                _ucCounter.UpdateTime();
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_counter.CounterType == CounterTypeEnum.DigitalClock)
            {
                _ucCounter.UpdateTime();
                _formTimer1.TimerUpdate();
                _formTimer2.TimerUpdate();
            }            
        }

    }
}
