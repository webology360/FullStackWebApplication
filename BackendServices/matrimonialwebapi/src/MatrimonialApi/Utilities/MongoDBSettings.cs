using MatrimonialApi.Interfaces.Entity;

namespace MatrimonialApi.Utilities
{
    /// <summary>
    /// Represents the settings for MongoDB connection.
    /// </summary>
    public class MongoDBSettings: IMongoDBSettings
    {
        /// <summary>
        /// Gets or sets the connection string for MongoDB.
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name of the MongoDB database.
        /// </summary>
        public string DatabaseName { get; set; }
    }
}
