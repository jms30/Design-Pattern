using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    /// <summary>
    /// A more advanced version of the base class <see cref="BasicRemote"/>.
    /// It offers couple of more functionality in addition to the base class. 
    /// </summary>
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
