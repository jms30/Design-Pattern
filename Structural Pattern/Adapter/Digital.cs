using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public abstract class Digital
    {
        public abstract byte[] GetDigitalSignalData();

        public abstract void SetDigitalSignalData( byte[] data );

        public abstract void PrintDigitalSignalData();
    }
}
