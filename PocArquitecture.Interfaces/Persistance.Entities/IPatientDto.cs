namespace PocArquitecture.Interfaces.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="IPatientDto" />
    /// </summary>
    public interface IPatientDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        int PatientId { get; set; }

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
        string History { get; set; }

        /// <summary>
        /// Gets or sets the Allergies
        /// </summary>
        string Allergies { get; set; }

        /// <summary>
        /// Gets or sets the SpecialRequirements
        /// </summary>
        string SpecialRequirements { get; set; }
    }
}
