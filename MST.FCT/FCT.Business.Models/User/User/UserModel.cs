using MST.FCT.Business.Models.User.Base;
using System;

namespace MST.FCT.Business.Models.User.User
{
    /// <summary>
    /// Base Model for User
    /// </summary>
    public class UserModel : UserAbstractBase
    {
        /// <summary>
        /// Id for user
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Last login time in to app
        /// </summary>
        public DateTime LastLoginTime { get; set; }
    }
}
