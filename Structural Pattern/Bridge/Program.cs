using System;
using System.Collections.Generic;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TVImplementor tv = new TVImplementor();
            Dictionary<int, string> tvChannels = new Dictionary<int, string>() {
                                                        { 1, "HBO" },
                                                        { 2, "Disney" },
                                                        { 3, "Star World" },
                                                        { 4, "Discovery" },
                                                        { 5, "National Geographic" } };

            Dictionary<int, string> radioChannels = new Dictionary<int, string>() {
                                                        { 1, "Virgin Radio" },
                                                        { 2, "Radio City" },
                                                        { 3, "Toronto's Rock" },
                                                        { 4, "Toronto's Hip-Hop" },
                                                        { 5, "CHFI 98.1" } };

            AdvancedRemote advanceRemote = new AdvancedRemote();

            advanceRemote.SetImplementation( tv );

            Console.WriteLine( "An Advanced remote is set to control the TV. " );
            Console.WriteLine( "\tSetting a channel to 1" );
            advanceRemote.IncreaseChannel();
            Console.WriteLine( "\t The TV is broadcasting : " + tvChannels[tv.GetChannel()] );

            Console.WriteLine( "\tSetting a channel to 2" );
            advanceRemote.IncreaseChannel();
            Console.WriteLine( "\t The TV is broadcasting : " + tvChannels[tv.GetChannel()] );

            Console.WriteLine( "\tSetting a channel to 1 again because I liked that show better than current one." );
            advanceRemote.DescreseChannel();
            Console.WriteLine( "\t The TV is broadcasting : " + tvChannels[tv.GetChannel()] );

            Console.WriteLine( "\tIncreasing volume " );
            advanceRemote.IncreaseVolume();
            Console.WriteLine( "\t The TV volume is : " + tv.GetVolume() );

            Console.WriteLine( "\tIncreasing volume " );
            advanceRemote.IncreaseVolume();
            Console.WriteLine( "\t The TV volume is : " + tv.GetVolume() );

            Console.WriteLine( "\tDecresing volume because it's too loud. " );
            advanceRemote.DecreaseVolume();
            Console.WriteLine( "\t The TV volume is : " + tv.GetVolume() );

            Console.WriteLine( "\tGetting a call, has to mute the TV instantaneously." );
            advanceRemote.MuteDevice();
            Console.WriteLine( "\t The TV volume is : " + tv.GetVolume() );

            Console.WriteLine( "\tIt was my friend, telling me to watch Wild Cats on NatGeo. " );
            advanceRemote.JumpToSpecificChannel( 5 );
            Console.WriteLine( "\t The TV is broadcasting : " + tvChannels[tv.GetChannel()] );

            Console.WriteLine( "\nNow Enough with the TV. Let me hear some music instead. " );
            advanceRemote.ToggleDevice();
            Console.WriteLine( "\tTV is switched off??: " + !tv.IsEnabled() );



            BasicRemote basicRemote = new BasicRemote();
            RadioImplementor radio = new RadioImplementor();
            basicRemote.SetImplementation( radio );
            Console.WriteLine( "A Basic remote is set to control Radio. ");

            Console.WriteLine( "\tSetting a Radio channel to 1" );
            basicRemote.IncreaseChannel();
            Console.WriteLine( "\t The Radio is playing : " + radioChannels[radio.GetChannel()] );

            Console.WriteLine( "\tI like this song, playing it louder now." );
            basicRemote.IncreaseVolume();
            Console.WriteLine( "\t The Radio volume is : " + radio.GetVolume() );

            Console.WriteLine( "\nNow Enough with the Radio. I gotta go." );
            basicRemote.ToggleDevice();
            Console.WriteLine( "\tRadio is switched off??: " + !radio.IsEnabled() );
        }
    }
}
