namespace MatrimonialApi.DBEntity
{
    /// <summary>
    /// Short Profile
    /// </summary>
    public partial class ShortProfile
    {
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MiddleName
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or Sets ImageURL
        /// </summary>
        public string ImageURL { get; set; }

        /// <summary>
        /// Gets or Sets CityName
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        /// Gets or Sets StateName
        /// </summary>
        public string StateName { get; set; }

        /// <summary>
        /// Gets or Sets OccupationName
        /// </summary>
        public string OccupationName { get; set; }
    }

}
