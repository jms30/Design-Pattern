using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class YouTubeDownloadService : IDownloadService
    {
        private Dictionary<int, string> m_VideoData = new Dictionary<int, string>();
        private Random m_Rng = new Random();

        public YouTubeDownloadService()
        {
            m_VideoData.Add( 1, "Baseball Match Highlights" );
            m_VideoData.Add( 2, "News Today" );
            m_VideoData.Add( 3, "Weather Today" );
            m_VideoData.Add( 4, "Hollywood Gossip" );
            m_VideoData.Add( 5, "Cool Technology video" );
        }

        public string DownloadVideo( int id )
        {
            if ( !m_VideoData.ContainsKey( id ) )
                return "\tThe Video does not exist.";
            var timeToDownload = m_Rng.Next( 2000, 10000 );
            Console.WriteLine( string.Format( "\tDownloading {0} from YouTube server. Will take around {1} seconds." , m_VideoData[id], timeToDownload/1000 ) );
            System.Threading.Thread.Sleep( timeToDownload );
            Console.WriteLine( "\tDownload Complete for " + m_VideoData[id] );
            return m_VideoData[id];
        }

        public List<int> GetVideoList()
        {
            return m_VideoData.Keys.ToList();
        }

        public string GetVideoTitle( int id )
        {
            if ( !m_VideoData.ContainsKey( id ) )
                return null;
            return m_VideoData[id];
        }
    }
}
