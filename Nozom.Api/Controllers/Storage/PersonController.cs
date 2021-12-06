using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class PersonController : ControllerBase
    {
        private readonly DomainContext _context;
        public PersonController(WrshaDbContext context)
        {
            _context = new DomainContext(context,
                typeof(CategoryRepository),
                typeof(ItemsRepository),
                typeof(ItemTransactionRepository),
                typeof(PersonRepository)
                );
        }
        // GET: api/<PersonController>
        [HttpGet]
        public IEnumerable<PersonDTO> Get()
        {
            var persons = _context.Person.GetAll();
            return persons;
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public PersonDTO Get(int id)
        {
            var person = _context.Person.GetById(id);
            return person;
        }
        // POST api/<PersonController>
        [HttpPost]
        public void Post([FromBody] PersonDTO person)
        {
            _context.Person.Add(person);
            _context.Complete();
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PersonDTO person)
        {
            _context.Person.Update(person, id);
            _context.Complete();
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Person.Delete(id);
        }
    }
}
