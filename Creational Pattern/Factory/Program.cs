using System;

namespace Factory
{
    class Program
    {
        static void Main( string[] args )
        {

            while ( true )
            {
                Console.WriteLine( "Press 1 for Road transport" );
                Console.WriteLine( "Press 2 for Sea transport" );
                Console.WriteLine( "Press anything else to leave." );
                
                Logistics logistics = null;
                string choice = Console.ReadLine();

                switch ( choice )
                {
                    case "1":
                        logistics = new RoadLogistics();
                        break;
                    case "2":
                        logistics = new SeaLogistics();
                        break;
                    default:
                        return;
                }

                string[] goods1 = new string[] { "Food", "Drinks", "Clothes" };
                string[] goods2 = new string[] { "Computers", "Laptods", "Phones" };

                // create vehicle
                TransportVehicle vehicleToUse1 = logistics.GetFreeVehicle();
                vehicleToUse1.DestinationPoint = "New York";
                TransportVehicle vehicleToUse2 = logistics.GetFreeVehicle();
                vehicleToUse2.DestinationPoint = "San Francisco";

                // deliver goods
                vehicleToUse1.DeliverGoods( goods1 );
                vehicleToUse2.DeliverGoods( goods2 );
            }
        }
    }
}
