using Aureum.Pass.Autorization;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace Aureum.Pass.Authorization
{
    public class AccessAuthorization : AuthorizationHandler<AccessTest>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AccessTest requirement)
        {
            var nameUserClaim =
                context.User
                .FindFirst(claim => claim.Type == ClaimTypes.Name);

            if (nameUserClaim == null)
            {
                return Task.CompletedTask;
            }

            var NameUser = nameUserClaim.Value;

            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}
