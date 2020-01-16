using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AmazonStock amazon = new AmazonStock( "Amazon", "AMZN" );
            amazon.Price = 20.5; // No one will be notified.

            FidelityObserver fidelity = new FidelityObserver();
            fidelity.AddStock( amazon );

            amazon.Price = 2000.1; // Fidelity will be notified.
            amazon.Price = 2015.3; // Fidelity will be notified.

            fidelity.RemoveStock( amazon );

            amazon.Price = 1989.8; // Fidelity will not be notified because it is not subscribed anymore.
        }
    }
}
