using HMO.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface IPersonService
    {
        Task<List<PersonDTO>> GetAllAsync();
        Task<PersonDTO> GetByIdAsync(string id);
        Task<PersonDTO> AddAsync(PersonDTO person);
        Task<PersonDTO> UpdateAsync(PersonDTO personDTO);
        Task DeleteAsync(string id);

    }
}
