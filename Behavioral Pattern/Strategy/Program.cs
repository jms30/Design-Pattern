using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            TripPlanner googleMaps = new TripPlanner();

            string start = "San Francisco";
            string dest = "New Delhi";

            AirTransportation flightmode = new AirTransportation();
            googleMaps.SetTransportationMode( flightmode );
            googleMaps.SetTripLocations( "SFO", "DEL" );
            var cost = googleMaps.CalculateTripExpenses();
            Console.WriteLine( "Flying from "+ start + "(" + flightmode.SourceAirport + ")" + 
                " to "+ dest + "(" + flightmode.DestinationAirport  + ")." );
            Console.WriteLine( "\tFlight is operated by " + flightmode.Operator + " and code is " + flightmode.FlightCode + "." );
            Console.WriteLine( "\tFlight will take around " + flightmode.CalculateDuration().Hours + " hours." );
            Console.WriteLine( "\tAnd it costs " + cost.ToString( "f2" ) + " USD.\n" );

            start = "Berlin";
            dest = "Munich";
            RailTransportation railmode = new RailTransportation();
            googleMaps.SetTransportationMode( railmode );
            googleMaps.SetTripLocations( "BER", "MUC" );
            cost = googleMaps.CalculateTripExpenses();
            Console.WriteLine( "Travelling from " + start + "(" + railmode.SourceStation + ")" +
                " to " + dest + "(" + railmode.DestinationStation + ").");
            Console.WriteLine( "\tTrain is operated by " + railmode.Operator + " and train number is " + railmode.TrainID + "." );
            Console.WriteLine( "\tTrain will take around " + railmode.CalculateDuration().Hours + " hours." );
            Console.WriteLine( "\tAnd it costs " + cost + " USD.\n" );

            start = "North York";
            dest = "Brampton";
            CarTransportation carmode = new CarTransportation();
            googleMaps.SetTransportationMode( carmode );
            googleMaps.SetTripLocations( start, dest );
            cost = googleMaps.CalculateTripExpenses();
            Console.WriteLine( "Cab booked for ride between " + carmode.PickUpFrom + " and " + carmode.DropOffAt + ".");
            Console.WriteLine( "\tCab is operated by " + carmode.ServiceProvider + " and number plate is " + carmode.NumberPlate + "." );
            Console.WriteLine( "\tCab will take around " + carmode.CalculateDuration().Minutes + " minutes." );
            Console.WriteLine( "\tAnd it costs " + cost + " USD.\n" );

            start = "Aying";
            dest = "Perlacher Forest";
            BicycleTransportation bikemode = new BicycleTransportation();
            googleMaps.SetTransportationMode( bikemode );
            googleMaps.SetTripLocations( start, dest );
            cost = googleMaps.CalculateTripExpenses();
            Console.WriteLine( "Riding bike from " + bikemode.SourcePoint + " to " + bikemode.DestinationPoint + "." );
            Console.WriteLine( "\tThe ride will take around " + bikemode.CalculateDuration().Hours + " hours." );
            Console.WriteLine( "\tAnd it costs " + cost + " USD." );
        }
    }
}
