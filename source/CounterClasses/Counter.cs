using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleCounter.CounterClasses
{
    public enum CounterTypeEnum
    {
        Counter,
        DigitalClock,
        AnalogClock
    }

    public class Counter : ISCXML
    {
        //azonosító
        private int _id;
        //számláló háttérszíne
        private Color _backColor;
        //számláló betűszíne
        private Color _fontColor;
        //betüméret a száámlálón
        private int _fontSize;
        //a számláló aktuális értéke
        private int _userTime;
        //true=számol, false=áll
        private bool _enabled;
        //true= előre számol, false=visszafelé
        private bool _direction;
        //true=számláló megjelenítve, false=számláló elrejtve
        private bool _onScreen;
        //szöveg elrejtése a monitoron
        private bool _hideText;
        //monitor darabszám
        private int _monitorQuantity;
        //aktuálisan beállított monitor
        private int _currentMonitor;
        //kimente típusa: számláló, óra
        private CounterTypeEnum _counterType;
        //óra
        private int _hour;
        //perc
        private int _min;
        //másodperc
        private int _sec;
        //kijelzés módja
        private bool _szovegesOra;
        //visszaszámlálásnál megváltozik a színe a számoknak
        private bool _figylmeztetVisszaszamlalasnal;
        //mikor kezdjen figyelmeztetni (ha már csak ennyi dő van hátra)
        private int _figyelmeztetIdo;
        //villognak a szamok (ha pl. lejárt az idő)
        private bool _villogasEffect;
        //villogás sebessége
        private int _villogasEffectSebesseg;


        #region constructor

        public Counter()
        {
            _id = 1;
            _backColor = Color.Black;
            _fontColor = Color.WhiteSmoke;
            _fontSize = 219;
            _userTime = 0;
            _enabled = false;
            _direction = true;
            _onScreen = false;
            SzovegesOra = true;
            _monitorQuantity = Screen.AllScreens.Length;
            _currentMonitor = 0;
            _counterType = CounterTypeEnum.Counter;
            _hideText = false;
            _figylmeztetVisszaszamlalasnal = false;
            _villogasEffect = false;
            _figyelmeztetIdo = 60;
            _villogasEffectSebesseg = 500;

        }

        //public Counter(int id, Color color, int fontSize, int time)
        //{
        //    _id = id;
        //    _backColor = Color.Black;
        //    _fontColor = Color.WhiteSmoke;
        //    _fontSize = fontSize;
        //    UserTime = time;
        //    _enabled = false;
        //    _onScreen = false;
        //    SzovegesOra = false;
        //    _monitorQuantity = Screen.AllScreens.Length;
        //    CurrentMonitor = 0;
        //    _counterType = CounterTypeEnum.Counter;

        //}

        #endregion

        #region property

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int FontSize
        {
            get { return _fontSize; }
            set { _fontSize = value; }
        }

        public int UserTime
        {
            get { return _userTime; }
            set { _userTime = value; }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public bool Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        public bool SzovegesOra
        {
            get { return _szovegesOra; }
            set { _szovegesOra = value; }
        }

        public bool OnScreen
        {
            get { return _onScreen; }
            set { _onScreen = value; }
        }

        public Color BackColor
        {
            get { return _backColor; }
            set { _backColor = value; }
        }

        public Color FontColor
        {
            get { return _fontColor; }
            set { _fontColor = value; }
        }

        public int MonitorQuantity
        {
            get { return _monitorQuantity; }
            //set { _monitorQuantity = value; }
        }

        public int CurrentMonitor
        {
            get { return _currentMonitor; }
            set { _currentMonitor = value; }
        }

        public CounterTypeEnum CounterType
        {
            get { return _counterType; }
            set { _counterType = value; }
        }

        public bool HideText
        {
            get { return _hideText; }
            set { _hideText = value; }
        }

        public bool FigylmeztetVisszaszamlalasnal
        {
            get { return _figylmeztetVisszaszamlalasnal; }
            set { _figylmeztetVisszaszamlalasnal = value; }
        }

        public bool VillogasEffect
        {
            get { return _villogasEffect; }
            set { _villogasEffect = value; }
        }

        public int FigyelmeztetIdo
        {
            get { return _figyelmeztetIdo; }
            set { _figyelmeztetIdo = value; }
        }

        public int VillogasEffectSebesseg
        {
            get { return _villogasEffectSebesseg; }
            set { _villogasEffectSebesseg = value; }
        }

        #endregion

        public void Go()
        {
            if (_direction)
                UserTime++;
            else
                UserTime--;
        }

        public override string ToString()
        {
            if (_counterType == CounterTypeEnum.Counter)
            {
                _hour = (_userTime / 3600);
                _min = (_userTime / 60) - _hour * 60;
                _sec = _userTime - (_min * 60) - (_hour * 3600);
            }
            else
            {
                _hour = DateTime.Now.Hour;
                _min = DateTime.Now.Minute;
                _sec = DateTime.Now.Second;
            }

            string strhour = SzovegesOra ? Math.Abs(_hour).ToString("0") + " óra\r\n" : Math.Abs(_hour).ToString("0");
            string strmin = (_hour == 0) ? Math.Abs(_min).ToString("0") : Math.Abs(_min).ToString("00");
            string strsec = Math.Abs(_sec).ToString("00");

            string strTime = (_hour == 0) ? (strmin + " : " + strsec) : (SzovegesOra ? (strhour + strmin + " : " + strsec) : (strhour + " : " + strmin + " : " + strsec));

            strTime = (_userTime < 0) ? "- " + strTime : strTime;

            return strTime;
        }


        public XElement ToXML()
        {
            XElement tmpxml = new XElement("Counter");
            XAttribute id = new XAttribute("id", this.Id);
            XAttribute fontsize = new XAttribute("fontsize", this.FontSize);
            XAttribute time = new XAttribute("time", this._userTime);
            XAttribute currentMonitor = new XAttribute("currentMonitor", this._currentMonitor);
            XAttribute counterType = new XAttribute("counterType", (int)this._counterType);
            XAttribute direction = new XAttribute("direction", (this._direction ? 1 : 0));
            XAttribute szovegesOra = new XAttribute("szovegesOra", (this._szovegesOra ? 1 : 0));
            XAttribute hideText = new XAttribute("hideText", (this._hideText ? 1 : 0));


            tmpxml.Add(id);
            tmpxml.Add(fontsize);
            tmpxml.Add(time);
            tmpxml.Add(currentMonitor);
            tmpxml.Add(counterType);
            tmpxml.Add(szovegesOra);
            tmpxml.Add(direction);
            tmpxml.Add(hideText);

            return tmpxml;
        }

    }
}
