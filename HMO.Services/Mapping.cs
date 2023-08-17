using AutoMapper;
using HMO.Common.DTOs;
using HMO.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Services
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Person,PersonDTO>().ReverseMap();
            CreateMap<Child,ChildDTO>().ReverseMap();
            CreateMap<HMO.Common.DTOs.EGender,HMO.Repositories.Entities.EGender>().ReverseMap();
            CreateMap<HMO.Common.DTOs.EHMO, HMO.Repositories.Entities.EHMO>().ReverseMap();
          
        }
    }
}
