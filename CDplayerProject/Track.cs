using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CDplayerProject
{
    internal class Track
    {        
        public double Duration { get; set; }
        public string Title { get; set; }

        public Track(string title, double duration)
        {
            Duration = duration;
            Title = title;
        }

    }
}
