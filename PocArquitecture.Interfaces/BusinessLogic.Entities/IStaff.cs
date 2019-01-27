using System;
using System.Collections.Generic;

namespace PocArquitecture.Interfaces.BusinessLogic.Entities
{
    public interface IStaff : IPerson
    {
        IDepartment Department{ get; set; }

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
    }
}
