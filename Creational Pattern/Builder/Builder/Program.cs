using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            KidsMenuMcDonaldBuilder mcdonaldsBuilder = new KidsMenuMcDonaldBuilder();
            KidsMenuBurgerKingBuilder burgerkingBuilder = new KidsMenuBurgerKingBuilder();

            OrderManager manager = new OrderManager();
            manager.SetBuilder( mcdonaldsBuilder );
            manager.BuildPlate();
            var kidsPlate1 = mcdonaldsBuilder.GetPreparedPlate();
            Console.WriteLine( "\nMcDonald Kids Plate contains... " );
            Console.WriteLine( "\t" + kidsPlate1.Fries + " Fries" );
            Console.WriteLine( "\t" + kidsPlate1.SoftDrink + " Drink" );
            Console.WriteLine( "\t" + kidsPlate1.Donut + " Donut" );
            Console.WriteLine( "\t" + kidsPlate1.Toy + " Toy" );

            mcdonaldsBuilder.Reset();

            manager.SetBuilder( burgerkingBuilder );
            manager.BuildPlate();
            var kidsPlate2 = burgerkingBuilder.GetPreparedPlate();
            Console.WriteLine( "\nBurgerKing Kids Plate contains... " );
            Console.WriteLine( "\t" + kidsPlate2.Burger + " Burger" );
            Console.WriteLine( "\t" + kidsPlate2.Drinks + " Drink" );
            Console.WriteLine( "\t" + kidsPlate2.Sundae + " Sundae" );
            Console.WriteLine( "\t" + kidsPlate2.Tickets + " Tickets" );

            burgerkingBuilder.Reset();
        }
    }
}
