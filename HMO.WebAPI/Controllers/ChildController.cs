using HMO.Common.DTOs;
using HMO.Services.Interfaces;
using HMO.Services.Services;
using HMO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IChildService _childService;
        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<List<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<ChildDTO> GetById(string id)
        {
            return await _childService.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _childService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<ChildDTO> Put(string id, [FromBody] ChildModel childModel)
        {
            return await _childService.UpdateAsync(new ChildDTO
            {
                Id = childModel.Id,
                Name = childModel.Name,BirthDay=childModel.BirthDay
            });
        }
        [HttpPost]
        public async Task<ChildDTO> Post([FromBody] ChildDTO childDTO)
        {
            return await _childService.AddAsync(childDTO);
        }
    }
}
