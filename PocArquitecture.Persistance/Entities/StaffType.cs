using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="StaffType" />
    /// </summary>
    public class StaffType : IStaffTypeDto
    {
        /// <summary>
        /// Gets or sets the StaffTypeId
        /// </summary>
        public int StaffTypeId { get; set; }

        /// <summary>
        /// Gets or sets the NameStaff
        /// </summary>
        public string NameStaff { get; set; }

        /// <summary>
        /// Gets or sets the DescriptionStaff
        /// </summary>
        public string DescriptionStaff { get; set; }
    }
}
