namespace SocialMediaStreamToM3U.Processors
{
    public interface IYouTubeStreamProcessor
    {
        string GetPlaylistUrl(
            string channelId,
            string streamTitle);
    }
}
