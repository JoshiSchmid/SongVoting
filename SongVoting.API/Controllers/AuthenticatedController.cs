using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

public class AuthenticatedController : ControllerBase
{
    public bool IsAuthenticated => User?.Identity?.IsAuthenticated ?? false;

    private Guid userToken;

    public Guid? UserToken
    {
        get
        {
            if (userToken != default) return userToken;

            var sid = User.FindFirstValue(ClaimTypes.Sid);

            if (!Guid.TryParse(sid, out userToken)) return null;

            return userToken;
        }
    }
}