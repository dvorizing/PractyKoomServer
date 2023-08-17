using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HMO.Repositories.Repositories
{
    public class PersonRepository:IPersonRepository
    {
        private readonly IContext _context;

        public PersonRepository(IContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Persons.ToListAsync();
        }
        public async Task<Person> GetByIdAsync(string id)
        {
            return await _context.Persons.FindAsync(id);
        }
        public async Task<Person> AddAsync(Person person)
        {
            var c = _context.Persons.Add(person);
            await _context.SaveChangesAsync();
            return c.Entity;
        }
        public async Task<Person> UpdateAsync(Person person)
        {
            var c = await GetByIdAsync(person.Id);
            c.FirstName = person.FirstName;
            c.LastName = person.LastName;
            c.BirthDay = person.BirthDay;
            c.Gender = person.Gender;
            c.HMO = person.HMO;
            await _context.SaveChangesAsync();
            return c;
        }
       
        public async Task DeleteAsync(string id)
        {
            _context.Persons.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }


    }
}
