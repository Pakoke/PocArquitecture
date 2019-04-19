namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="HospitalDto" />
    /// </summary>
    public class HospitalDto : IHospitalDto//, IHospital
    {
        /// <summary>
        /// Gets or sets the HospitalId
        /// </summary>
        public int HospitalId { get; set; }

        /// <summary>
        /// Gets or sets the Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }
    }
}
