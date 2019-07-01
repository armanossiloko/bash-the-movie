using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BTM.Models;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private IData<Image> _imageData;

        public ImagesController(IData<Image> imageData)
        {
            _imageData = imageData;
        }

        // GET api/images/covers/5
        [HttpGet("Covers/{id}")]
        [AllowAnonymous]
        public IActionResult GetCover(int id)
        {
            var img = _imageData.Get(x => x.MediaID == id);
            string filename = Path.GetFileName(img.Location);
            var image = System.IO.File.OpenRead($@"{Global.Covers}\{filename}");
            return File(image, "image/jpeg");
        }

        // GET api/images/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public Image Get(int id)
        {
            return _imageData.Get(x => x.MediaID == id);
        }

        // POST api/images
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public Image Post(Image obj)
        {
            return _imageData.Add(obj);
        }
    }
}