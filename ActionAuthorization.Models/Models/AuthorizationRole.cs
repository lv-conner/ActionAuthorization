using ActionAuthorization.Models.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Models
{
    public class AuthorizationRole
    {
        public string RoleId { get; protected set; }
        public string RoleName { get; protected set; }
        public string Description { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public string CreateUserId { get; set; }
        public AuthorizationUser CreateUser { get; protected set; }
        public List<AuthorizationUser> Users { get; protected set; }
        public List<RoleAuthorization> RoleAuthorizations { get; protected set; }
        public AuthorizationRole(string roleName,string createUserId,string description=null)
        {
            RoleId = Guid.NewGuid().ToString();
            CreateUserId = createUserId;
            Description = description;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            Users = new List<AuthorizationUser>();
            RoleAuthorizations = new List<RoleAuthorization>();
        }
        public void Update(string roleName,string description=null)
        {
            RoleName = roleName;
            Description = description;
        }
        private void SetState(bool state)
        {
            IsEnabled = state;
        }
        public void Active()
        {
            SetState(true);
        }
        public void UnActive()
        {
            SetState(false);
        }


    }
}
