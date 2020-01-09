using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class KidsMenuBurgerKingBuilder : MealBuilder
    {
        private KidsPlateBurgerKing m_Plate = new KidsPlateBurgerKing();

        #region Public Override Methods
        public override void Reset()
        {
            m_Plate = new KidsPlateBurgerKing();
        }

        public override void PrepareDesserts()
        {
            m_Plate.Sundae = "Crunchy Caramel";
        }

        public override void PrepareDrinks()
        {
            m_Plate.Drinks = "Chocolate-Milk";
        }

        public override void PrepareBurgrer()
        {
            m_Plate.Burger = "Jr Chicken";
        }

        public override void PrepareExtras()
        {
            m_Plate.Tickets = "Wonderland Rides";
        }

        public KidsPlateBurgerKing GetPreparedPlate()
        {
            return m_Plate;
        }
        #endregion
    }

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
