using Microsoft.AspNetCore.Identity;

namespace TestApp2.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
