using System;

namespace MatrimonialApi.CommonEntity
{
  /// <summary>
    /// Represents an email message.
    /// </summary>
    public class EmailMessage
    {
        /// <summary>
        /// Gets or sets the recipient email address.
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the subject of the email.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body of the email.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the date of the email.
        /// </summary>
        public DateTime Date { get; set; }
    }

}
