using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BTM.Database;
using BTM.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T: class
    {
        protected readonly BaseData<T> _service;

        public BaseController(BaseData<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return _service.Get();
        }

        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _service.Get(id);
        }

        [HttpPost]
        public T Post([FromBody] T obj)
        {
            return _service.Add(obj);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}