using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCounter.CounterClasses
{
    public class GlobalSettings : ISCXML
    {
        public bool RagadosAblak { get; set; }
        public int LeptekBetumeretValtoztatashoz { get; set; }
        public bool UCMonitorPreviewBoxAutostrtVideo { get; set; }

        public GlobalSettings()
        {
            ////Főablak beállításai

#if DEBUG
            // a főablak a képernyő széléhez közeledve egy bizonyos távolságról odaugrik a képernyő széléhez
            RagadosAblak = false;
#else
            RagadosAblak = true;
#endif


            ////UCFontSizeBox beállításai

            // a gobokra kattintva ennyivel növeli vagy csökkenti a betűméretet
            LeptekBetumeretValtoztatashoz = 4;

            // UCMonitorPreviewBox-on a program indulásakor egyből legyen monitorkép, ne gombnyomásra induljon
#if DEBUG
            UCMonitorPreviewBoxAutostrtVideo = false;
#else
            UCMonitorPreviewBoxAutostrtVideo = false;
#endif


        }

        public System.Xml.Linq.XElement ToXML()
        {
            throw new NotImplementedException();
        }
    }
}
