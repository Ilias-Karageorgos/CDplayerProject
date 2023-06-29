using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CDplayerProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CD cd1 = new CD();
            CDplayer cDplayer = new CDplayer();

            Track t1 = new Track("Toxicity", 3.53);
            Track t2 = new Track("Question", 3.12);
            Track t3 = new Track("Hypnotize", 5.45);
            Track t4 = new Track("Holy Mountains", 4.17);
            Track t5 = new Track("Aerials", 2.53);

            cd1.TrackList.Add(t1);
            cd1.TrackList.Add(t2);
            cd1.TrackList.Add(t3);
            cd1.TrackList.Add(t4);
            cd1.TrackList.Add(t5);

            ShowButtons();

            string choice;
            do
            {
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": cDplayer.PlayFromStart(); break;
                    case "2": cDplayer.PlayNextSong(); break;
                    case "3": cDplayer.PlayPreviousSong(); break;
                    case "4": cDplayer.StopPlaying(); break;
                    case "5": cDplayer.InsertCD(cd1); break;
                    case "6": cDplayer.ShowStatusOfCDPlayer(); break;
                    case "7": return; 
                    default: Console.WriteLine("Did you miss the button?"); break;
                }
            } while (choice != "7");

        }

        static void ShowButtons()
        {
            Console.WriteLine("Press a button!");
            Console.WriteLine("1 - Start playing songs from Start");
            Console.WriteLine("2 - Play next song");
            Console.WriteLine("3 - Play previous song");
            Console.WriteLine("4 - Stop Playing");
            Console.WriteLine("5 - Insert Cd");
            Console.WriteLine("6 - Cd player status");
            Console.WriteLine("7 - Exit");
        }
    }
}
