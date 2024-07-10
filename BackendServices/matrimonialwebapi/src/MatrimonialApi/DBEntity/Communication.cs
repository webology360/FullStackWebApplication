using System.Runtime.Serialization;

namespace MatrimonialApi.DBEntity
{
    public partial class Communication
    {
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>

        public string From { get; set; }

        /// <summary>
        /// Gets or Sets CommnicationType
        /// </summary>
        public enum CommnicationTypeEnum
        {
            /// <summary>
            /// Enum EmailEnum for email
            /// </summary>
            [EnumMember(Value = "email")]
            EmailEnum = 0,
            /// <summary>
            /// Enum SmsEnum for sms
            /// </summary>
            [EnumMember(Value = "sms")]
            SmsEnum = 1,
            /// <summary>
            /// Enum WhatsappEnum for whatsapp
            /// </summary>
            [EnumMember(Value = "whatsapp")]
            WhatsappEnum = 2
        }

        /// <summary>
        /// Gets or Sets CommnicationType
        /// </summary>
        public CommnicationTypeEnum? CommnicationType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>

        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>

        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>

        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets MessageDeliveredStatus
        /// </summary>
        public enum MessageDeliveredStatusEnum
        {
            /// <summary>
            /// Enum SuccessEnum for success
            /// </summary>
            [EnumMember(Value = "success")]
            SuccessEnum = 0,
            /// <summary>
            /// Enum FailedEnum for failed
            /// </summary>
            [EnumMember(Value = "failed")]
            FailedEnum = 1,
            /// <summary>
            /// Enum ProcessingEnum for processing
            /// </summary>
            [EnumMember(Value = "processing")]
            ProcessingEnum = 2
        }

        /// <summary>
        /// Gets or Sets MessageDeliveredStatus
        /// </summary>
        public MessageDeliveredStatusEnum? MessageDeliveredStatus { get; set; }
    }
}
