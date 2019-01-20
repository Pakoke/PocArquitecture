namespace PocArquitecture.Persistance.Entities
{
    using PocArquitecture.Interfaces;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Patient" />
    /// </summary>
    public class Patient : IPatient, IPerson
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Identifier { get; set; }

        /// <summary>
        /// Gets or sets the Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the AcceptedDate
        /// </summary>
        public DateTime AcceptedDate { get; set; }

        /// <summary>
        /// Gets or sets the Sickness
        /// </summary>
        public string Sickness { get; set; }

        /// <summary>
        /// Gets or sets the History
        /// </summary>
        public List<string> History { get; set; }

        /// <summary>
        /// Gets or sets the Allergies
        /// </summary>
        public List<string> Allergies { get; set; }

        /// <summary>
        /// Gets or sets the SpecialRequirements
        /// </summary>
        public List<string> SpecialRequirements { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the GiveName
        /// </summary>
        public string GiveName { get; set; }

        /// <summary>
        /// Gets or sets the MiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the FamilyName
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the BirthDate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the HomeAdress
        /// </summary>
        public string HomeAdress { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public int Phone { get; set; }
    }
}
