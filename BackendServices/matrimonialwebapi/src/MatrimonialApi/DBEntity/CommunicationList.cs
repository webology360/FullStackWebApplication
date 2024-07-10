using System.Collections.Generic;

namespace MatrimonialApi.DBEntity
{
    /// <summary>
    /// Represents a list of communications.
    /// </summary>
    public partial class CommunicationList
    {
        /// <summary>
        /// Gets or sets the current page number.
        /// </summary>
        public int? CurrentPageNumber { get; set; }

        /// <summary>
        /// Gets or sets the range.
        /// </summary>
        public int? Range { get; set; }

        /// <summary>
        /// Gets or sets the list of communications.
        /// </summary>
        public List<Communication> Communications { get; set; }
    }
}
