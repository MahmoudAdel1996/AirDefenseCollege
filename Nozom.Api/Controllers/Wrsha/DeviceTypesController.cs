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
    public class DeviceTypesController : ControllerBase
    {
        private readonly DomainContext _context;
        public DeviceTypesController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                //typeof(BranchRepository)
                //typeof(DeviceRepository)
                typeof(DeviceTypeRepository)
                //typeof(DeviceStateRepository)
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<DeviceTypesController>
        [HttpGet]
        public IEnumerable<DeviceTypeDTO> Get()
        {
            var devicetypes = _context.DeviceTypes.GetAll();
            return devicetypes;
        }

        // GET api/<DeviceTypesController>/5
        [HttpGet("{id}")]
        public DeviceTypeDTO Get(int id)
        {
            var devicetype = _context.DeviceTypes.GetById(id);
            return devicetype;
        }

        // POST api/<DeviceTypesController>
        [HttpPost]
        public void Post([FromBody] DeviceTypeDTO devicetype)
        {
            _context.DeviceTypes.Add(devicetype);
            _context.Complete();
        }

        // PUT api/<DeviceTypesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeviceTypeDTO devicetype)
        {
            _context.DeviceTypes.Update(devicetype, id);
            _context.Complete();
        }

        // DELETE api/<DeviceTypesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.DeviceTypes.Delete(id);
        }
    }
}
