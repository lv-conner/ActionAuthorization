using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Models.Relations
{
    public class UserAuthorization
    {
        public string UserAuthorizationId { get; protected set; }
        public string UserId { get; protected set; }
        public string AuthorizationId { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public AuthorizationUser Authorizationuser { get; protected set; }
        public AuthorizationModel AuthorizationModel { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public UserAuthorization(string userId,string authorizationId)
        {
            UserAuthorizationId = Guid.NewGuid().ToString();
            UserId = userId;
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
