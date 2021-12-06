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
    public class DeviceStatesController : ControllerBase
    {
        private readonly DomainContext _context;
        public DeviceStatesController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                //typeof(BranchRepository)
                //typeof(DeviceRepository)
                //typeof(DeviceTypeRepository),
                typeof(DeviceStateRepository)
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<DeviceStatesController>
        [HttpGet]
        public IEnumerable<DeviceStateDTO> Get()
        {
            var deviceStates = _context.DeviceStates.GetAll();
            return deviceStates;
        }

        // GET api/<DeviceStatesController>/5
        [HttpGet("{id}")]
        public DeviceStateDTO Get(int id)
        {
            var deviceState = _context.DeviceStates.GetById(id);
            return deviceState;
        }

        // POST api/<DeviceStatesController>
        [HttpPost]
        public void Post([FromBody] DeviceStateDTO deviceState)
        {
            _context.DeviceStates.Add(deviceState);
            _context.Complete();
        }

        // PUT api/<DeviceStatesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeviceStateDTO deviceState)
        {
            _context.DeviceStates.Update(deviceState, id);
            _context.Complete();
        }

        // DELETE api/<DeviceStatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.DeviceStates.Delete(id);
        }
    }
}
