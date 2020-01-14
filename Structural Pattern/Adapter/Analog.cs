using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Abstract class for Analog signal. 
    /// It declares common abstract methods for children classes.
    /// </summary>
    public abstract class Analog
    {
        public abstract double[] GetAnalogSignalData();

        public abstract void SetAnalogSignalData( double[] data );

        public abstract void PrintAnalogSignalData();
    }
}
