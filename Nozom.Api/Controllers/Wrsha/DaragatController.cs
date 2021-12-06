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

namespace Nozom.Api.Controllers.Wrshas
{
    [Route("api/[controller]")]
    [ApiController]
    public class DaragatController : ControllerBase
    {
        private readonly DomainContext _context;
        public DaragatController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                //typeof(BranchRepository)
                typeof(DaragaRepository)
                //typeof(DeviceTypeRepository),
                //typeof(DeviceStateRepository),
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<DaragatController>
        [HttpGet]
        public IEnumerable<DaragaDTO> Get()
        {
            var daragat = _context.Daragat.GetAll();
            return daragat;
        }

        // GET api/<DaragatController>/5
        [HttpGet("{id}")]
        public DaragaDTO Get(int id)
        {
            var daraga = _context.Daragat.GetById(id);
            return daraga;
        }

        // POST api/<DaragatController>
        [HttpPost]
        public void Post([FromBody] DaragaDTO branch)
        {
            _context.Daragat.Add(branch);
            _context.Complete();
        }

        // PUT api/<DaragatController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DaragaDTO branch)
        {
            _context.Daragat.Update(branch, id);
            _context.Complete();
        }

        // DELETE api/<DaragatController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Daragat.Delete(id);
        }
    }
}
