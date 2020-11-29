using AngleSharp;
using AngleSharp.Html.Parser;
using AngleSharp.Dom;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SapereKindle
{
    public class SynonymsAntonymsUtil
    {
        enum Mode { None, Synonymus, Antonyms }

        public static async Task<SynonymsAntonyms> GetAsync(string word)
        {            
            var url = $"https://sapere.virgilio.it/parole/sinonimi-e-contrari/{word}";
            var sa = new SynonymsAntonyms
            {
                Word = word
            };

            var context = BrowsingContext.New(Configuration.Default);
            //Generate HTML DOM for the following source code            

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
                var htmlContent = await response.Content.ReadAsStringAsync();
                var document = await context.OpenAsync(req => req.Content(htmlContent));
                var contentDiv = document.All.FirstOrDefault(row => row.ClassName == "sct-descr");

                var mode = Mode.None;
                foreach (var elem in contentDiv.Children) {
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
                    foreach(var item in list)
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
                }
            }
            return sa;
        }
    }
}
