using System;

namespace Singleton
{
    class Program
    {
        static void Main( string[] args )
        {
            President_SimpleNonThreadSafe president1 = President_SimpleNonThreadSafe.Instance;
            President_ThreadSafeBadPerforming president2 = President_ThreadSafeBadPerforming.Instance;
            President_ThreadSafeNonLazy president3 = President_ThreadSafeNonLazy.Instance;
            President_SimpleStaticConstructor president4 = President_SimpleStaticConstructor.Instance;
            President_FullLazyWithoutLazy president5 = President_FullLazyWithoutLazy.Instance;
            President_FullLazyWithLazy theRealPresidentToUse = President_FullLazyWithLazy.Instance;
        }
    }
}
