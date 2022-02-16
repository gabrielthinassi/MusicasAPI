using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicasAPI.Models
{
    public class Musica
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Gender { get; set; }
        public int Duration { get; set; }
    }
}
