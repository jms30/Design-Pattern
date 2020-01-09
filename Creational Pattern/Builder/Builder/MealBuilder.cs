using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class MealBuilder
    {
        public virtual void PrepareBurgrer() { }

        public virtual void PrepareDrinks() { }

        public virtual void PrepareSandwiches() { }

        public virtual void PrepareDesserts() { }

        public virtual void PrepareSideDishes() { }

        public virtual void PrepareExtras() { }

        public virtual void Reset() { }

    }
}
