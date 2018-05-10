using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Models.Relations
{
    public class RoleAuthorization
    {
        public string RoleAuthorizationId { get; protected set; }
        public string RoleId { get; protected set; }
        public string AuthorizationId { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public AuthorizationRole AuthorizationRole { get; protected set; }
        public AuthorizationModel AuthorizationModel { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public RoleAuthorization(string roleId, string authorizationId)
        {
            RoleAuthorizationId = Guid.NewGuid().ToString();
            RoleId = roleId;
            AuthorizationId = authorizationId;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            Active();
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
