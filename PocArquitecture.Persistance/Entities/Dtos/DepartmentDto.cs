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
        public int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfDepartment
        /// </summary>
        public string TypeOfDepartment { get; set; }

        /// <summary>
        /// Gets or sets the HostpitalId
        /// </summary>
        public int HospitalId { get; set; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string Code { get; set; }

        //public IHospital Center { get; set; }
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }
    }
}
