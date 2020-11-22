using System;
using System.Collections.Generic;
using System.Text;
using Google.Cloud.Translation.V2;
using System.Threading.Tasks;

namespace SapereKindle
{
    public class GoogleProvider
    {
        public async Task<string> TranslateTextAsync(string text, string fromLang, string toLang)
        {
            TranslationClient client = TranslationClient.Create();
            var response = await client.TranslateTextAsync(
                text: text,
                targetLanguage: toLang,
                sourceLanguage: fromLang).ConfigureAwait(false);
            return response.TranslatedText;
        }
    }
}
