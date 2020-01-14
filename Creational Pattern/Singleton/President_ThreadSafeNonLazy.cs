using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// A thread-safe and non-bad performing implementation of Singleton pattern.
    /// This one is fully useable implementation, however, has lot of code that can 
    /// be simplified with other ways.
    /// </summary>
    public sealed class President_ThreadSafeNonLazy
    {
        #region Class members
        private static President_ThreadSafeNonLazy m_Instance = null;
        private static object m_Lock = new object();
        #endregion

        #region Property
        public static President_ThreadSafeNonLazy Instance
        {
            get
            {
                if ( m_Instance == null )
                {
                    lock ( m_Lock )
                    {
                        if ( m_Instance == null )
                        {
                            m_Instance = new President_ThreadSafeNonLazy();
                        }
                    }
                }
                return m_Instance;
            }
        }
        #endregion

        #region Constructor
        private President_ThreadSafeNonLazy()
        {
        }
        #endregion
    }
}
