using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MST.FCT.Business.Models.User.User
{
    /// <summary>
    /// Basic User Model with UserStats
    /// </summary>
    public class UserWithStatsModel : UserModel
    {
        public UserWithStatsModel()
        {
            UserStats = new UserStats();
        }
        public UserStats UserStats { get; set; }
    }
}
