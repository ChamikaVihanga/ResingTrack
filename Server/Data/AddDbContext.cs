using Microsoft.EntityFrameworkCore;
using PNRT.Shared.Entites;

namespace PNRT.Server.Data
{
    public class AddDbContext : DbContext 
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) 
        {

        } 
       public DbSet<Rider> Riders { get; set; }
       public DbSet<Club> Clubs { get; set; }
       public DbSet<FirstAid> FirstAids { get; set; }
       public DbSet<Event> Events { get; set; }


    }
}
