using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Models.Relations
{
    public class RoleUser
    {
        public string RoleUserId { get; protected set; }
        public string RoleId { get; protected set; }
        public string UserId { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public AuthorizationRole Role { get; protected set; }
        public AuthorizationUser User { get; protected set; }
        public RoleUser(string roleId,string userId)
        {
            RoleUserId = Guid.NewGuid().ToString();
            RoleId = roleId;
            UserId = UserId;
        }
    }
}
