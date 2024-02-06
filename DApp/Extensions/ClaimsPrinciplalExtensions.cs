using System.Security.Claims;

namespace DApp.Extensions
{
    public static class ClaimsPrinciplalExtensions
    {
        public static string GetUserName(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }  
    }
}
