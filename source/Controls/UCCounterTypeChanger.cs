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
    public partial class UCCounterTypeChanger : UserControl
    {
        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer;
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
            FormTimer = new FormTimer(_counter);
            FormTimer.Hide();
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

        public FormTimer FormTimer
        {
            get { return _formTimer; }
            set { _formTimer = value; }
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
                _formTimer.TimerUpdate();
                _ucCounter.UpdateTime();
                timer1.Enabled = false;

            }
            else
            {
                _counter.CounterType = CounterTypeEnum.DigitalClock;
                _formTimer.TimerUpdate();
                _ucCounter.UpdateTime();
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_counter.CounterType == CounterTypeEnum.DigitalClock)
            {
                _ucCounter.UpdateTime();
                _formTimer.TimerUpdate();
            }            
        }

    }
}
