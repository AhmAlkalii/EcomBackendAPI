using Microsoft.AspNetCore.Identity;

namespace Ecommerce_Api.Models
{
    //Now we are modify the idenity user so as to give our table the structure we want not the default structure it has with identity user
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
