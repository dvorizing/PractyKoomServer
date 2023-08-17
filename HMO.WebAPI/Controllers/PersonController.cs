using HMO.Common.DTOs;
using HMO.Services.Interfaces;
using HMO.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController: ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }
        [HttpGet]
        public async Task<List<PersonDTO>> Get()
        {
            return await _personService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<PersonDTO> GetById(string id)
        {
            return await _personService.GetByIdAsync(id);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            await _personService.DeleteAsync(id);
        }
        [HttpPut("{id}")]
        public async Task<PersonDTO> Put(string id, [FromBody] PersonModel personModel)
        {
           return await _personService.UpdateAsync(new PersonDTO { Id = id,FirstName=personModel.FirstName,LastName=personModel.LastName,
                BirthDay=personModel.BirthDay,Gender= (Common.DTOs.EGender)personModel.Gender,
                HMO= (Common.DTOs.EHMO)personModel.HMO});
        }
        [HttpPost]
        public async Task<PersonDTO> Post([FromBody] PersonDTO personDTO)
        {
           PersonDTO p= await _personService.AddAsync(personDTO);
            return p;
        }
    }
}
