using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SapereKindle
{
    public class WordReferenceItem
    {
        public string Word { get; set; }
        public string ItalianSentence { get; set; }
        public string EnglishSentence { get; set; }
    }
    
    public class Example
    {
        [JsonPropertyName("from")]
        public List<string> From { get; set; }

        [JsonPropertyName("to")]
        public List<string> To { get; set; }
    }

    public class Translation3
    {
        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("fromType")]
        public string FromType { get; set; }

        [JsonPropertyName("toType")]
        public string ToType { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("example")]
        public Example Example { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("translations")]
        public List<Translation> Translations { get; set; }
    }

    public class Translation
    {
        [JsonPropertyName("word")]
        public string Word { get; set; }

        [JsonPropertyName("pronWR")]
        public string PronWR { get; set; }

        [JsonPropertyName("audio")]
        public List<string> Audio { get; set; }

        [JsonPropertyName("translations")]
        public List<Translation> Translations { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("word")]
        public string Word { get; set; }

        [JsonPropertyName("translation")]
        public Translation Translation { get; set; }
    }

}
