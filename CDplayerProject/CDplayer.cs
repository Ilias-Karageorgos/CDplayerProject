using CDplayerProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDplayerProject
{
    internal class CDplayer
    {
        public CD Cd { get; set; }

        public bool Loaded { get; set; }

        public string PlayingNow { get; set; }

        public void InsertCD(CD cd)
        {
            if (Loaded)
            {
                Console.WriteLine("Cd is already inserted");
                return;
            }
            Console.WriteLine("Cd was inserted");
            Cd = cd;
            Loaded = true;
        }

        public void ShowStatusOfCDPlayer()
        {
            if (Loaded)
            {
                Console.WriteLine("Cd player loaded with cd, Press Play to listen");
                Cd.CdInfo();
            }
            else
            {
                Console.WriteLine("Please insert CD first");
            }
        }

        public void PlayFromStart()
        {
            if (!Loaded)
            {
                Console.WriteLine("Please insert CD first");
                return;
            }
            Console.WriteLine($"Playing {Cd.TrackList[0].Title}");
            PlayingNow = Cd.TrackList[0].Title;
        }

        public void StopPlaying()
        {
            if (!Loaded)
            {
                Console.WriteLine("Please insert CD first");
                return;
            }
            if (PlayingNow == null)
            {
                Console.WriteLine("Please press Start first");
                return;
            }

            Console.WriteLine("Stop playing");
            PlayingNow = null;
        }

        public void PlayNextSong()
        {
            if (!Loaded)
            {
                Console.WriteLine("Please insert CD first");
                return;
            }
            if (PlayingNow == null)
            {
                Console.WriteLine("Please press Start first");
            }
            else
            {
                int trackPlayingNowIndex = Cd.TrackList.FindIndex(track => track.Title == PlayingNow);
                if (trackPlayingNowIndex == Cd.TrackList.Count - 1)
                {
                    Console.WriteLine("This is the Last Song (there is no next song available)");
                }
                else
                {
                    int nextSongIndex = trackPlayingNowIndex + 1;
                    Console.WriteLine($"Current Playing {Cd.TrackList[trackPlayingNowIndex].Title}, Next is: {Cd.TrackList[nextSongIndex].Title}");
                    PlayingNow = Cd.TrackList[nextSongIndex].Title;
                }
            }
        }

        public void PlayPreviousSong()
        {
            if (!Loaded)
            {
                Console.WriteLine("Please insert CD first");
                return;
            }
            if (PlayingNow == null)
            {
                Console.WriteLine("Please press Start first");
            }
            else
            {
                int trackPlayingNowIndex = Cd.TrackList.FindIndex(track => track.Title == PlayingNow);
                if (trackPlayingNowIndex == 0)
                {
                    Console.WriteLine("This is the First Song (there is no previous song available)");
                }
                else
                {
                    int previousSongIndex = trackPlayingNowIndex - 1;
                    Console.WriteLine($"Current Playing {Cd.TrackList[trackPlayingNowIndex].Title}, Previous is: {Cd.TrackList[previousSongIndex].Title}");
                    PlayingNow = Cd.TrackList[previousSongIndex].Title;
                }
            }
        }
    }
}
