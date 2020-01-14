using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The final product(Kids Menu Plate) that is built by 
    /// <see cref="KidsMenuMcDonaldBuilder"/>.
    /// </summary>
    public class KidsPlateMcDonald
    {
        #region Properties
        public string Donut
        {
            get;
            set;
        } = "";

        public string SoftDrink
        {
            get;
            set;
        } = "";

        public string Fries
        {
            get;
            set;
        } = "";

        public string Toy
        {
            get;
            set;
        } = "";
        #endregion
    }
}
