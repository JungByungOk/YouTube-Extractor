using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeExtractor
{
    public class Extractor
    {
        private GetYouTubeDate GetData = new GetYouTubeDate();
        private Fixer Fix = new Fixer();
        private JObject JsonData;
        public async Task<bool> GetVideoAsync(WebClient Client, string URL)
        {
            try
            {
                string HtmlCode = await GetData.GetHtmlSourceAsync(Client, URL);
                JObject JsonCode = GetData.GetJson(HtmlCode);
                JsonData = Fix.FixJson(JsonCode);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public VideoInfo GetVideoInfo()
        {
            VideoInfo Info = new VideoInfo();

            JToken Datas = JsonData["args"]["player_response"]["videoDetails"];
            Info.Title = Datas["title"].ToString();
            Info.VideoID = Datas["videoId"].ToString();
            Info.Channel = Datas["author"].ToString();
            Info.View = Datas["viewCount"].ToString();

            return Info;
        }

        public List<VideoURL> GetVideoURL()
        {
            List<VideoURL> VideoUrlList = new List<VideoURL>();

            JToken Formats = JsonData["args"]["player_response"]["streamingData"]["formats"];

            foreach(JToken i in Formats)
            {
                VideoURL URLInfo = new VideoURL();

                URLInfo.QualityLabel = i["qualityLabel"].ToString();
                URLInfo.Quality = i["quality"].ToString();
                URLInfo.URL = Fix.FixURL(i["url"]);

                VideoUrlList.Add(URLInfo);
            }

            return VideoUrlList;

        }


    }
}
