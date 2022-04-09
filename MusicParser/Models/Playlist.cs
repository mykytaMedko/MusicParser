using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicParser.Models
{
    public class Playlist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }
    }
}
