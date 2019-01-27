using PocArquitecture.Interfaces.BusinessLogic.Entities;
using System;

namespace PocArquitecture.Entities.BusinessLogic.Entities
{
    public class Person : IPerson
    {
        public string Dni { get ; set ; }
        public string Title { get ; set ; }
        public string GiveName { get ; set ; }
        public string MiddleName { get ; set ; }
        public string FamilyName { get ; set ; }
        public string Name { get ; set ; }
        public DateTime BirthDate { get ; set ; }
        public string Gender { get ; set ; }
        public string HomeAdress { get ; set ; }
        public string Phone { get ; set ; }
    }
}
