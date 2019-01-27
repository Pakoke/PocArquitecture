namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="HospitalDto" />
    /// </summary>
    public class HospitalDto : IHospitalDto
    {
        /// <summary>
        /// Gets or sets the Id
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
        public int Phone { get; set; }
    }
}
