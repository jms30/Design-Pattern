using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// A class that hosts Radio functionalities.
    /// (i.e. Different radio channels to tune to, play loudly or gently)
    /// </summary>
    public class Radio : IImplementation
    {
        private bool m_IsActive = false;

        private int m_CurrentChannelNumber = 0;

        private int m_CurrentVolume = 0;

        public Radio()
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

        public bool IsEnabled()
        {
            return m_IsActive;
        }

        public void SetChannel( int newChannelNumber )
        {
            m_CurrentChannelNumber = newChannelNumber;
        }

        public void SetVolume( int newVolumeLevel )
        {
            m_CurrentVolume = newVolumeLevel;
        }
    }
}
