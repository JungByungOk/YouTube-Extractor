# YouTube-Extractor
This is a library for get inf and URLs from a YouTube video

# For load video
```c#
YouTubeExtractor.Extractor Extractor = new YouTubeExtractor.Extractor();

var MyClient = new WebClient();
MyClient.Encoding = Encoding.UTF8;

bool ExtractResult = await Extractor.GetVideoAsync(MyClient, "https://www.youtube.com/watch?v=yVLfEHXQk08");

```

# For load video with proxy
```c#
YouTubeExtractor.Extractor Extractor = new YouTubeExtractor.Extractor();

var MyClient = new WebClient();
MyClient.Proxy = new WebProxy("IP",0000);
MyClient.Encoding = Encoding.UTF8;

bool ExtractResult = await Extractor.GetVideoAsync(MyClient, "https://www.youtube.com/watch?v=yVLfEHXQk08");

```

# For get video info
```c#
if(ExtractResult)
{
YouTubeExtractor.VideoInfo videoInfo = new YouTubeExtractor.VideoInfo();
videoInfo = Extractor.GetVideoInfo();
Console.WriteLine("Title : " + videoInfo.Title); //Clash of Clans : Hog Rider 360°
Console.WriteLine("View : " + videoInfo.View); //67715767
Console.WriteLine("ID : " + videoInfo.VideoID); //yVLfEHXQk08
Console.WriteLine("Channel : " + videoInfo.Channel); //Clash of Clans
}

```

# For get video download link
```c#
if(ExtractResult)
{
foreach(YouTubeExtractor.VideoURL i in Extractor.GetVideoURL())
{
Console.WriteLine(i.QualityLabel); // 360p and 720p
Console.WriteLine(i.Quality); // medium and hd720
Console.WriteLine(i.URL); // https://r5---sn-ab5l6nzd.googlevideo.com/........
}
}
```
[My telegram username](https://t.me/Iam_vinak)

[Telegram channel](https://t.me/ModernSoftCompany)
