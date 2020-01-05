using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
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
