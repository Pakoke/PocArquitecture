﻿namespace PocArquitecture.Interfaces.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IHospital" />
    /// </summary>
    public interface IHospital
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        int Id { get; set; }

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