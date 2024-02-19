using Microsoft.AspNetCore.Identity;

namespace Movie_Fair.Models.Domain
{
    
    public class ApplicationUser : IdentityUser
        {
            public string Name { get; set; }
        }
    }


