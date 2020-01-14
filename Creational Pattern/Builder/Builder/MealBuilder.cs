using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// Interface that defines function to prepare Kids Menu at
    /// any given restaurants.
    /// </summary>
    public class MealBuilder
    {
        public virtual void PrepareBurger() { }

        public virtual void PrepareDrinks() { }

        public virtual void PrepareSandwiches() { }

        public virtual void PrepareDesserts() { }

        public virtual void PrepareSideDishes() { }

        public virtual void PrepareExtras() { }

        public virtual void Reset() { }

    }
}
