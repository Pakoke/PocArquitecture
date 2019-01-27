namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IHospitalDto" />
    /// </summary>
    public interface IHospitalDto
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        int HospitalId { get; set; }

        /// <summary>
        /// Gets or sets the Address
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        int Phone { get; set; }
    }
}
