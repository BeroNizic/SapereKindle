using System;
using System.Collections.Generic;
using System.Text;

namespace SapereKindle
{
    public class TranslationDictionary
    {
        public string Name { get; set; }
        public string FromLang { get; set; }
        public string ToLang { get; set; }
        public List<TranslationItem> Translations { get; set; }
    }
}
