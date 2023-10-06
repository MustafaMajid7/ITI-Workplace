using Microsoft.AspNetCore.Identity;

namespace MVCPRO.Models
{
	public class AppUser : IdentityUser
	{
        public string address { get; set; }

    }
}
