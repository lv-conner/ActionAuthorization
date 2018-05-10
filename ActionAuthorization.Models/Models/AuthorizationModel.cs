using System;
using System.Collections;
using System.Collections.Generic;

namespace ActionAuthorization.Models
{
    public class AuthorizationModel
    {
        public string AuthorizationModelId { get; protected set; }
        public string SystemNo { get; protected set; }
        public string SystemName { get; protected set; }
        public string ModuleNo { get; protected set; }
        public string ModuleName { get; protected set; }
        public string ActionNo { get; protected set; }
        public string ActionName { get; protected set; }
        public bool IsEnabled { get; protected set; }
        public DateTime CreateDate { get; protected set; }
        public DateTime UpdateDate { get; protected set; }
        public List<AuthorizationRole> Roles { get; protected set; }
        public List<AuthorizationUser> Users { get; protected set; }
        public AuthorizationModel(string systemNo,string moduleNo,string actionNo) :this(systemNo,systemNo,moduleNo,moduleNo,actionNo,actionNo)
        {

        }
        public AuthorizationModel(string systemNo, string systemName, string moduleNo, string moduleName, string actionNo, string actionName)
        {
            SystemNo = systemNo;
            SystemName = systemName;
            ModuleNo = moduleNo;
            ModuleName = moduleName;
            ActionNo = actionNo;
            ActionName = actionName;
            CreateDate = DateTime.Now;
            Roles = new List<AuthorizationRole>();
            Users = new List<AuthorizationUser>();
        }
        public void Update(string systemName,string moduleName,string actionName)
        {
            SystemName = systemName;
            ModuleName = moduleName;
            ActionName = actionName;
            UpdateDate = DateTime.Now;
        }
        private void SetState(bool enable)
        {
            IsEnabled = enable;
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
