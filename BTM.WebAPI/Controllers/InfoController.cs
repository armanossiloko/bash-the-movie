using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        string Default = "Default.png";

        // GET: api/Info/avatars
        [HttpGet]
        [Route("avatars")]
        public string Get()
        {
            return Global.Avatars;
        }

        // GET: api/Info/defaultavatar
        [HttpGet]
        [Route("defaultavatar")]
        public string DefaultAvatar()
        {
            return $@"{Global.Avatars}\{Default}";
        }

        // GET: api/Info/covers
        [HttpGet]
        [Route("covers")]
        public string Covers()
        {
            return $@"{Global.Covers}";
        }

        // GET: api/Info/defaultCover
        [HttpGet]
        [Route("defaultCover")]
        public string DefaultCover()
        {
            return $@"{Global.Covers}\{Default}";
        }

        // GET: api/Info/news
        [HttpGet]
        [Route("news")]
        public string NewsLocation()
        {
            return $@"{Global.News}";
        }

        // GET: api/Info/news/logos
        [HttpGet]
        [Route("news/logos")]
        public string NewsLogos()
        {
            return $@"{Global.Logos}";
        }

        // GET: api/Info/soundtracks
        [HttpGet]
        [Route("soundtracks")]
        public string Soundtracks()
        {
            return $@"{Global.Soundtracks}";
        }
    }
}
