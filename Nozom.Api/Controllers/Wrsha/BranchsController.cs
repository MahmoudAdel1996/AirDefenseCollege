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
    public class BranchsController : ControllerBase
    {
        private readonly DomainContext _context;
        public BranchsController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(BranchRepository)
                //typeof(DaragaRepository),
                //typeof(DeviceTypeRepository),
                //typeof(DeviceStateRepository),
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<BranchsController>
        [HttpGet]
        public IEnumerable<BranchDTO> Get()
        {
            var allBranches = _context.Branchs.GetAll();
            return allBranches;
        }

        // GET api/<BranchsController>/5
        [HttpGet("{id}")]
        public BranchDTO Get(int id)
        {
            var branche = _context.Branchs.GetById(id);
            return branche;
        }

        // POST api/<BranchsController>
        [HttpPost]
        public void Post([FromBody] BranchDTO branch)
        {
            _context.Branchs.Add(branch);
            _context.Complete();
        }

        // PUT api/<BranchsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BranchDTO branch)
        {
            _context.Branchs.Update(branch, id);
            _context.Complete();
        }

        // DELETE api/<BranchsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Branchs.Delete(id);
        }
    }
}
