using AngleSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SapereKindle
{
    public class WordReferenceUtil
    {
        public static async Task<List<WordReferenceItem>> GetAsync(string word)
        {
            var url = $"http://wordreference.com/iten/{word}";
            var context = BrowsingContext.New(Configuration.Default);
            //Generate HTML DOM for the following source code            
            var list = new List<WordReferenceItem>();
            using (var client = new HttpClient())
            {

                //var productValue = new ProductInfoHeaderValue("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/56.0.2924.87 Safari/537.36");
                //httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; AcmeInc/1.0)");
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64)");
                client.DefaultRequestHeaders.UserAgent.ParseAdd("AppleWebKit/537.36 (KHTML, like Gecko)");
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Chrome/56.0.2924.87");
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Safari/537.36");

                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                var htmlContent = await response.Content.ReadAsStringAsync();
                var document = await context.OpenAsync(req => req.Content(htmlContent));
                var mainTable = document.All.FirstOrDefault(row => row.ClassName == "WRD");
                var rows = mainTable.Children.Where(row => row.ClassName.Equals("even")).ToList();
                var wordElem = rows[0].Children.FirstOrDefault(row => row.ClassName.Equals("FrWd"));
                var italianWord = wordElem.Children[0].InnerHtml;
                var itSentencesElem = mainTable.Children.Where(row => row.ClassName.Equals("FrEx")).ToList();
                var enSentencesElem = mainTable.Children.Where(row => row.ClassName.Equals("ToEx")).ToList();
                var wordItem = new WordReferenceItem();
                wordItem.Word = italianWord;
                for (int i = 0; i < itSentencesElem.Count(); i++)
                {
                    wordItem.ItalianSentence = itSentencesElem[i].Children[0].InnerHtml;
                    if (enSentencesElem.Count > i)
                        wordItem.EnglishSentence = enSentencesElem[i].Children[0].InnerHtml;
                    else
                        wordItem.EnglishSentence = "";
                }
                list.Add(wordItem);
                /*var contentDiv = document.All.FirstOrDefault(row => row.ClassName == "sct-descr");

                var mode = Mode.None;
                foreach (var elem in contentDiv.Children)
                {
                    if (elem.InnerHtml.Equals("Sinonimi"))
                    {
                        mode = Mode.Synonymus;
                        continue;
                    }

                    if (elem.InnerHtml.Equals("Contrari"))
                    {
                        mode = Mode.Antonyms;
                        continue;
                    }

                    var list = elem.Children.Where(row => row.LocalName.Equals("b"));
                    foreach (var item in list)
                    {
                        var aElement = item.Children.FirstOrDefault(row => row.LocalName.Equals("a"));
                        if (aElement != null)
                        {
                            if (mode == Mode.Synonymus)
                                sa.Synonyms.Add(aElement.InnerHtml);
                            if (mode == Mode.Antonyms)
                                sa.Antonyms.Add(aElement.InnerHtml);
                        }
                    }
                } */
            }
            return list;
        }
    }
}
