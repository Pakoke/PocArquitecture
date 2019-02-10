

using PocArquitecture.Interfaces.BusinessLogic.Entities;

namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="DepartmentDto" />
    /// </summary>
    public class DepartmentDto : IDepartmentDto//, IDepartment
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

        public string Code { get; set; }

        //public IHospital Center { get; set; }

        public string Name { get; set; }
    }
}
