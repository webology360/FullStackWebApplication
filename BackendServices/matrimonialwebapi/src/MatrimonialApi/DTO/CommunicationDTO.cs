/*
 * Matrimonial API - OpenAPI 3.0
 *
 * Design and definition of Matrimonial APIs created for practice and teaching
 *
 * OpenAPI spec version: 1.0.11
 * Contact: floatingrays@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MatrimonialApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CommunicationDTO : IEquatable<CommunicationDTO>
    { 
        /// <summary>
        /// Gets or Sets To
        /// </summary>

        [DataMember(Name="to")]
        public string To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>

        [DataMember(Name="from")]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets CommnicationType
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
            WhatsappEnum = 2        }

        /// <summary>
        /// Gets or Sets CommnicationType
        /// </summary>

        [DataMember(Name="commnicationType")]
        public CommnicationTypeEnum? CommnicationType { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>

        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>

        [DataMember(Name="subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>

        [DataMember(Name="createdDateTime")]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets MessageDeliveredStatus
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
            ProcessingEnum = 2        }

        /// <summary>
        /// Gets or Sets MessageDeliveredStatus
        /// </summary>

        [DataMember(Name="messageDeliveredStatus")]
        public MessageDeliveredStatusEnum? MessageDeliveredStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Communication {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  CommnicationType: ").Append(CommnicationType).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  MessageDeliveredStatus: ").Append(MessageDeliveredStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((CommunicationDTO)obj);
        }

        /// <summary>
        /// Returns true if Communication instances are equal
        /// </summary>
        /// <param name="other">Instance of Communication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommunicationDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    To == other.To ||
                    To != null &&
                    To.Equals(other.To)
                ) && 
                (
                    From == other.From ||
                    From != null &&
                    From.Equals(other.From)
                ) && 
                (
                    CommnicationType == other.CommnicationType ||
                    CommnicationType != null &&
                    CommnicationType.Equals(other.CommnicationType)
                ) && 
                (
                    Message == other.Message ||
                    Message != null &&
                    Message.Equals(other.Message)
                ) && 
                (
                    Subject == other.Subject ||
                    Subject != null &&
                    Subject.Equals(other.Subject)
                ) && 
                (
                    CreatedDateTime == other.CreatedDateTime ||
                    CreatedDateTime != null &&
                    CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    MessageDeliveredStatus == other.MessageDeliveredStatus ||
                    MessageDeliveredStatus != null &&
                    MessageDeliveredStatus.Equals(other.MessageDeliveredStatus)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (To != null)
                    hashCode = hashCode * 59 + To.GetHashCode();
                    if (From != null)
                    hashCode = hashCode * 59 + From.GetHashCode();
                    if (CommnicationType != null)
                    hashCode = hashCode * 59 + CommnicationType.GetHashCode();
                    if (Message != null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                    if (Subject != null)
                    hashCode = hashCode * 59 + Subject.GetHashCode();
                    if (CreatedDateTime != null)
                    hashCode = hashCode * 59 + CreatedDateTime.GetHashCode();
                    if (MessageDeliveredStatus != null)
                    hashCode = hashCode * 59 + MessageDeliveredStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CommunicationDTO left, CommunicationDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CommunicationDTO left, CommunicationDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}