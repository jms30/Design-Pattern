﻿using System;
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

    public class DigitalSignal : Digital
    {
        private byte[] m_SignalData = null;

        #region Interface Implementation
        public override byte[] GetDigitalSignalData()
        {
            return m_SignalData;
        }

        public override void SetDigitalSignalData( byte[] data )
        {
            m_SignalData = data;
        }

        public override void PrintDigitalSignalData()
        {
            foreach ( var data in m_SignalData )
                Console.Write( "\t" + data.ToString() );
        }
        #endregion
    }
}