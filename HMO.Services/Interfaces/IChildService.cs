using HMO.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Interfaces
{
    public interface IChildService
    {
        Task<List<ChildDTO>> GetAllAsync();
        Task<ChildDTO> GetByIdAsync(string id);
        Task<ChildDTO> AddAsync(ChildDTO child);
        Task<ChildDTO> UpdateAsync(ChildDTO childDTO);
        Task DeleteAsync(string id);
    }
}
