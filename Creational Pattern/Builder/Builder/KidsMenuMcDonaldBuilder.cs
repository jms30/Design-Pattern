using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class KidsMenuMcDonaldBuilder : MealBuilder
    {
        private KidsPlateMcDonald m_Plate = new KidsPlateMcDonald();

        #region Public Override Methods
        public override void Reset()
        {
            m_Plate = new KidsPlateMcDonald();
        }

        public override void PrepareDesserts()
        {
            m_Plate.Donut = "Strawberry flavored";
        }

        public override void PrepareDrinks()
        {
            m_Plate.SoftDrink = "Pepsi";
        }

        public override void PrepareSideDishes()
        {
            m_Plate.Fries = "French";
        }

        public override void PrepareExtras()
        {
            m_Plate.Toy = "Captain America";
        }

        public KidsPlateMcDonald GetPreparedPlate()
        {
            return m_Plate;
        }
        #endregion
    }

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
