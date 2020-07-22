using Microsoft.EntityFrameworkCore;
using SocialNetworkinSite.API.Models;

namespace SocialNetworkinSite.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }        
    }
}