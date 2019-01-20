using System;
using System.Collections.Generic;

namespace PocArquitecture.Persistance.Entities
{
    public class Staff
    {
        public int DeparmentId { get; set; }

        public int StaffId { get; set; }

        public DateTime Joined { get; set; }

        public List<string> Education { get; set; }

        public List<string> Certification { get; set; }

        public List<string> Languages { get; set; }
    }
}
