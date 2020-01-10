using System;

namespace Adapter
{
    class Program
    {
        static void Main( string[] args )
        {
            double[] analogSignalData = new double[] { 1.3f, 3.8f, 0.7f, 0.9f, 8.2f };
            byte[] equivalentDigitalSignalData = new byte[] { 1, 1, 0, 0, 1 };
            byte[] digitalSignalData = new byte[] { 1, 0, 0, 1, 0 };
            
            Console.WriteLine("Analog Signal Data");
            AnalogSignal analogSignal = new AnalogSignal();
            analogSignal.SetAnalogSignalData( analogSignalData );
            analogSignal.PrintAnalogSignalData();

            Console.WriteLine( "\n\nDigital Signal Data" );
            DigitalSignal digitalSignal = new DigitalSignal();
            digitalSignal.SetDigitalSignalData( digitalSignalData );
            digitalSignal.PrintDigitalSignalData();

            Console.WriteLine( "\n\nInvoking Adapter to convert Analog signal data into Digital signal data." );
            AnalogToDigitalAdapter adapter = new AnalogToDigitalAdapter( 1.0f );
            adapter.SetAnalogSignal( new AnalogSignal() );
            adapter.SetAnalogSignalData( analogSignalData );
            var adaptedSignalData = adapter.GetDigitalSignalData();
            adapter.PrintDigitalSignalData();

            bool isEqual = true;
            for ( int i = 0; i < adaptedSignalData.Length; ++i )
                if ( adaptedSignalData[i] != equivalentDigitalSignalData[i] )
                {
                    isEqual = false;
                    break;
                }
            if ( isEqual == true )
                Console.WriteLine("\nConversion successful.");
            else
                Console.WriteLine("\nConversion failed.");
        }
    }
}
