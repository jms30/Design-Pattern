using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// A thread-safe implementation of Singleton pattern using Static constructors.
    /// The fact that the static constructor is only called once and at the first time when
    /// the type <see cref=" President_SimpleStaticConstructor"/> is referred/accessed by the
    /// compiler, it will nullify the problems with multiple threads and synchronization.
    /// </summary>
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
