using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{

    public interface IImplementation
    {

        bool IsEnabled();

        void Enable();

        void Disable();

        int GetVolume();

        void SetVolume( int newVolumeLevel );

        int GetChannel();

        void SetChannel( int newChannelNumber );
    }

    public class TVImplementor : IImplementation
    {
        private int m_CurrentChannelNumber = 0;

        private int m_CurrentVolume = 0;

        private bool m_IsActive = false;

        public TVImplementor()
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

        public void SetChannel(int newChannelNumber)
        {
            m_CurrentChannelNumber = newChannelNumber;
        }

        public void SetVolume(int newVolumeLevel)
        {
            m_CurrentVolume = newVolumeLevel;
        }

        public bool IsEnabled()
        {
            return m_IsActive;
        }
    }

    public class RadioImplementor : IImplementation
    {
        private bool m_IsActive = false;

        private int m_CurrentChannelNumber = 0;

        private int m_CurrentVolume = 0;

        public RadioImplementor()
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

        public void SetChannel(int newChannelNumber)
        {
            m_CurrentChannelNumber = newChannelNumber;
        }

        public void SetVolume(int newVolumeLevel)
        {
            m_CurrentVolume = newVolumeLevel;
        }
    }
}
