using System;
using Microsoft.AspNetCore.Identity;

namespace ApiEcommerce.Controllers;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }
    
}
