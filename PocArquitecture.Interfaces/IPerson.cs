using System;

namespace PocArquitecture.Interfaces
{
    public interface IPerson
    {
        string Title { get; set; }

        string GiveName { get; set; }

        string MiddleName { get; set; }

        string FamilyName { get; set; }

        string Name { get; set; }

        DateTime BirthDate { get; set; }

        string Gender { get; set; }

        string HomeAdress { get; set; }

        int Phone { get; set; }
    }
}
