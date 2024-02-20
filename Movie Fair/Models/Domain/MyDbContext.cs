using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie_Fair.Models.Domain;

namespace Movie_Fair.Models.Domain
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

       
    }
}
