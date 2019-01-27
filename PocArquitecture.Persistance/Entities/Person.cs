﻿namespace PocArquitecture.Persistance.Entities
{
    using PocArquitecture.Interfaces.Persistance.Entities;
    using System;

    /// <summary>
    /// Defines the <see cref="Person" />
    /// </summary>
    public class Person : IPersonDto
    {
        public string Dni { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the GiveName
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the MiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the FamilyName
        /// </summary>
        public string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the BirthDate
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the HomeAdress
        /// </summary>
        public string HomeAdress { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public string Phone { get; set; }
    }
}
