using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// The basic & concrete implementor of <see cref="IRemote"/> interface.
    /// This class is an Abstraction class that allows client to carry out
    /// their actions on the underlying, actual, concrete implementor to which 
    /// this class is bound to. 
    /// </summary>
    public class BasicRemote : IRemote
    {
        private IImplementation m_Implementer = null;

        protected IImplementation GetImplementation()
        {
            return m_Implementer;
        }

        public void SetImplementation( IImplementation concreteImplementer )
        {
            m_Implementer = concreteImplementer;
        }

        public void ToggleDevice()
        {
            if ( m_Implementer != null)
            {
                if ( m_Implementer.IsEnabled() )
                    m_Implementer.Disable();
                else
                    m_Implementer.Enable();
            }
        }

        public void DecreaseVolume()
        {
            if ( m_Implementer != null )
            {
                m_Implementer.SetVolume( m_Implementer.GetVolume() - 10 );
            }
        }

        public void DescreseChannel()
        {
            if ( m_Implementer != null )
            {
                m_Implementer.SetChannel( m_Implementer.GetChannel() - 1 );
            }
        }

        public void IncreaseChannel()
        {
            if ( m_Implementer != null )
            {
                m_Implementer.SetChannel( m_Implementer.GetChannel() + 1 );
            }
        }

        public void IncreaseVolume()
        {
            if ( m_Implementer != null )
            {
                m_Implementer.SetVolume( m_Implementer.GetVolume() + 10 );
            }
        }

    }
}
