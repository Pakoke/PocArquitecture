﻿namespace PocArquitecture.Persistance.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Staff" />
    /// </summary>
    public class Staff
    {
        /// <summary>
        /// Gets or sets the DeparmentId
        /// </summary>
        public int DeparmentId { get; set; }

        /// <summary>
        /// Gets or sets the StaffId
        /// </summary>
        public int StaffId { get; set; }

        /// <summary>
        /// Gets or sets the Joined
        /// </summary>
        public DateTime Joined { get; set; }

        /// <summary>
        /// Gets or sets the Education
        /// </summary>
        public List<string> Education { get; set; }

        /// <summary>
        /// Gets or sets the Certification
        /// </summary>
        public List<string> Certification { get; set; }

        /// <summary>
        /// Gets or sets the Languages
        /// </summary>
        public List<string> Languages { get; set; }

        /// <summary>
        /// Gets or sets the TypeStaffId
        /// </summary>
        public int TypeStaffId { get; set; }
    }
}