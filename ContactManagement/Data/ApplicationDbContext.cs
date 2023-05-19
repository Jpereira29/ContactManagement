using Microsoft.EntityFrameworkCore;
using ContactManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ContactManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactManagement.Models.Contact> Contact { get; set; } = default!;
    }
}
