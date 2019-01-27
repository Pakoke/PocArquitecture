namespace PocArquitecture.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="StaffDto" />
    /// </summary>
    public class StaffDto : IStaffDto
    {
        /// <summary>
        /// Gets or sets the DeparmentId
        /// </summary>
        public int DeparmentId { get; set; }

        /// <summary>
        /// Gets or sets the StaffId
        /// </summary>
        public int StaffId { get; set; }


        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets the Joined
        /// </summary>
        public DateTime Joined { get; set; }

        /// <summary>
        /// Gets or sets the Education
        /// </summary>
        public string Education { get; set; }

        /// <summary>
        /// Gets or sets the Certification
        /// </summary>
        public string Certification { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// </summary>
        public string Languages { get; set; }

        /// <summary>
        /// Gets or sets the TypeStaffId
        /// </summary>
        public int TypeStaffId { get; set; }


    }
}
