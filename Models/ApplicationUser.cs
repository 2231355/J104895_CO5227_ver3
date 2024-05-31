using Microsoft.AspNetCore.Identity;

namespace J104895_CO5227_ver3.Models
{
    public class ApplicationUser : IdentityUser 
    {
        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        public DateTime CreatedAt { get; set; }
    }
}
