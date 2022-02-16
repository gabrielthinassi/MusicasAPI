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
    public class MusicaController : ControllerBase
    {
        private static List<Musica> musicas = new List<Musica>();

        [HttpPost]
        public void Save(Musica musica)
        {
            musicas.Add(musica);

        }
    }
}
