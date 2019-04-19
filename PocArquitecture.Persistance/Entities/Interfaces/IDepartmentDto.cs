namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IDepartmentDto" />
    /// </summary>
    public interface IDepartmentDto
    {
        /// <summary>
        /// Gets or sets the DeparmentId
        /// </summary>
        int DepartmentId { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfDepartment
        /// </summary>
        string TypeOfDepartment { get; set; }

        /// <summary>
        /// Gets or sets the HostpitalId
        /// </summary>
        int HospitalId { get; set; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        string Code { get; set; }

        //IHospital Center { get; set; }
        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }
    }
}
