using Microsoft.EntityFrameworkCore;
using Secure_API_Template.DataBase.Entites;

namespace Secure_API_Template.DataBase.Context
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUsers> Users { get; set; }

    }
}
