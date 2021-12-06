using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nozom.Api.Helper;
using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories.Storage;
using Nozom.Infrastructure.DTO.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nozom.Api.Controllers.Storage
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTransactionController : ControllerBase
    {
        private readonly DomainContext _context;
        public ItemTransactionController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(CategoryRepository),
                typeof(ItemsRepository),
                typeof(ItemTransactionRepository),
                typeof(PersonRepository)
                );
        }
        // GET: api/<ItemTransactionController>
        [HttpGet]
        public IEnumerable<ItemTransactionDTO> Get()
        {
            var itemTransactions = _context.ItemTransaction.GetAllWithDetails();
            return itemTransactions;
        }

        // GET api/<ItemTransactionController>/5
        [HttpGet("{id}")]
        public ItemTransactionDTO Get(int id)
        {
            var itemTransaction = _context.ItemTransaction.GetById(id);
            return itemTransaction;
        }
        // POST api/<ItemTransactionController>
        [HttpPost]
        public void Post([FromBody] ItemTransactionDTO itemTransaction)
        {
            var recivePerson = _context.Person.GetPersonByName(itemTransaction.ReciverPerson.Name);
            var handOverPerson = _context.Person.GetPersonByName(itemTransaction.HandOverPerson.Name);
            
            var newItemTansaction = new ItemTransactionDTO
            {
                HandOverPerson = itemTransaction.HandOverPerson,
                ReciverPerson = itemTransaction.ReciverPerson,
                ItemsId = itemTransaction.ItemsId,
                Paid = itemTransaction.Paid,
                Quantity = itemTransaction.Quantity,
                TransactionDate = DateTime.Now,
            };
            if (recivePerson != null)
            {
                newItemTansaction.ReciverPerson = null;
                newItemTansaction.ReciverPersonId = recivePerson.Id;
            }
            if (handOverPerson != null)
            {
                newItemTansaction.HandOverPerson = null;
                newItemTansaction.HandOverPersonId = handOverPerson.Id;
            }
            _context.ItemTransaction.Add(newItemTansaction);
            var item = _context.Items.GetById(newItemTansaction.ItemsId);
            item.Quantity -= newItemTansaction.Quantity;
            _context.Items.Update(item);
            _context.Complete();
        }


        // POST api/<ItemTransactionController>/Edit2ADocument/<name>/<quantity>
        [HttpPost("Edit2ADocument/{names}/{quantity}")]
        public void Edit2ADocument(string names, int quantity)
        {
            var obj = new EditOnDocument2AT();
            obj.AddProductsNamesWithQuantity(names, quantity);
        }
        // PUT api/<ItemTransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ItemTransactionDTO itemTransaction)
        {
            _context.ItemTransaction.Update(itemTransaction, id);
            _context.Complete();
        }

        // DELETE api/<ItemTransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.ItemTransaction.Delete(id);
        }
    }
}
