using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// The concrete observer class that is interested to track 
    /// the stock price.
    /// </summary>
    public class FidelityObserver : IObserver
    {
        private Dictionary<string, IStock> m_StocksToWatch;

        public FidelityObserver()
        {
            m_StocksToWatch = new Dictionary<string, IStock>();
        }

        #region IObserver Implementation
        public void AddStock( IStock stock )
        {
            stock.AddObserver( this );
            m_StocksToWatch[stock.Symbol] = stock;
        }

        public void RemoveStock( IStock stock )
        {
            m_StocksToWatch.Remove( stock.Symbol );
            stock.RemoveObserver( this );
        }

        public void Update( string stockSymbol )
        {
            if ( m_StocksToWatch.ContainsKey( stockSymbol ) )
            {
                Console.WriteLine( "\tFidelity Observer=> Stock: " + stockSymbol + " is trading at : " + m_StocksToWatch[stockSymbol].Price );
            }
        }
        #endregion
    }
}
