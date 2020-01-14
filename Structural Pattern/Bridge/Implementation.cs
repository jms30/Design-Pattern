using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// An interface for concrete Implementors (i.e. Devices).
    /// </summary>
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
}
