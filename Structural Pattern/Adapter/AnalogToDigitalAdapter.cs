using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AnalogToDigitalAdapter : Digital
    {
        private double m_Threshold = 1.0;
        byte[] m_CachedDigitalSignalData = null;
        AnalogSignal m_AnalogSignal = null;

        public AnalogToDigitalAdapter( double threshold )
        {
            m_Threshold = threshold;
        }

        public void SetAnalogSignal( AnalogSignal digitalSignal )
        {
            m_AnalogSignal = digitalSignal;
        }

        public override byte[] GetDigitalSignalData()
        {
            if ( m_CachedDigitalSignalData == null )
            {
                var analogSignalData = this.m_AnalogSignal.GetAnalogSignalData();
                m_CachedDigitalSignalData = new byte[analogSignalData.Length];
                for ( int i = 0; i < m_CachedDigitalSignalData.Length; ++i )
                {
                    m_CachedDigitalSignalData[i] = ( analogSignalData[i] > m_Threshold ) ? (byte) 1 : (byte) 0;
                }
            }
            return m_CachedDigitalSignalData;
        }

        public void SetAnalogSignalData( double[] analogdata )
        {
            InvalidateCache();
            this.m_AnalogSignal.SetAnalogSignalData( analogdata );
        }

        private void InvalidateCache()
        {
            m_CachedDigitalSignalData = null;
        }

        // Can't set the digital signal data directly. The purpose of
        // this class is to convert analog data to digital data. 
        public override void SetDigitalSignalData( byte[] data )
        {
            throw new NotImplementedException();
        }

        public override void PrintDigitalSignalData()
        {
            foreach ( var data in m_CachedDigitalSignalData )
                Console.Write( "\t" + data.ToString() );
        }
    }
}
