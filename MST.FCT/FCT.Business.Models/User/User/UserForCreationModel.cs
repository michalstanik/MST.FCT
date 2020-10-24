using MST.FCT.Business.Models.User.Base;

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
