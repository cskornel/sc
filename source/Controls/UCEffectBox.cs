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
    public partial class UCEffectBox : UserControl
    {
        #region Declaration

        //a control használata előtt be kell állítani ezeket a változókat
        private Counter _counter;
        private FormTimer _formTimer1;
        private FormTimer _formTimer2;

        int _maxHeight = 160;
        int _minHeight = 22;
        int _maxWidth = 260;
        private bool _minimized;
        private bool _maximized;

        #endregion

        #region Constructor & Properties

        public UCEffectBox()
        {
            InitializeComponent();
            _counter = new Counter();

            FormTimer1 = new FormTimer(_counter);
            FormTimer1.Hide();

            FormTimer2 = new FormTimer(_counter);
            FormTimer2.Hide();

            chbEffectBackCounter.Text = "Visszaszámlálásnál figyelmeztetés \r\n( KI )";
            chbFlash.Text = "Villog, ha lejárt az idő  \r\n( KI )";
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

        private void chbEffectBackCounter_CheckedChanged(object sender, EventArgs e)
        {
            _counter.FigylmeztetVisszaszamlalasnal = chbEffectBackCounter.Checked;
            _counter.FigyelmeztetIdo = (int)nupdColorEffectTime.Value * 60;

            string tmpStr = "Visszaszámlálásnál figyelmeztetés ";
            if (chbEffectBackCounter.Checked)
            {
                chbEffectBackCounter.Text = tmpStr + " \r\n( BE )";
            }
            else
            {
                chbEffectBackCounter.Text = tmpStr + " \r\n( KI )";
            }
        }

        private void chbFlash_CheckedChanged(object sender, EventArgs e)
        {
            _counter.VillogasEffect = chbFlash.Checked;
            _counter.VillogasEffectSebesseg = (int)nupdSpeed.Value;

            string tmpStr = "Villog, ha lejárt az idő ";
            if (chbFlash.Checked)
            {
                chbFlash.Text = tmpStr + " \r\n( BE )";
                timerEffect.Interval = _counter.VillogasEffectSebesseg;
                timerEffect.Enabled = true;
            }
            else
            {
                chbFlash.Text = tmpStr + " \r\n( KI )";
                timerEffect.Enabled = false;
                _formTimer1.ShowText();
                _formTimer2.ShowText();
            }
        }

        private void nupdColorEffectTime_ValueChanged(object sender, EventArgs e)
        {
            _counter.FigyelmeztetIdo = (int)nupdColorEffectTime.Value * 60;
        }

        private void timerEffect_Tick(object sender, EventArgs e)
        {
            if (_counter.VillogasEffect && _counter.UserTime == 0 && !_counter.Direction && _counter.CounterType == CounterTypeEnum.Counter)
            {
                _formTimer1.SetCounterColor(Color.WhiteSmoke, Color.Red);
                _formTimer2.SetCounterColor(Color.WhiteSmoke, Color.Red);

                if (_counter.HideText)
                {
                    _formTimer1.ShowText();
                    _formTimer2.ShowText();
                }
                else
                {
                    _formTimer1.HideText();
                    _formTimer2.HideText();
                }
            }
        }

        private void nupdSpeed_ValueChanged(object sender, EventArgs e)
        {
            _counter.VillogasEffectSebesseg = (int)nupdSpeed.Value;
            timerEffect.Interval = _counter.VillogasEffectSebesseg;
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

        public void Refresh() {
            chbFlash.Checked = _counter.VillogasEffect;
        }

        #endregion

        

    }
}
