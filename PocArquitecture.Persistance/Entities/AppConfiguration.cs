namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="AppConfiguration" />
    /// </summary>
    public class AppConfiguration
    {
        /// <summary>
        /// Gets or sets the ConfigurationId
        /// </summary>
        public int ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }
    }
}
