using Microsoft.AspNet.Identity.EntityFramework;

namespace MovieApp.Models.DB_Model
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public partial class AspNetUser : IdentityUser
    {
    }

    //public class ApplicationDbContext : IdentityDbContext<AspNetUser>
    //{
    //    public ApplicationDbContext()
    //        : base("DefaultConnection")
    //    {
    //    }
    //}
}