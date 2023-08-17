using HMO.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repositories.Interfaces
{
    public interface IPersonRepository
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> GetByIdAsync(string id);
        Task<Person> AddAsync(Person p);
        Task<Person> UpdateAsync(Person person);
        Task DeleteAsync(string id);
    }
}
