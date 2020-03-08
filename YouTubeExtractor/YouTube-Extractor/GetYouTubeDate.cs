using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YouTubeExtractor
{
    class GetYouTubeDate
    {
        public async Task<string> GetHtmlSourceAsync(WebClient Client, string URL)
        {
            try
            {
                string HtmlCode = await Client.DownloadStringTaskAsync(URL);
                return HtmlCode;
            }
            catch
            {
                return string.Empty;
            }
        }

        public JObject GetJson(string HtmlCode)
        {
            try
            {
                Regex RegexData = new Regex(@"ytplayer\.config\s*=\s*(\{.+?\});", RegexOptions.Multiline);
                string ExtractedJson = RegexData.Match(HtmlCode).Result("$1");
                return JObject.Parse(ExtractedJson);
            }
            catch
            {
                return null;
            }
        }



    }
}
