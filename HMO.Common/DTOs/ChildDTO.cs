﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Common.DTOs
{
    public class ChildDTO
    {
        public string ParentID { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
