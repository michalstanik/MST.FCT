using MST.FCT.Business.Models.User.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MST.FCT.Business.Models.User.User
{
    public class UserForCreationModel : UserAbstractBase
    {
        public string Id { get; set; }
        public new string UserName { get; set; }
        public new string FirstName { get; set; }
        public new string LastName { get; set; }
    }
}
