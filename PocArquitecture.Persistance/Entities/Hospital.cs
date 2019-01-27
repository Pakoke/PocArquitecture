namespace PocArquitecture.Persistance.Entities
{
    using PocArquitecture.Interfaces.Persistance.Entities;

    /// <summary>
    /// Defines the <see cref="Hospital" />
    /// </summary>
    public class Hospital : IHospital
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
