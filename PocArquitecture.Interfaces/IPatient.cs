using System;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces
{
    public interface IPatient : IPerson
    {
        int Id { get; set; }

        int Age { get; set; }

        DateTime AcceptedDate { get; set; }

        string Sickness { get; set; }

        List<string> History { get; set; }

        List<string> Allergies { get; set; }

        List<string> SpecialRequirements { get; set; }

    }
}
