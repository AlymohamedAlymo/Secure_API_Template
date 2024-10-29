using Microsoft.EntityFrameworkCore;
using Secure_API_Template.Data.Entites;

namespace Secure_API_Template.Data.Context
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUsers> Users { get; set; }

    }
}
