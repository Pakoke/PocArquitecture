namespace PocArquitecture.Interfaces.Persistance.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IPatient" />
    /// </summary>
    public interface IPatient
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the Age
        /// </summary>
        int Age { get; set; }

        /// <summary>
        /// Gets or sets the AcceptedDate
        /// </summary>
        DateTime AcceptedDate { get; set; }

        /// <summary>
        /// Gets or sets the Sickness
        /// </summary>
        string Sickness { get; set; }

        /// <summary>
        /// Gets or sets the History
        /// </summary>
        List<string> History { get; set; }

        /// <summary>
        /// Gets or sets the Allergies
        /// </summary>
        List<string> Allergies { get; set; }

        /// <summary>
        /// Gets or sets the SpecialRequirements
        /// </summary>
        List<string> SpecialRequirements { get; set; }
    }
}
