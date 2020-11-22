using Newtonsoft.Json;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using SapereKindle.TranslationAPI;
using System.Threading.Tasks;

namespace SapereKindle.Dictionary
{
    public class DictionaryService
    {
        public TranslationDictionary GetTranslationDictionary(string fileName)
        {
            try
            {
                var json = File.ReadAllText(fileName);
                var dict = JsonConvert.DeserializeObject<TranslationDictionary>(json);
                return dict;
            } catch (Exception ex)
            {
                Console.WriteLine("GetTranslationDictionary error: " + ex.Message);
                return null;
            }
        }

        public List<TranslationDictionaryFile> GetAllDictionaries()
        {
            var path = Path.GetDirectoryName(Assembly.GetCallingAssembly().Location);
            path = $@"..\..\..\dictionaries";
            var files = Directory.GetFiles(path);
            var dictList = new List<TranslationDictionaryFile>();

            foreach(var file in files)
            {
                var dict = GetTranslationDictionary(file);
                if (dict != null)
                {
                    dictList.Add(new TranslationDictionaryFile
                    {
                        FileName = file,
                        Dictionary = dict
                    });
                }
            }
            return dictList;
        }

        public static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        public void SaveDictionary(string fileName, TranslationDictionary dict)
        {
            string output = JsonConvert.SerializeObject(dict);
            string prettyOutput = JsonPrettify(output);
            File.WriteAllText(fileName, prettyOutput);
        }

        private int ExistsTranslationItem(TranslationDictionary dict, string word)
        {
            int i = 0;
            foreach (var item in dict.Translations)
            {
                if (item.Word.Text.Equals(word))
                    return i;
                i++;
            }
            return -1;
        }

        public async Task<int> ImportAsync(string kindleMateFile, TranslationDictionaryFile dictFile)
        {
            var content = File.ReadAllLines(kindleMateFile);
            bool isWord = true;
            var word = "";
            int emptyLineNum = 0;
            TranslationItem translationItem = new TranslationItem();
            foreach (var line in content)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    isWord = true;
                    emptyLineNum++;
                    word = "";
                    if (emptyLineNum % 2 == 0)
                    {
                        var index = ExistsTranslationItem(dictFile.Dictionary, translationItem.Word.Text);
                        if (index == -1)
                            dictFile.Dictionary.Translations.Add(translationItem);
                        else
                        {
                            if (dictFile.Dictionary.Translations[index].Sentence.Text != translationItem.Sentence.Text)                            
                                dictFile.Dictionary.Translations[index] = translationItem;                            
                        }

                        isWord = true;
                    }
                    continue;
                }                    
                if (isWord)
                {
                    var startWord = line.IndexOf("(") + 1;
                    var endWord = line.IndexOf(")");
                    word = line[startWord..endWord];
                    translationItem = new TranslationItem
                    {
                        Word = new TranslationPair
                        {
                            Text = word
                        },
                        Sentence = new TranslationPair()
                        {
                            Text = ""
                        }
                    };
                    isWord = false;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(translationItem.Sentence.Text))
                        translationItem.Sentence.Text += Environment.NewLine;
                    translationItem.Sentence.Text += line.Trim();                    
                    word = "";
                }
            }

            var translationService = new TranslationService();
            
            var fromLang = dictFile.Dictionary.FromLang;
            var toLang = dictFile.Dictionary.ToLang;

            int changed = 0;
            foreach (var item in dictFile.Dictionary.Translations)
            {
                bool changedWord = false;
                if (item.Sentence.GoogleText == null || item.Sentence.AzureText == null)
                {
                    var sentenceTranslations = await translationService.TranslateTextAsync(item.Sentence.Text,
                        fromLang, toLang,
                        item.Sentence.GoogleText != null,
                        item.Sentence.AzureText != null
                       ).ConfigureAwait(false);
                    if (item.Sentence.GoogleText == null)
                        item.Sentence.GoogleText = sentenceTranslations[0];
                    if (item.Sentence.AzureText == null)
                        item.Sentence.AzureText = sentenceTranslations[1];
                    changedWord = true;
                }

                if (item.Word.GoogleText == null || item.Word.AzureText == null)
                {
                    var wordTranslations = await translationService.TranslateTextAsync(item.Word.Text,
                        fromLang, toLang,
                        item.Word.GoogleText != null,
                        item.Word.AzureText != null
                       ).ConfigureAwait(false);
                    if (item.Word.GoogleText == null)
                        item.Word.GoogleText = wordTranslations[0];
                    if (item.Word.AzureText == null)
                        item.Word.AzureText = wordTranslations[1];
                    changedWord = true;
                }
                if (changedWord)
                    changed++;
            }

            SaveDictionary(dictFile.FileName, dictFile.Dictionary);
            return changed;
        }
    }
}
