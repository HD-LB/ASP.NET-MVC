using Microsoft.AspNet.Identity.EntityFramework;
using MK.ForumSystem.Data.Models;
using MK.ForumSystem.Data.Models.Contracts;
using System;
using System.Data.Entity;
using System.Linq;

namespace MK.ForumSystem.Data
{
    public class MsSqlDbContext : IdentityDbContext<User>
    {
        public MsSqlDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Post> Posts { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            foreach (var entry in this.ChangeTracker.Entries().Where(e => e.Entity is IAuditable && ((e.State == EntityState.Added) || e.State == EntityState.Modified)))
            {
                var entity = (IAuditable)entry.Entity;

                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        public static MsSqlDbContext Create()
        {
            return new MsSqlDbContext();
        }
    }
}
