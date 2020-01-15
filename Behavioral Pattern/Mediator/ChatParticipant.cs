using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>
    /// The communicator class that wants to send/receive messages to/from other participants.
    /// </summary>
    public class ChatParticipant
    {
        private ChatServer m_Mediator = null;

        public string Name
        {
            get;
            set;
        } = "";

        public string UserId
        {
            get;
            private set;
        }

        public ChatParticipant( string id, ChatServer server )
        {
            UserId = id;
            m_Mediator = server;
        }

        public void SendMessageTo( ChatParticipant receiver, string message )
        {
            Console.WriteLine( Name + " => " + message );
            Console.WriteLine( Name + " => Sending a message to : " + receiver.Name );
            m_Mediator.Send( this, receiver, message );
        }

        public void ReceiveMessageFrom( string senderName, string message ) 
        {
            Console.Write( Name + " => A message received from " + senderName + ". Message : " );
            Console.WriteLine( message );
        }

        public override int GetHashCode()
        {
            return UserId.GetHashCode();
        }

    }
}
