

namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="StaffTypeDto" />
    /// </summary>
    public class StaffTypeDto : IStaffTypeDto
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
