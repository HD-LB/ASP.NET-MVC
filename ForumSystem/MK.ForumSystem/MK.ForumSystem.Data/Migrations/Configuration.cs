namespace MK.ForumSystem.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MK.ForumSystem.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<MK.ForumSystem.Data.MsSqlDbContext>
    {
        const string AdministratorUserName = "maria";

        const string AdministratorPassword = "123456";

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(MK.ForumSystem.Data.MsSqlDbContext context)
        {
            this.SeedAdmin(context);
        }

        
        private void SeedAdmin(MsSqlDbContext context)
        {

            if (!context.Roles.Any())
            {
                var roleName = "Admin";

                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = "Admin" };
                roleManager.CreateAsync(role);

                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User { UserName = AdministratorUserName, Email = AdministratorUserName, EmailConfirmed = true, CreatedOn = DateTime.Now };

                userManager.Create(user, AdministratorPassword);
                userManager.AddToRole(user.Id, "Admin");

            }
        }

        private void SeedSampleData(MsSqlDbContext context)
        {
            if (!context.Posts.Any())
            {
                for (int i = 0; i < 5; i++)
                {
                    var post = new Post()
                    {
                        Titel = "Post" + i,
                        Content = " Trala la  Trala la Trala la  Trala la  Trala la  Trala la Trala la Trala la Trala la Trala la Trala la Trala la Trala la Trala la Trala la ",
                        Author = context.Users.First(x => x.Email == AdministratorUserName),
                        CreatedOn = DateTime.Now
                    };

                    context.Posts.Add(post);
                }
            }
        }
    }
}
