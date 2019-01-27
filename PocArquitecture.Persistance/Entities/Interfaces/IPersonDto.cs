namespace PocArquitecture.Persistance.Entities
{
    using System;

    /// <summary>
    /// Defines the <see cref="IPersonDto" />
    /// </summary>
    public interface IPersonDto
    {

        string Dni { get; set; }
        /// <summary>
        /// Gets or sets the Title
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the GiveName
        /// </summary>
        string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the MiddleName
        /// </summary>
        string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the FamilyName
        /// </summary>
        string FamilyName { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the BirthDate
        /// </summary>
        DateTime BirthDate { get; set; }

        /// <summary>
        /// Gets or sets the Gender
        /// </summary>
        string Gender { get; set; }

        /// <summary>
        /// Gets or sets the HomeAdress
        /// </summary>
        string HomeAdress { get; set; }

        /// <summary>
        /// Gets or sets the Phone
        /// </summary>
        string Phone { get; set; }
    }
}
