using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeDownloadService youtube = new YouTubeDownloadService();
            CachedYouTubeDownloadService cache = new CachedYouTubeDownloadService( youtube );

            Console.WriteLine( "Lets see how many videos are there on the server" );
            Console.WriteLine( "\t: " + string.Join( ',', cache.GetVideoList() ) );
            Console.Write( "Lets see video 1. " );
            Console.WriteLine( "Title is : " + cache.GetVideoTitle( 1 ) );
            Console.WriteLine( "Now, let's download the highlights:" );
            Console.WriteLine( "Downloaded video title: " + cache.DownloadVideo( 1 ) );
            Console.Write( "\nLet's see what's the video 3. " );
            Console.WriteLine( "Title is : " + cache.GetVideoTitle( 3 ) );
            Console.WriteLine( "Oh, I need to go out tonight. Let me see the whole video to plan my evening accordingly. " );
            Console.WriteLine( "Downloaded video title: " + cache.DownloadVideo( 3 ) );
            Console.WriteLine( "\nMy friend asks me about Raptor's match. Let me show him/her how Raptors thrashed Lakers last night." );
            Console.WriteLine( "Downloaded video title: " + cache.DownloadVideo( 1 ) );
        }
    }
}
