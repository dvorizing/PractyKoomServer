using HMO.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTOs
{
    public enum EGender { Male=1, Female=2 };
    public enum EHMO { Macabi=1, Mehuhedet=2, Clalit=3, leumi=4 };
    public class PersonDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public EGender Gender { get; set; }
        public EHMO HMO { get; set; }


    }
}
