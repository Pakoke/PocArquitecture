namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IAppConfigurationDto" />
    /// </summary>
    public interface IAppConfigurationDto
    {
        /// <summary>
        /// Gets or sets the ConfigurationId
        /// </summary>
        int AppConfigurationId { get; set; }

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
