using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The final product(Kids Menu Plate) that is built by 
    /// <see cref="KidsMenuBurgerKingBuilder"/>.
    /// </summary>
    public class KidsPlateBurgerKing
    {
        #region Properties
        public string Burger
        {
            get;
            set;
        } = "";

        public string Drinks
        {
            get;
            set;
        } = "";

        public string Sundae
        {
            get;
            set;
        } = "";

        public string Tickets
        {
            get;
            set;
        } = "";
        #endregion
    }
}
