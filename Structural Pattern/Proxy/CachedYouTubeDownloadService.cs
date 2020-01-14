using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class CachedYouTubeDownloadService : IDownloadService
    {
        private Dictionary<int, string> m_CachedVideos = new Dictionary<int, string>();
        private YouTubeDownloadService m_YouTubeDownloadServiceObject = null;

        public CachedYouTubeDownloadService( YouTubeDownloadService youtubeDownloadService )
        {
            m_YouTubeDownloadServiceObject = youtubeDownloadService;
        }

        public string DownloadVideo( int id )
        {
            if (m_CachedVideos.ContainsKey(id))
            {
                Console.WriteLine( string.Format("\t{0} is already downloaded. Returning from the cache immediately.", m_CachedVideos[id] ) );
                return m_CachedVideos[id];
            }
            
            Console.WriteLine( string.Format( "\t{0} is not found in cache. Have to download from server. ", id ) );
            var explicitlyDownloadedData = m_YouTubeDownloadServiceObject.DownloadVideo( id );
            m_CachedVideos.Add( id, explicitlyDownloadedData );
            return explicitlyDownloadedData;
        }

        public List<int> GetVideoList()
        {
            return m_YouTubeDownloadServiceObject.GetVideoList();
        }

        public string GetVideoTitle( int id )
        {
            if ( m_CachedVideos.ContainsKey( id ) )
                return m_CachedVideos[id];
            return m_YouTubeDownloadServiceObject.GetVideoTitle( id );
        }
    }
}
