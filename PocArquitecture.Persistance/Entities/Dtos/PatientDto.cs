namespace PocArquitecture.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="PatientDto" />
    /// </summary>
    public class PatientDto : IPatientDto
    {
        /// <summary>
        /// Gets or sets the PatientId
        /// </summary>
        public int PatientId { get; set; }

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
        public string History { get; set; }

        /// <summary>
        /// Gets or sets the Allergies
        /// </summary>
        public string Allergies { get; set; }

        /// <summary>
        /// Gets or sets the SpecialRequirements
        /// </summary>
        public string SpecialRequirements { get; set; }
    }
}
