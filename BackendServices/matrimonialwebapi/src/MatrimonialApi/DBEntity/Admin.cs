namespace MatrimonialApi.DBEntity
{
    /// <summary>
    /// Represents an admin in the matrimonial system.
    /// </summary>
    public partial class Admin
    {
        /// <summary>
        /// Gets or sets the first name of the admin.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name of the admin.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the admin.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email ID of the admin.
        /// </summary>
        public string EmailId { get; set; }
    }
}
