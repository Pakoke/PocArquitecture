namespace PocArquitecture.Interfaces.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IDepartment" />
    /// </summary>
    public interface IDepartment
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
