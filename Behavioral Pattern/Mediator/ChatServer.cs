using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// The mediator hub of the communication between two communicators. 
    /// </summary>
    public class ChatServer
    {
        private HashSet<ChatParticipant> m_RegisteredUsers = new HashSet<ChatParticipant>();

        public void Send( ChatParticipant sender, ChatParticipant target, string message )
        {
            if ( !m_RegisteredUsers.Contains( sender ) || !m_RegisteredUsers.Contains( target ) )
            {
                Console.WriteLine( string.Format( "\tChat Server => Sender {0} and/or Receiver {1} is not part of Chat system yet. Cannot send message. ", sender.Name, target.Name ) );
                return;
            }
            Console.WriteLine( "\tChat Server => Message received from " + sender.Name );
            Console.WriteLine( "\tChat Server => Delivering message to " + target.Name );
            target.ReceiveMessageFrom( sender.Name, message );
        }

        public void AddUser( ChatParticipant newUser )
        {
            m_RegisteredUsers.Add( newUser );
        }

        public void RemoveUser( ChatParticipant existingUser )
        {
            m_RegisteredUsers.Remove( existingUser );
        }
    }
}
