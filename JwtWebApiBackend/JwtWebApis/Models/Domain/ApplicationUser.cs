﻿using Microsoft.AspNetCore.Identity;

namespace JwtWebApis.Models.Domain
{
    public class ApplicationUser: IdentityUser
    {
        public string? Name { get; set; }
    }
}
