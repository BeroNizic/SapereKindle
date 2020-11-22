using System;
using System.Collections.Generic;
using System.Text;

namespace SapereKindle.Dictionary
{
    public class TranslationDictionaryFile
    {
        public TranslationDictionary Dictionary { get; set; }
        public string FileName { get; set; }

        public override string ToString()
        {
            return Dictionary.Name;
        }
    }
}
