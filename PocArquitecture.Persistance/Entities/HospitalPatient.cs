namespace PocArquitecture.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="HospitalPatient" />
    /// </summary>
    public class HospitalPatient
    {
        /// <summary>
        /// Gets or sets the HospitalId
        /// </summary>
        public int HospitalId { get; set; }

        /// <summary>
        /// Gets or sets the PatiendId
        /// </summary>
        public int PatiendId { get; set; }

        /// <summary>
        /// Gets or sets the RegisterDate
        /// </summary>
        public DateTime RegisterDate { get; set; }
    }
}
