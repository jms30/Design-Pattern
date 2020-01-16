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
        private Dictionary<string, IStock> m_StocksToPrice;

        public FidelityObserver()
        {
            m_StocksToPrice = new Dictionary<string, IStock>();
        }

        #region IObserver Implementation
        public void AddStock( IStock stockSymbol )
        {
            stockSymbol.AddObserver( this );
            m_StocksToPrice[stockSymbol.Symbol] = stockSymbol;
        }

        public void RemoveStock( IStock stockSymbol )
        {
            m_StocksToPrice.Remove( stockSymbol.Symbol );
            stockSymbol.RemoveObserver( this );
        }

        public void Update( string stockSymbol )
        {
            if ( m_StocksToPrice.ContainsKey( stockSymbol ) )
            {
                Console.WriteLine( "\tFidelity Observer=> Stock: " + stockSymbol + " is trading at : " + m_StocksToPrice[stockSymbol].Price );
            }
        }
        #endregion
    }
}
