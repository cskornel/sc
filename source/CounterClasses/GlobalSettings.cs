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


        public GlobalSettings()
        {
            ////Főablak beállításai

            //a főablak a képernyő széléhez közeledve egy bizonyos távolságról odaugrik a képernyő széléhez
            RagadosAblak = true;


            ////UCFontSizeBox beállításai

            //a gobokra kattintva ennyivel növeli vagy csökkenti a betűméretet
            LeptekBetumeretValtoztatashoz = 4;

        }

        public System.Xml.Linq.XElement ToXML()
        {
            throw new NotImplementedException();
        }
    }
}
