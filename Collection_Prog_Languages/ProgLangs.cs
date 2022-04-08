using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Prog_Languages
{
    class ProgLangs
    {
        public string LangName { get; set; }
        public DateTime TimeOfLangName { get; set; }
        public ProgLangs(string langName, DateTime timeOfLangName)
        {
            LangName = langName;
            TimeOfLangName = timeOfLangName;
        }
    }
}
