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
        int DeparmentId { get; set; }

        /// <summary>
        /// Gets or sets the TypeOfDepartment
        /// </summary>
        string TypeOfDepartment { get; set; }

        /// <summary>
        /// Gets or sets the HostpitalId
        /// </summary>
        int HostpitalId { get; set; }
    }
}
