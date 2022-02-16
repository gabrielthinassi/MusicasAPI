using Microsoft.AspNetCore.Mvc;
using MusicasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicasAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicController : ControllerBase
    {
        private static List<Music> musics = new List<Music>();

        [HttpPost]
        public void Save(Music music)
        {
            musics.Add(music);

        }
    }
}
