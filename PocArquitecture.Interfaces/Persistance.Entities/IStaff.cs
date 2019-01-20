namespace PocArquitecture.Interfaces.Persistance.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="IStaff" />
    /// </summary>
    public interface IStaff
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
        List<string> Education { get; set; }

        /// <summary>
        /// Gets or sets the Certification
        /// </summary>
        List<string> Certification { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// </summary>
        List<string> Languages { get; set; }

        /// <summary>
        /// Gets or sets the TypeStaffId
        /// </summary>
        int TypeStaffId { get; set; }
    }
}
