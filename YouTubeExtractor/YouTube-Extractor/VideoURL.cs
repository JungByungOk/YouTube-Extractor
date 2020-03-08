using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeExtractor
{
    public class VideoURL
    {
        string _Quality;
        string _QualityLabel;
        string _URL;

        public string Quality
        {
            set
            {
                _Quality = value;
            }
            get
            {
                return _Quality;
            }
        }
        public string QualityLabel
        {
            set
            {
                _QualityLabel = value;
            }
            get
            {
                return _QualityLabel;
            }
        }
        public string URL
        {
            set
            {
                _URL = value;
            }
            get
            {
                return _URL;
            }
        }
    }
}
