using Microsoft.AspNetCore.Mvc;
using Nozom.Data.Entities;
using Nozom.Data.Entities.Storage;
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
    public class ItemsController : ControllerBase
    {
        private readonly DomainContext _context;
        public ItemsController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(CategoryRepository),
                typeof(ItemsRepository),
                typeof(ItemTransactionRepository),
                typeof(PersonRepository)
                );
        }
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<ItemsDTO> Get()
        {
            var items = _context.Items.GetAll();
            return items;
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public ItemsDTO Get(int id)
        {
            var item = _context.Items.GetById(id);
            return item;
        }

        // GET api/<ItemsController>/GetCategoryWithQuantity
        [HttpGet("GetCategoryWithQuantity")]
        public List<CategoryWithQuantity> GetCategoryWithQuantity()
        {
            List<CategoryWithQuantity> result = new List<CategoryWithQuantity>();
            var categoryWithQuantity = _context.Items.GetAllCategoryWithQuantity();
            var allCategory = _context.Category.GetAll();
            foreach (var category in allCategory)
            {
                result.Add(new CategoryWithQuantity { Id = category.Id, Name = category.Name, Quantity = 0 });
            }
            foreach (var category in categoryWithQuantity)
            {
                result.Find(x => x.Id == category.Id).Quantity = category.Quantity;
            }

            return result;
        }

        // POST api/<ItemsController>
        [HttpPost]
        public void Post([FromBody] ItemsDTO item)
        {
            item.SameNameItems = new List<ItemDTO>();
            for (int i = 0; i < item.Quantity; i++)
                item.SameNameItems.Add(new ItemDTO { Serial = null });
            _context.Items.Add(item);
            _context.Complete();
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ItemsDTO item)
        {
            _context.Items.Update(item, id);
            _context.Complete();
        }
        [HttpPut("editWithOutName/{id}")]
        public void EditWithOutName(int id, [FromBody] ItemsDTO item)
        {
            var itemWillUpdate = _context.Items.GetById(item.Id);
            itemWillUpdate.Quantity += item.Quantity;
            itemWillUpdate.Price = item.Price;
            itemWillUpdate.SameNameItems = new List<ItemDTO>();
            for (int i = 0; i < item.Quantity; i++)
            {
                itemWillUpdate.SameNameItems.Add(new ItemDTO { Serial = null });
            }
            _context.Items.Update(itemWillUpdate, id);
            _context.Complete();
        }
        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Items.Delete(id);
        }
    }
}
