using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;
using AspNetCore.Identity.Mongo.Model;
using System.Runtime.Serialization;

namespace MatrimonialApi.DBEntity
{
    /// <summary>
    /// Create User
    /// </summary>
    public partial class User: MongoUser<Guid>
    {
        ///// <summary>
        ///// Gets or sets the Id of the created admin.
        ///// </summary>
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string Id { get; set; }
        /// <summary>
        /// Gets or sets the first name of the created admin.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the middle name of the created admin.
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name of the created admin.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the created admin is active.
        /// </summary>
        public bool? IsActive { get; set; }=false;

        /// <summary>
        /// Gets or sets a value indicating whether the created admin is a super admin.
        /// </summary>
        public bool? IsSuperAdmin { get; set; }=false;

        /// <summary>
        /// Gets or sets the created date and time of the admin.
        /// </summary>
        public DateTime? CreatedDateTime { get; set; }= DateTime.UtcNow;

        /// <summary>
        /// Gets or sets a value indicating whether the admin account is locked.
        /// </summary>
        public bool? AccountLocked { get; set; } = false;

        /// <summary>
        /// Gets or sets the password reset date and time of the admin.
        /// </summary>
        public DateTime? PasswordResetDateTime { get; set; } = DateTime.UtcNow;

    

    }
}
