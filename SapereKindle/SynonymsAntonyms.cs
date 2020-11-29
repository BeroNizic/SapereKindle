using System;
using System.Collections.Generic;
using System.Text;

namespace SapereKindle
{
    public class SynonymsAntonyms
    {
        public string Word { get; set; }
        public List<string> Synonyms { get; set; } = new List<string>();
        public List<string> Antonyms { get; set; } = new List<string>();
    }
}
