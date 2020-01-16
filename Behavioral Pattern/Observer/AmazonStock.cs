using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// The concrete stock class whose price will fluctuate depending upon 
    /// its demand. And accordingly, everytime it changes, it will notify
    /// the interested parties.
    /// </summary>
    public class AmazonStock : IStock
    {
        private HashSet<IObserver> m_RegisteredObserver;

        private double m_TradingPrice = 0.0;

        public string Name
        {
            get;
            private set;
        }

        public string Symbol
        {
            get;
            private set;
        }

        public double Price 
        {
            get 
            {
                return m_TradingPrice;
            }
            set
            {
                m_TradingPrice = value;
                NotifyObservers();
            }
        }

        public AmazonStock( string name, string symbol )
        {
            Name = name;
            Symbol = symbol;
            m_RegisteredObserver = new HashSet<IObserver>();
        }

        #region IStock implementation
        public void AddObserver( IObserver observer )
        {
            m_RegisteredObserver.Add( observer );
        }

        public void NotifyObservers()
        {
            Console.WriteLine(  Symbol + " price changed. Notifying observers." );
            foreach ( var observer in m_RegisteredObserver )
            {
                observer.Update( Symbol );
            }
        }

        public void RemoveObserver( IObserver observer )
        {
            m_RegisteredObserver.Remove( observer );
        }
        #endregion
    }
}
