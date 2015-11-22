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
    public partial class UCTimeDirection : UserControl
    {
        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;

        int _maxHeight = 49;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCTimeDirection()
        {
            InitializeComponent();

            Counter = new Counter();
        }

        public Counter Counter
        {
            get { return _counter; }
            set
            {
                _counter = value;
                if (_counter.Direction)
                {
                    rbtnNormal.Checked = true;
                }
                else
                {
                    rbtnVissza.Checked = true;
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

        //mindkét radiobutton click-re be van állítva
        private void SetCounterDirection(object sender, EventArgs e)
        {
            _counter.Direction = rbtnNormal.Checked;
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

        
    }
}
