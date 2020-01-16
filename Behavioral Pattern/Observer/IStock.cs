using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// A stock interface that has a fluctuating price and 
    /// some functions to add/remove/notify observers.
    /// </summary>
    public interface IStock
    {
        string Name
        {
            get;
        }

        string Symbol
        {
            get;
        }

        double Price
        {
            get;
            set;
        }

        void NotifyObservers();

        void AddObserver( IObserver observer );

        void RemoveObserver( IObserver observer );
    }
}
