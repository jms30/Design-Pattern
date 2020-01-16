using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// Interface for a stock observer to implement
    /// </summary>
    public interface IObserver
    {
        void Update( string stockSymbol );

        void AddStock( IStock stock );

        void RemoveStock( IStock stock );
    }
}
