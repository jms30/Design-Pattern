using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class President_SimpleNonThreadSafe
    {
        #region Class members
        private static President_SimpleNonThreadSafe m_Instance = null;
        #endregion

        #region Property
        public static President_SimpleNonThreadSafe Instance
        {
            get
            {
                if ( m_Instance == null )
                {
                    m_Instance = new President_SimpleNonThreadSafe();
                }
                return m_Instance;
            }
        }
        #endregion

        #region Constructor
        private President_SimpleNonThreadSafe()
        {
        }
        #endregion
    }
}
