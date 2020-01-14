using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// A complete Lazy way of realizing the Singleton pattern using <see cref="Lazy{T}"/> class.
    /// This is the cleanest and simplest way of realizing the pattern which is good performing, 
    /// as well as thread-safe.
    /// </summary>
    public sealed class President_FullLazyWithLazy
    {

        #region Class Members
        private static readonly Lazy<President_FullLazyWithLazy> m_LazyInstance = new Lazy<President_FullLazyWithLazy>( 
                                                                                        () => new President_FullLazyWithLazy() );
        #endregion

        #region Constructor
        private President_FullLazyWithLazy()
        {
        }
        #endregion

        #region Property
        public static President_FullLazyWithLazy Instance
        {
            get
            {
                return m_LazyInstance.Value;
            }
        }
        #endregion

    }
}
