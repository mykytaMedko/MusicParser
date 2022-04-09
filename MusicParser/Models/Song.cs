using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicParser.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ArtistName { get; set; }

        public string AlbumName { get; set; }

        public string Duration { get; set; }

        //public string Genre { get; set; }
    }
}
