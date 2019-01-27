using System;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IPatient : IPerson
    {

        /// <summary>
        /// Gets or sets the AcceptedDate
        /// </summary>
        DateTime AcceptedDate { get; set; }

        /// <summary>
        /// Gets or sets the Sickness
        /// </summary>
        string Sickness { get; set; }

        /// <summary>
        /// Gets or sets the History
        /// </summary>
        List<string> History { get; set; }

        /// <summary>
        /// Gets or sets the Allergies
        /// </summary>
        List<string> Allergies { get; set; }

        /// <summary>
        /// Gets or sets the SpecialRequirements
        /// </summary>
        List<string> SpecialRequirements { get; set; }
    }
}
