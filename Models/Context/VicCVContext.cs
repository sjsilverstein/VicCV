using Microsoft.EntityFrameworkCore;
using VicCV.Models;

namespace VicCV.Context
{
    public class VicCVContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        
        public VicCVContext(DbContextOptions<VicCVContext> options) : base(options) { }
        
        public DbSet<User> Users {get;set;}
    }
}