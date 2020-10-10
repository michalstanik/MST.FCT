using Microsoft.AspNetCore.Authorization;

namespace MST.FCT.Business.Polices
{
    public static class AviationPolices
    {
        public const string CanManageAirportsDictonary = "CanManageAirportsDictonary";
        public static AuthorizationPolicy CanManageAirportsDictonaryPolicy()
        {
            return new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .RequireClaim("role", "admin_aviation")
                .Build();
        }
    }
}
