namespace PocArquitecture.Interfaces.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IAppConfiguration" />
    /// </summary>
    public interface IAppConfiguration
    {
        /// <summary>
        /// Gets or sets the ConfigurationId
        /// </summary>
        int ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        string Value { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        string Description { get; set; }
    }
}
