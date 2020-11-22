using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapereKindle.TranslationAPI
{
    public class TranslationService
    {
        private GoogleProvider _googleProvider = new GoogleProvider();
        private AzureProvider _azureProvider = new AzureProvider();
        public async Task<string[]> TranslateTextAsync(string text, string fromLang, string toLang, bool ignoreGoogle = false, bool ignoreAzure = false)
        {
            var translations = new string[2];
            if (!ignoreGoogle)
                translations[0] = await _googleProvider.TranslateTextAsync(text, fromLang, toLang).ConfigureAwait(false);
            if (!ignoreAzure)
                translations[1] = await _azureProvider.TranslateAzureAsync(text, fromLang, toLang).ConfigureAwait(false);
            return translations;
        }
    }
}
