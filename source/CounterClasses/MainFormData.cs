using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimpleCounter.CounterClasses
{
    class MainFormData : ISCXML
    {
        

        public int Top { get; set; }

        public int Left { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public bool AutoZeroChecked { get; set; }

        public bool UcMonitorPreviewBoxMinimize { get; set; }

        public bool UcMonitorControlBoxMinimize { get; set; }

        public bool UcFontSizeBoxMinimize { get; set; }

        public bool UcCounterTypeChangerMinimize { get; set; }

        public bool UcCounterMinimize { get; set; }

        public bool UcTimeDirectionMinimize { get; set; }

        public bool UcTimeSettingsMinimize { get; set; }

        

        public MainFormData()
        {
            Top = 0;
            Left = 0;
            Height = 0;
            Width = 0;
            AutoZeroChecked = true;

            UcMonitorPreviewBoxMinimize = false;
            UcMonitorControlBoxMinimize = false;
            UcFontSizeBoxMinimize = false;
            UcCounterTypeChangerMinimize = false;
            UcCounterMinimize = false;
            UcTimeDirectionMinimize = false;
            UcTimeSettingsMinimize = false;

        }

        public MainFormData(int top, int left, int width, int height, bool zChecked,
                            bool ucMonitorPreviewBoxMinimize,
                            bool ucMonitorControlBoxMinimize,
                            bool ucFontSizeBoxMinimize,
                            bool ucCounterTypeChangerMinimize,
                            bool ucCounterMinimize,
                            bool ucTimeDirectionMinimize,
                            bool ucTimeSettingsMinimize)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;
            AutoZeroChecked = zChecked;

            UcMonitorPreviewBoxMinimize = ucMonitorPreviewBoxMinimize;
            UcMonitorControlBoxMinimize = ucMonitorControlBoxMinimize;
            UcFontSizeBoxMinimize = ucFontSizeBoxMinimize;
            UcCounterTypeChangerMinimize = ucCounterTypeChangerMinimize;
            UcCounterMinimize = ucCounterMinimize;
            UcTimeDirectionMinimize = ucTimeDirectionMinimize;
            UcTimeSettingsMinimize = ucTimeSettingsMinimize;

        }

        public XElement ToXML()
        {
            XElement tmpxml = new XElement("Mainform");
            XAttribute top = new XAttribute("top", this.Top);
            XAttribute left = new XAttribute("left", this.Left);
            XAttribute width = new XAttribute("width", this.Width);
            XAttribute height = new XAttribute("height", this.Height);
            XAttribute zChecked = new XAttribute("zChecked", (this.AutoZeroChecked ? 1 : 0));
            XAttribute ucMonitorPreviewBoxMinimize = new XAttribute("ucMonitorPreviewBoxMinimize", (this.UcMonitorPreviewBoxMinimize ? 1 : 0));
            XAttribute ucucMonitorControlBoxMinimize = new XAttribute("ucucMonitorControlBoxMinimize", (this.UcMonitorControlBoxMinimize ? 1 : 0));
            XAttribute ucFontSizeBoxMinimize = new XAttribute("ucFontSizeBoxMinimize", (this.UcFontSizeBoxMinimize ? 1 : 0));
            XAttribute ucCounterTypeChangerMinimize = new XAttribute("ucCounterTypeChangerMinimize", (this.UcCounterTypeChangerMinimize ? 1 : 0));
            XAttribute ucCounterMinimize = new XAttribute("ucCounterMinimize", (this.UcCounterMinimize ? 1 : 0));
            XAttribute ucTimeDirectionMinimize = new XAttribute("ucTimeDirectionMinimize", (this.UcTimeDirectionMinimize ? 1 : 0));
            XAttribute ucTimeSettingsMinimize = new XAttribute("ucTimeSettingsMinimize", (this.UcTimeSettingsMinimize ? 1 : 0));

            tmpxml.Add(top);
            tmpxml.Add(left);
            tmpxml.Add(width);
            tmpxml.Add(height);
            tmpxml.Add(zChecked);
            tmpxml.Add(ucMonitorPreviewBoxMinimize);
            tmpxml.Add(ucucMonitorControlBoxMinimize);
            tmpxml.Add(ucFontSizeBoxMinimize);
            tmpxml.Add(ucCounterTypeChangerMinimize);
            tmpxml.Add(ucCounterMinimize);
            tmpxml.Add(ucTimeDirectionMinimize);
            tmpxml.Add(ucTimeSettingsMinimize);

            return tmpxml;
        }
    }
}
