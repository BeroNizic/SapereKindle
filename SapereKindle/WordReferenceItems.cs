using System.Collections.Generic;

namespace SapereKindle
{
    public class WRItem
    {
        public string Word { get; set; }
        public string InitialWord { get; set; }
        public bool Processed { get; set; }
        public int Position { get; set; }
        public string PronWR { get; set; }
        public string[] Audio { get; set; }
        public WRTranslationGroup[] Translations { get; set; }
    }

    public class WRTranslationGroup
    {
        public string Title { get; set; }
        public WRTranslationExamples[] Translations { get; set; }
    }

    public class WRTranslationExamples
    {
        public string From { get; set; }
        public string From2 { get; set; }
        public string FromType { get; set; }
        public string ToType { get; set; }
        public string To { get; set; }
        public bool Processed { get; set; }
        public WRExample Example { get; set; }
    }

    public class WRExample
    {
        public string[] From { get; set; }
        public List<string> FromGoogle { get; set; } = new List<string>();
        public List<string> FromAzure { get; set; } = new List<string>();
        public string[] To { get; set; }
        public List<string> ToGoogle { get; set; } = new List<string>();
        public List<string> ToAzure { get; set; } = new List<string>();
    }
}