using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// A basic thread-safe way of implementing the Singleton pattern.
    /// However, it is a bad performing way, because each access operation to 
    /// <see cref="President_ThreadSafeBadPerforming.Instance"/> will result in 
    /// performing unnecessary locking.
    /// </summary>
    public sealed class President_ThreadSafeBadPerforming
    {

        #region Class Members
        private static President_ThreadSafeBadPerforming m_Instance = null;
        private static object m_Lock = new object();
        #endregion

        #region Property
        public static President_ThreadSafeBadPerforming Instance
        {
            get
            {
                lock ( m_Lock )
                {
                    if ( m_Instance == null )
                    {
                        m_Instance = new President_ThreadSafeBadPerforming();
                    }
                    return m_Instance;
                }
            }
        }
        #endregion

        #region Constructor
        private President_ThreadSafeBadPerforming()
        {
        }
        #endregion
    }
}
