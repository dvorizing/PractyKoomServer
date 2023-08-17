using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repositories.Repositories
{
    public class ChildRepository:IChildRepository
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<List<Child>> GetAllAsync()
        {
           return await _context.Childs.ToListAsync();
        }
        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Childs.FindAsync(id);
        }
        public async Task<Child> AddAsync(Child child)
        {
            var c = _context.Childs.Add(child);
            await _context.SaveChangesAsync();
            return c.Entity;
        }
        public async Task<Child> UpdateAsync(Child child)
        {
            var c =await GetByIdAsync(child.Id);
            c.Name = child.Name;
            c.BirthDay = child.BirthDay;
            await _context.SaveChangesAsync();
            return c;
        }
        public async Task DeleteAsync(string id)
        {
            _context.Childs.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }
    }
}
