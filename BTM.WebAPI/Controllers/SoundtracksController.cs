using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class SoundtracksController : ControllerBase
    {
        private IData<Soundtrack> _soundData;

        public SoundtracksController(IData<Soundtrack> soundtracksData)
        {
            _soundData = soundtracksData;
        }

        // GET: api/soundtracks/5
        [HttpGet("{id}")]
        public Soundtrack Get(int id) // mediaID
        {
            return _soundData.Get(x => x.MediaID == id);
        }

        // POST: api/soundtracks
        [HttpPost]
        public Soundtrack Post(Soundtrack obj)
        {
            return _soundData.Add(obj);
        }

        // PUT api/soundtracks/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Soundtrack obj)
        {
            var oldObj = _soundData.Get(id);
            if (oldObj == null)
            {
                return;
            }
            var newObj = _soundData.Update(obj);
        } // Might break
    }
}