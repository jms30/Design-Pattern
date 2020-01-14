using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public interface IDownloadService
    {
        List<int> GetVideoList();

        string GetVideoTitle( int id );

        string DownloadVideo( int id );
    }
}
