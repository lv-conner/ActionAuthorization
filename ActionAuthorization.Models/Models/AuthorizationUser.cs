using ActionAuthorization.Models.Relations;
using System;
using System.Collections.Generic;
using System.Text;

namespace ActionAuthorization.Models
{
    public class AuthorizationUser
    {
        public string UserId { get; protected set; }
        public string UserName { get; protected set; }
        public string Password { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public Sex Sex { get; protected set; }
        private string Salt { get;  set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public string CreaateUserId { get; protected set; }
        public AuthorizationUser CreateUser { get; protected set; }
        public List<RoleUser> Roles { get; protected set; }
        public List<UserAuthorization> UserAuthorizations { get; protected set; }
        public AuthorizationUser(string userName,string password,string email):this(userName,password,email,null,Sex.None,null)
        {

        }
        public AuthorizationUser(string userName,string password,string email,string phoneNumber,Sex sex,string createUserId)
        {
            UserId = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            CreaateUserId = createUserId;
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            Roles = new List<RoleUser>();
            UserAuthorizations = new List<UserAuthorization>();
        }
        public void UpdateUser(string userName,string email,string phoneNumber,Sex sex,string createUserId)
        {
            UserName = userName;
            Email = email;
            PhoneNumber = phoneNumber;
            Sex = sex;
            CreaateUserId = createUserId;
        }
        public void UpdatePassword(string oldPassword,string newPassword)
        {
            if(Password == oldPassword)
            {
                oldPassword = newPassword;
            }
        }
    }

    public enum Sex
    {
        Man,
        Lady,
        None
    }
}
