using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Nozom.Data.Entities;
using Nozom.Domain;
using Nozom.Domain.Repositories;
using Nozom.Domain.Repositories.Storage;
using Nozom.Infrastructure.DTO;
using Nozom.Infrastructure.DTO.Storage;

namespace Nozom.Api.Controllers.Storage
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DomainContext _context;
        public CategoryController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(CategoryRepository),
                typeof(ItemsRepository),
                typeof(ItemTransactionRepository),
                typeof(PersonRepository)
                );
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public List<CategoryDTO> Get()
        {
            var allCategories = _context.Category.GetAll();
            return allCategories;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public CategoryDTO Get(int id)
        {
            var category = _context.Category.GetById(id);
            return category;
        }
        // GET: api/<CategoryController>/5
        [HttpGet("details/{id}")]
        public List<ItemsDTO> GetAllItemByCategoryId(int id)
        {
            var items = _context.Items.GetAllItemByCategoryId(id);
            return items;
        }
        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] CategoryDTO category)
        {
            _context.Category.Add(category);
            _context.Complete();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoryDTO category)
        {
            _context.Category.Update(category, id);
            _context.Complete();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Category.Delete(id);
        }
    }
}
