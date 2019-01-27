namespace PocArquitecture.Interfaces.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="IStaffDto" />
    /// </summary>
    public interface IStaffDto
    {
        /// <summary>
        /// Gets or sets the DeparmentId
        /// </summary>
        int DeparmentId { get; set; }

        /// <summary>
        /// Gets or sets the StaffId
        /// </summary>
        int StaffId { get; set; }

        /// <summary>
        /// Gets or sets the Joined
        /// </summary>
        DateTime Joined { get; set; }

        /// <summary>
        /// Gets or sets the Education
        /// </summary>
        string Education { get; set; }

        /// <summary>
        /// Gets or sets the Certification
        /// </summary>
        string Certification { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// </summary>
        string Languages { get; set; }

        /// <summary>
        /// Gets or sets the TypeStaffId
        /// </summary>
        int TypeStaffId { get; set; }
    }
}
