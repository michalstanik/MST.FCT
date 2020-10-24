using AutoMapper;
using Microsoft.AspNetCore.Components;
using MST.Core.Helpers.Services;
using MST.FCT.Business.Models.User.User;
using MST.FCT.Business.Services;
using System;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        IUserDataService UserDataService { get; set; }
        [Inject]
        IUserInfoService UserInfoService { get; set; }
        [Inject]
        IMapper Mapper { get; set; }
        public bool IsRegisteredUser { get; set; }
        public UserModel User { get; set; } = new UserModel();

        protected override async Task OnInitializedAsync()
        {
            if (UserInfoService.IsUserAuthenticated)
            {
                IsRegisteredUser = true;
                User = await UserDataService.GetUserById(UserInfoService.UserId);
                if (User.Id == null)
                {
                    await CreateNewUserForApp();
                }
                else
                {
                    UpdateLastLoginOnUser();
                }
            }
        }

        private void UpdateLastLoginOnUser()
        {
           
        }

        private async Task CreateNewUserForApp()
        {
            var newUser = new UserForCreationModel()
            {
                Id = UserInfoService.UserId,
                FirstName = UserInfoService.FirstName,
                LastName = UserInfoService.LastName,
                UserName = UserInfoService.FirstName + " " + UserInfoService.LastName
            };
            var createduser = await UserDataService.AddUser(newUser);
            if (createduser != null)
            {
                User = Mapper.Map<UserModel>(createduser);
            }
        }
    }
}
