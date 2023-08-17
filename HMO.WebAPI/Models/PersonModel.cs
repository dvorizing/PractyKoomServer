using HMO.Common.DTOs;

namespace HMO.WebAPI.Models
{
  
    public class PersonModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }
    }
}
