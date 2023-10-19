using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IMS.Filters;

public class AuthenticationFilter : IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext filterContext)
    {
        if (filterContext == null)
        {
            throw new ArgumentNullException(nameof(filterContext));
        }

        bool hasAllowAnonymous = filterContext.ActionDescriptor
            .EndpointMetadata.Any(em => em.GetType() == typeof(AllowAnonymousAttribute)); //< -- Here it is

        if (hasAllowAnonymous) return;

        var user = filterContext.HttpContext.User;
        if (!user.Identity.IsAuthenticated)
        {
            filterContext.Result = new UnauthorizedResult();
        }
    }
}
