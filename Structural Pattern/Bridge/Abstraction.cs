using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public interface IRemote
    {
        void ToggleDevice();

        void IncreaseVolume();

        void DecreaseVolume();

        void IncreaseChannel();

        void DescreseChannel();

        void SetImplementation( IImplementation concreteImplementer );
    }

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
            if ( m_Implementer != null )
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
            if (m_Implementer != null)
            {
                m_Implementer.SetVolume( m_Implementer.GetVolume() + 10 );
            }
        }

    }

    public class AdvancedRemote : BasicRemote
    {
        public void MuteDevice()
        {
            var concreteImplementor = GetImplementation();
            if ( concreteImplementor != null )
                concreteImplementor.SetVolume( 0 );
        }

        public void JumpToSpecificChannel( int channelNumberToJumpTo )
        {
            var concreteImplementor = GetImplementation();
            if ( concreteImplementor != null )
                concreteImplementor.SetChannel( channelNumberToJumpTo );
        }
    }
}
