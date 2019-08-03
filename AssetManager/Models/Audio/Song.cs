using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManager.Models.Audio
{
    public class Song
    {
        public int Id { get; set; }

        public string Artist { get; set; }

        public string Titel { get; set; }

        public string Album { get; set; }

        public int ReleaseYear { get; set; }

        public string Genre { get; set; }

        public TimeSpan Duration { get; set; }
    }
}
