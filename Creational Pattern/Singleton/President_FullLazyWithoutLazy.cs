using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// A lazy way of realizing Singleton pattern.
    /// This implementation can be simplified by using .NET's 
    /// support for lazy initialization using <see cref="Lazy{T}"/> class.
    /// </summary>
    public sealed class President_FullLazyWithoutLazy
    {

        #region Property
        public static President_FullLazyWithoutLazy Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        #endregion

        #region Constructor
        private President_FullLazyWithoutLazy()
        {
        }
        #endregion

        #region Nested Class for Instance creation
        private class Nested
        {

            static Nested()
            {
            }

            internal readonly static President_FullLazyWithoutLazy instance = new President_FullLazyWithoutLazy();
        }
        #endregion


    }
}
