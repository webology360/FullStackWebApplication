using System.Collections.Generic;

namespace MatrimonialApi.DBEntity
{
        /// <summary>
        /// Role
        /// </summary>
        public partial class Role
        {
            /// <summary>
            /// Gets or Sets Id
            /// </summary>
            public int? Id { get; set; }

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
