using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// A class that hosts TV functionality.
    /// (i.e. Different TV channels to play on screen, play loudly or gently)
    /// </summary>
    public class TV : IImplementation
    {
        private int m_CurrentChannelNumber = 0;

        private int m_CurrentVolume = 0;

        private bool m_IsActive = false;

        public TV()
        {
            m_IsActive = true;
        }

        public void Disable()
        {
            m_IsActive = false;
        }

        public void Enable()
        {
            m_IsActive = true;
        }

        public int GetChannel()
        {
            return m_CurrentChannelNumber;
        }

        public int GetVolume()
        {
            return m_CurrentVolume;
        }

        public void SetChannel( int newChannelNumber )
        {
            m_CurrentChannelNumber = newChannelNumber;
        }

        public void SetVolume( int newVolumeLevel )
        {
            m_CurrentVolume = newVolumeLevel;
        }

        public bool IsEnabled()
        {
            return m_IsActive;
        }
    }
}
