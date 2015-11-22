using System.Drawing;

namespace SimpleCounter.CounterClasses
{
    class CounterColor
    {
        private Color _color1;
        private Color _color2;
        private Color _color3;
        private Color _color4;
        private Color _color5;
        private Color _green;
        private Color _red;
        private Color _white;
        private Color _black;

        public CounterColor()
        {
            _color1 = Color.SeaGreen;
            _color2 = Color.IndianRed;
            _color3 = Color.Black;
            _color4 = Color.WhiteSmoke;
            _color5 = Color.Yellow;
            _green = Color.SeaGreen;
            _red = Color.IndianRed;
            _black = Color.Black;
            _white = Color.WhiteSmoke;
        }

        public Color Color1
        {
            get { return _color1; }
            set { _color1 = value; }
        }

        public Color Color2
        {
            get { return _color2; }
            set { _color2 = value; }
        }

        public Color Color3
        {
            get { return _color3; }
            set { _color3 = value; }
        }

        public Color Color4
        {
            get { return _color4; }
            set { _color4 = value; }
        }

        public Color Color5
        {
            get { return _color5; }
            set { _color5 = value; }
        }

        public Color Green
        {
            get { return _green; }
            //set { _green = value; }
        }

        public Color Red
        {
            get { return _red; }
            //set { _red = value; }
        }

        public Color White
        {
            get { return _white; }
            //set { _white = value; }
        }

        public Color Black
        {
            get { return _black; }
            //set { _black = value; }
        }
    }
}
