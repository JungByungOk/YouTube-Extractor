using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeExtractor
{
    public class VideoInfo
    {
        string _VideoID;
        string _Title;
        string _Channel;
        string _View;

        public string VideoID
        {
            set
            {
                _VideoID = value;
            }
            get
            {
                return _VideoID;
            }
        }
        public string Title
        {
            set
            {
                _Title = value;
            }
            get
            {
                return _Title;
            }
        }
        public string Channel
        {
            set
            {
                _Channel = value;
            }
            get
            {
                return _Channel;
            }
        }
        public string View
        {
            set
            {
                _View = value;
            }
            get
            {
                return _View;
            }
        }
    }
}
