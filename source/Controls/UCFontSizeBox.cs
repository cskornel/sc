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
    public partial class UCFontSizeBox : UserControl
    {
        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer;
        private GlobalSettings _globalSettings;
        
        int _maxHeight = 77;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCFontSizeBox()
        {
            InitializeComponent();
            
            _counter = new Counter();
            _formTimer = new FormTimer(_counter);
            _formTimer.Hide();
            _globalSettings = new GlobalSettings();

            //nupdFontSize.Value = _counter.FontSize;
            nupdFontSize.Value = 219;
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
            set
            {
                _counter = value;
                //nupdFontSize.Value = _counter.FontSize;
            }
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

        private void nupdFontSize_ValueChanged(object sender, EventArgs e)
        {           
            if (_formTimer!=null)
            {
                _formTimer.FontSize = (int)nupdFontSize.Value;
                _formTimer.TimerUpdate();  
            }
            
        }

        private void btnFontSizeUp_Click(object sender, EventArgs e)
        {
            if (nupdFontSize.Value < nupdFontSize.Maximum)
            {
                nupdFontSize.Value += _globalSettings.LeptekBetumeretValtoztatashoz;
            }
        }

        private void btnFontSizeDown_Click(object sender, EventArgs e)
        {
            if (nupdFontSize.Value > nupdFontSize.Minimum)
            {
                nupdFontSize.Value -= _globalSettings.LeptekBetumeretValtoztatashoz;
            }
        }

        #endregion

       
    }
}
