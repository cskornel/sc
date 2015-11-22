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
    public partial class UCCounter : UserControl
    {

        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer;

        int _maxHeight = 118;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCCounter()
        {
            InitializeComponent();
            _counter = new Counter();

            FormTimer = new FormTimer(_counter);
            FormTimer.Hide();
        }

        public Counter Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                labelTimer.Text = _counter.ToString();
                chbHideText.Checked = _counter.HideText;

                chbSzovegesOra.Checked = _counter.SzovegesOra;
            }
        }

        public FormTimer FormTimer
        {
            get { return _formTimer; }
            set
            {
                _formTimer = value;
                if (_counter.HideText)
                {
                    _formTimer.HideText();
                }
            }
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

        #endregion

        #region Events

        private void chbSzovegesOra_CheckedChanged(object sender, EventArgs e)
        {
            _counter.SzovegesOra = chbSzovegesOra.Checked;
            labelTimer.Text = _counter.ToString();
            _formTimer.TimerUpdate();
        }

        private void chbHideText_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHideText.Checked)
            {
                _formTimer.HideText();
            }
            else
            {
                _formTimer.ShowText();
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

        public void UpdateTime()
        {
            labelTimer.BackColor = _counter.Direction ? Color.SeaGreen : Color.IndianRed;
            labelTimer.Text = _counter.ToString();
        }

        #endregion
    }
}
