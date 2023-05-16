using LibraryGroup13;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcGroup13.Data.Migrations;

namespace DiscussionMvcNewman.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<AppUser> AppUser { get; set; }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<BasicUser> BasicUser { get; set; }

        public DbSet<Campus> Campus { get; set; }

        public DbSet<Images> Images { get; set; }

        public DbSet<Location> Location { get; set; }

        public DbSet<InPersonTourSchedule> InPersonTourSchedule { get; set; }

        public DbSet<TourTime> TourTime { get; set; }
     

      



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}