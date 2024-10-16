using Ecommerce_Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_Api.Data
{
    // We will use identitydbcontext instead of dbcontext because it gives us preexisting tables which helps with authentication
    //here orignally when we were using idenityUser in program.cs we only has IdentityDbcontext
    //but since we are switching we have to specify which is why we add the IdentityDbContext<ApplicationUser>  Application inside
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Here we are passing the connetion string as an option through the constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {}


        //we set the schema/model to refernce from and it takes the name we give here as table name
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
