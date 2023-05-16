using DiscussionMvcNewman.Data;
using LibraryGroup13;
using Microsoft.AspNetCore.Identity;

namespace MvcGroup13.Data.Migrations
{
    public class InitialDatabase
    {
        public static void SeedDatabase(IServiceProvider services)
        {
            ApplicationDbContext database = services.GetRequiredService<ApplicationDbContext>();

            UserManager<AppUser> userManager = services.GetRequiredService<UserManager<AppUser>>();

            RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            string adminRole = "Admin";
            string basicUserRole = "BasicUser";

            if(!database.Roles.Any())
            {
                IdentityRole role = new IdentityRole(adminRole);
                roleManager.CreateAsync(role).Wait();

                role = new IdentityRole(basicUserRole);
                roleManager.CreateAsync(role).Wait();
            }
            if(!database.AppUser.Any())
            {
                AppUser admin = new AppUser("Test Admin 1", "Test.Admin1@test.com", "7173157818", "Test.Admin1");
                userManager.CreateAsync(admin).Wait();
                userManager.AddToRoleAsync(admin, adminRole).Wait();

                AppUser basicUser = new AppUser("Test basic User 1", "Test.BasicUser1@test.com", "7173150000", "Test.BasicUser1");
                userManager.CreateAsync(basicUser).Wait();
                userManager.AddToRoleAsync(basicUser, basicUserRole).Wait();

            }
            //if(!database.Admin.Any())
            //{
            //    Admin admin = new Admin("Test Admin 1", "Test.Admin1@test.com", "7173157818", "Test.Admin1");
            //    userManager.CreateAsync(admin).Wait();
            //    userManager.AddToRoleAsync(admin, adminRole).Wait();

            //    //BasicUser basicUser = new BasicUser("Test basic User 1", "Test.BasicUser1@test.com", "7173150000", "Test.BasicUser1");
            //    //userManager.CreateAsync(basicUser).Wait();
            //    //userManager.AddToRoleAsync(basicUser, basicUserRole).Wait();


            //}
            //if (!database.BasicUser.Any())
            //{
            //    BasicUser basicUser = new BasicUser("Test basic User 1", "Test.BasicUser1@test.com", "7173150000", "Test.BasicUser1");
            //    userManager.CreateAsync(basicUser).Wait();
            //    userManager.AddToRoleAsync(basicUser, basicUserRole).Wait();
            //}


            if (!database.Location.Any())
            {
                double Latitude = 1.1111;
                double Longitude = 1.1111;

                Location location = new Location("location1", Latitude, Longitude, "description");
                database.Location.Add(location);
                database.SaveChanges();

                location = new Location("location2", 1.11111,1.11111,"description");
                database.Location.Add(location);
                database.SaveChanges();
            }

            //if (!database.TourTime.Any())
            //{
            //    TourTime createTourTime = new TourTime("In Person", "Matt", new DateTime(2023, 12, 1));
            //    database.TourTime.Add(createTourTime);
            //    database.SaveChanges();

            //    createTourTime = new TourTime("Online", "Noah", new DateTime(2023, 12, 2));
            //    database.TourTime.Add(createTourTime);
            //    database.SaveChanges();
            //}
        }
    }
}
