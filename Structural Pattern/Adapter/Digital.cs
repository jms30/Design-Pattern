using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Abstract class for Digital signal.
    /// It declares common abstract methods for children classes.
    /// </summary>
    public abstract class Digital
    {
        public abstract byte[] GetDigitalSignalData();

        public abstract void SetDigitalSignalData( byte[] data );

        public abstract void PrintDigitalSignalData();
    }
}
