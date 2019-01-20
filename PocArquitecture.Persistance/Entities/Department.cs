using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="Department" />
    /// </summary>
    public class Department : IDepartment
    {
        /// <summary>
        /// Gets or sets the DeparmentId
        /// </summary>
        public int DeparmentId { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfDepartment
        /// </summary>
        public string TypeOfDepartment { get; set; }

        /// <summary>
        /// Gets or sets the HostpitalId
        /// </summary>
        public int HostpitalId { get; set; }
    }
}
