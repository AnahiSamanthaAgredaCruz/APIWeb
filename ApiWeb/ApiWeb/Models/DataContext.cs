
namespace ApiWeb.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {//ctor tab tab
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiWeb.Models.Student> Students { get; set; }
    }
}