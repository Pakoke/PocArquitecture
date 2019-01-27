using System;
using System.Collections.Generic;
using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Patient : Person, IPatient
    {
        public DateTime AcceptedDate { get; set; }
        public string Sickness { get; set; }
        public List<string> History { get; set; }
        public List<string> Allergies { get; set; }
        public List<string> SpecialRequirements { get; set; }
    }
}
