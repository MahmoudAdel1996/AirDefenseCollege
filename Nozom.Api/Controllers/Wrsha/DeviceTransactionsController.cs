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
    public class DeviceTransactionsController : ControllerBase
    {
        private readonly DomainContext _context;
        public DeviceTransactionsController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                //typeof(BranchRepository)
                //typeof(DeviceRepository)
                //typeof(DeviceTypeRepository),
                typeof(DeviceTransactionRepository)
                //typeof(TransactionRepository)
                );
        }
        // GET: api/<DeviceStatesController>
        [HttpGet]
        public IEnumerable<DeviceTransactionDTO> Get()
        {
            var deviceTransactions = _context.DeviceTransactions.GetAll();
            return deviceTransactions;
        }

        // GET api/<DeviceStatesController>/5
        [HttpGet("{id}")]
        public DeviceTransactionDTO Get(int id)
        {
            var deviceTransaction = _context.DeviceTransactions.GetById(id);
            return deviceTransaction;
        }

        // POST api/<DeviceStatesController>
        [HttpPost]
        public void Post([FromBody] DeviceTransactionDTO deviceState)
        {
            _context.DeviceTransactions.Add(deviceState);
            _context.Complete();
        }

        // PUT api/<DeviceStatesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DeviceTransactionDTO deviceState)
        {
            _context.DeviceTransactions.Update(deviceState, id);
            _context.Complete();
        }

        // DELETE api/<DeviceStatesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.DeviceTransactions.Delete(id);
        }
    }
}
