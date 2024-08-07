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
    public partial class RelativeDTO : IEquatable<RelativeDTO>
    { 
        /// <summary>
        /// Gets or Sets Name
        /// </summary>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Relationship
        /// </summary>

        [DataMember(Name="relationship")]
        public string Relationship { get; set; }

        /// <summary>
        /// Gets or Sets Remark
        /// </summary>

        [DataMember(Name="remark")]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Relative {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Relationship: ").Append(Relationship).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return obj.GetType() == GetType() && Equals((RelativeDTO)obj);
        }

        /// <summary>
        /// Returns true if Relative instances are equal
        /// </summary>
        /// <param name="other">Instance of Relative to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeDTO other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Relationship == other.Relationship ||
                    Relationship != null &&
                    Relationship.Equals(other.Relationship)
                ) && 
                (
                    Remark == other.Remark ||
                    Remark != null &&
                    Remark.Equals(other.Remark)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Relationship != null)
                    hashCode = hashCode * 59 + Relationship.GetHashCode();
                    if (Remark != null)
                    hashCode = hashCode * 59 + Remark.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(RelativeDTO left, RelativeDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RelativeDTO left, RelativeDTO right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
