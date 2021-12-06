using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories;
using Nozom.Infrastructure.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nozom.Api.Controllers.Wrsha
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        private readonly DomainContext _context;
        public DevicesController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                //typeof(BranchRepository)
                typeof(DeviceRepository)
                //typeof(DeviceTypeRepository),
                //typeof(DeviceStateRepository),
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<DevicesController>
        [HttpGet]
        public IEnumerable<DeviceDTO> Get()
        {
            var devices = _context.Devices.GetAll();
            return devices;
        }

        // GET api/<DevicesController>/5
        [HttpGet("{id}")]
        public DeviceDTO Get(int id)
        {
            var devices = _context.Devices.GetById(id);
            return devices;
        }

        // POST api/<DevicesController>
        [HttpPost]
        public void Post([FromBody] DeviceDTO device)
        {
            _context.Devices.Add(device);
            _context.Complete();
        }

        // PUT api/<DevicesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeviceDTO device)
        {
            _context.Devices.Update(device, id);
            _context.Complete();
        }

        // DELETE api/<DevicesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Devices.Delete(id);
        }
    }
}
