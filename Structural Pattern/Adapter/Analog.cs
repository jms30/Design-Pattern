using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public abstract class Analog
    {
        public abstract double[] GetAnalogSignalData();

        public abstract void SetAnalogSignalData( double[] data );

        public abstract void PrintAnalogSignalData();
    }
}
