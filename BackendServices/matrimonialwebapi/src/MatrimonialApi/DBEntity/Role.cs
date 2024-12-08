using AspNetCore.Identity.Mongo.Model;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;



namespace MatrimonialApi.DBEntity
{
    /// <summary>
    /// Role
    /// </summary>
    public partial class Role : MongoRole<Guid>
    {
        ///// <summary>
        ///// Gets or Sets Id
        ///// </summary>
        //[BsonId]
        //[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        //public int? Id { get; set; }

            /// <summary>
            /// Gets or Sets RoleName
            /// </summary>

            public string RoleName { get; set; }

            /// <summary>
            /// Gets or Sets PermissionName
            /// </summary>

            public List<string> PermissionName { get; set; }
    }

}
