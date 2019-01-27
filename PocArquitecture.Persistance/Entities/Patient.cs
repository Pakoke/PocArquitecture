namespace PocArquitecture.Persistance.Entities
{
    using PocArquitecture.Interfaces.Persistance.Entities;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Patient" />
    /// </summary>
    public class Patient : IPatientDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public int Id { get; set; }

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
    }
}
