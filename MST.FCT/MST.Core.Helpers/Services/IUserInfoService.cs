namespace MST.Core.Helpers.Services
{
    public interface IUserInfoService
    {
        string UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Role { get; set; }
        string Country { get; set; }

        bool IsUserAuthenticated { get; set; }
    }
}
