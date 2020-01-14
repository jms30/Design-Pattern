using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    /// <summary>
    /// Concrete Implementor of <see cref="Analog"/> abstract class. 
    /// </summary>
    public class AnalogSignal : Analog
    {
        private double[] m_SignalData = null;

        #region Interface Implementation
        public override double[] GetAnalogSignalData()
        {
            return m_SignalData;
        }

        public override void SetAnalogSignalData( double[] data )
        {
            m_SignalData = data;
        }

        public override void PrintAnalogSignalData()
        {
            foreach ( var data in m_SignalData )
                Console.Write( "\t" + string.Format( "{0:0.##}", data ) );
        }
        #endregion
    }
}
