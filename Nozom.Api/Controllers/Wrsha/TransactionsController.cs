using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories;
using Nozom.Infrastructure.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nozom.Api.Controllers.Wrsha
{
    // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly DomainContext _context;
        public TransactionsController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(BranchRepository),
                typeof(DaragaRepository),
                typeof(DeviceRepository),
                typeof(DeviceTransactionRepository),
                typeof(DeviceTypeRepository),
                typeof(DeviceStateRepository),
                typeof(TransactionRepository)
                );
        }
        // GET: api/<TransactionsController>
        [HttpGet]
        public IEnumerable<TransactionDTO> Get()
        {
            var transactions = _context.Transactions.GetAllWithSomeDetails();
            return transactions;
        }

        // GET api/<TransactionsController>/5
        [HttpGet("{id}")]
        public TransactionDTO Get(int id)
        {
            var transaction = _context.Transactions.GetById(id);
            return transaction;
        }

        // POST api/<TransactionsController>
        [HttpPost]
        public int Post([FromBody] TransactionDTO transaction)
        {
            transaction.EnterDate = DateTime.Now;
            try
            {
                var deviceType = _context.DeviceTypes.GetByType(transaction.DeviceType.Type);
                if (deviceType != null)
                {
                    transaction.DeviceType = null;
                    transaction.DeviceTypeId = deviceType.Id;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var result = _context.Transactions.Add(transaction);
            _context.Complete();
            return result;
        }

        // PUT api/<TransactionsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TransactionDTO transaction)
        {
            _context.Transactions.Update(transaction, id);
            _context.Complete();
        }

        [HttpPut]
        [Route("EditHandOverTransaction/{id:int}")]
        public void EditHandOverTransaction(int id, [FromBody] TransactionDTO transaction)
        {
            transaction.ExitDate = DateTime.Now;
            _context.Transactions.Update(transaction, id);
            _context.Complete();
        }

        // DELETE api/<TransactionsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Transactions.Delete(id);
        }
    }
}
