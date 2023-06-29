using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace CDplayerProject
{
    internal class CD
    {               
        public List<Track> TrackList = new List<Track>();        
               
        public void CdInfo()
        {
            Console.WriteLine($"Number of tracks is: {TrackList.Count} ");

            foreach ( Track track in TrackList )
            {
                Console.WriteLine($"\tTrack : {track.Title} \t Duration: {track.Duration}  ");
            }
        }       
    }
}
