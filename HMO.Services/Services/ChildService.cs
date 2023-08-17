using AutoMapper;
using HMO.Common.DTOs;
using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using HMO.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services.Services
{
    public class ChildService:IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository,IMapper mapper)
        {
            _childRepository = childRepository;
            _mapper = mapper;
        }
        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }
        public async Task<ChildDTO> GetByIdAsync(string id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));
        }
        public async Task<ChildDTO> AddAsync(ChildDTO childDTO)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(childDTO)));
        }
        public async Task<ChildDTO> UpdateAsync(ChildDTO childDTO)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(childDTO)));
        }
        public async Task DeleteAsync(string id)
        {
            await _childRepository.DeleteAsync(id);
        }
    }
}
