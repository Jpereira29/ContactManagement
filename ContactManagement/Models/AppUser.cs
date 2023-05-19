using Microsoft.AspNetCore.Identity;

namespace ContactManagement.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
