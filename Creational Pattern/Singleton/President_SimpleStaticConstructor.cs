using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class President_SimpleStaticConstructor
    {

        #region Property
        public static President_SimpleStaticConstructor Instance { 
            get;
        } = new President_SimpleStaticConstructor();
        #endregion

        #region Constructor
        static President_SimpleStaticConstructor()
        {
        }

        private President_SimpleStaticConstructor()
        {
        }
        #endregion
    }
}
