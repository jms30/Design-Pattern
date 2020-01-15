using System;

namespace Mediator
{
    class Program
    {
        static void Main( string[] args )
        {
            ChatServer server = new ChatServer();
            ChatParticipant p1 = new ChatParticipant( "1", server );
            p1.Name = "P1";
            ChatParticipant p2 = new ChatParticipant( "2", server );
            p2.Name = "P2";
            ChatParticipant p3 = new ChatParticipant( "3", server );
            p3.Name = "P3";
            ChatParticipant p4 = new ChatParticipant( "4", server );
            p4.Name = "P4";
            ChatParticipant p5 = new ChatParticipant( "5", server );
            p5.Name = "P5";

            server.AddUser( p1 );
            server.AddUser( p2 );
            server.AddUser( p3 );
            server.AddUser( p4 );

            p1.SendMessageTo( p2, "Hey, What's up?" );
            p3.SendMessageTo( p2, "Hey, is Everything alright?" );

            p2.SendMessageTo( p4, "Hey, hope everything's going great." );
            p4.SendMessageTo( p2, "Absolutely. Hope the same with you too." );
            p2.SendMessageTo( p2, "Hi. Nothing Much. Just programming ;) " );
            p2.SendMessageTo( p2, "Yep. Everything's awesome when I'm programming :D " );

            p5.SendMessageTo( p2, "Hey, I wanna ask you whether you wanna do peer programming?" );
        }
    }
}
