using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Object_Pool
{
	/// <summary>
	/// Test Object pool pattern with tasks.
	/// </summary>
	class Program
	{
		static void Main( string[] args )
		{

			TruckPool instance = TruckPool.Instance;
			// Infinite loop to test object-pool pattern.
			while ( true )
			{
				Random rnd = new Random();
				var nextDelay = rnd.Next( 0, 500 );
				var data = -1;
				Task t = Task.Factory.StartNew( async () =>
							{
								await Task.Delay( nextDelay );
								data = instance.GetTruck();
								return data;
							})
							.ContinueWith( ( t, data ) =>
							{
								//await Task.Delay(rnd.Next(100, 350));
								int item = t.Result.Result;
								Console.WriteLine( "Returning truck number : " + item );
								instance.ReturnTruck( item );
							}, TaskContinuationOptions.OnlyOnRanToCompletion );
			}


		}
	}


}