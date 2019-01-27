using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;
using System.Collections.Generic;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Staff : Person, IStaff
    {
        public IDepartment Department { get; set; }
        public DateTime Joined { get; set; }
        public List<string> Education { get; set; }
        public List<string> Certification { get; set; }
        public List<string> Languages { get; set; }
    }
}
