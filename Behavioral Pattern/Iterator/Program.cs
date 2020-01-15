using System;

namespace Iterator
{
    class Program
    {
        static void Main( string[] args )
        {
            NumberCollection collection = new NumberCollection();
            collection.AddItem( 5 );
            collection.AddItem( 15 );
            collection.AddItem( 25 );
            collection.AddItem( 35 );
            collection.AddItem( 45 );

            Console.WriteLine( "Invoking forward directional Iterator..." );
            foreach ( var item in collection )
                Console.Write( " -> " + item );

            collection.ReverseDirection();

            Console.WriteLine( "\nInvoking reverse directional Iterator..." );
            foreach ( var item in collection )
                Console.Write( " -> " + item );
        }
    }
}
