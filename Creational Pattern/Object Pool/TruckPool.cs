using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Object_Pool
{
	/// <summary>
	/// A Resource pool for Trucks. Implements Object-pool pattern. 
	/// There can only be one instance of this class. To ensure this, it internally implements singleton pattern. 
	/// </summary>
	public sealed class TruckPool
	{

		#region members
		private static readonly Lazy<TruckPool> m_LazyInstance = new Lazy<TruckPool>( () => new TruckPool() );
		private ConcurrentQueue<int> m_AvailableTrucks = new ConcurrentQueue<int>();
		private ConcurrentDictionary<int, int> m_OccupiedTrucks = new ConcurrentDictionary<int, int>();
		private int m_CurrentTruckId = 0;
		private object m_Lock = new object();
		#endregion

		#region Constructor
		private TruckPool()
		{
		}
		#endregion

		#region Properties
		public static TruckPool Instance
		{
			get
			{
				return m_LazyInstance.Value;
			}
		}
		#endregion

		#region Public Methods to acquire/return Trucks

		/// <summary>
		/// The Acquire function to get a truck.
		/// It reuses already created truck object. In case there are no objects available to be reused,
		/// it creates a new truck object on-the-fly and returns.
		/// </summary>
		/// <returns>A truck object</returns>
		public int GetTruck()
		{
			if ( m_AvailableTrucks.IsEmpty )
			{
				lock ( m_Lock )
				{
					var temp = m_CurrentTruckId;
					m_OccupiedTrucks.TryAdd( temp, temp );
					Console.WriteLine( "ThreadID: " + System.Threading.Thread.CurrentThread.ManagedThreadId + " - Created truck: " + temp );
					++m_CurrentTruckId;
					return temp;
				}
			}
			int output;
			m_AvailableTrucks.TryDequeue( out output );
			m_OccupiedTrucks.TryAdd( output, output );
			Console.WriteLine( "ThreadID: " + System.Threading.Thread.CurrentThread.ManagedThreadId + " - Reused truck: " + output );
			return output;
		}

		/// <summary>
		/// A Release function to return a truck after useage.
		/// </summary>
		/// <param name="id">A Truck to return</param>
		public void ReturnTruck( int id )
		{
			if ( !m_OccupiedTrucks.ContainsKey( id ) )
				return;
			m_AvailableTrucks.Enqueue( m_OccupiedTrucks[id] );
			int returned;
			m_OccupiedTrucks.TryRemove( id, out returned );
			Console.WriteLine( "ThreadID: " + System.Threading.Thread.CurrentThread.ManagedThreadId + " - Returned truck: " + returned );
		}
		#endregion
	}
}
