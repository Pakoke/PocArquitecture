namespace PocArquitecture.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="PersonDto" />
    /// </summary>
    public class PersonDto : IPersonDto
    {
        /// <summary>
        /// Gets or sets the Dni
        /// </summary>
        public string Dni { get; set; }

        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the GivenName
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
        /// Gets or sets the HomeAddress
        /// </summary>
        public string HomeAddress { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        public string Phone { get; set; }
    }
}
