using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RRF.DateTimeWrapper.Abstract;
using RRF.EFModels;
using RRF.EFModels.Abstract;
using RRF.EFModelsConfig;
using RRF.EFSeed;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RRF.RRFDbContext
{
    public class RRFDbContext : DbContext
    {
        private readonly DateTime dateTimeProvider;

        public DbSet<Client> Clients { get; set; }
        public DbSet<RssChannel> RssChannels { get; set; }
        public DbSet<RssSetting> RssSettings { get; set; }
        public DbSet<XElementModel> XElementsModels { get; set; }
        public DbSet<ModelElement> ModelElements { get; set; }
        public DbSet<ImageElement> ImageElements { get; set; }
        public DbSet<DescendingElement> DescendingElements { get; set; }

        public RRFDbContext()
        {
        }

        public RRFDbContext(DbContextOptions<RRFDbContext> option) : base(option)
        {
            this.dateTimeProvider = DateTime.Now;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<IdentityRole>().HasData(this.SeedDefaultRoles());

            builder.Entity<Client>().HasData(EFSeed.EFSeed.SeedDefaultClient());
            builder.Entity<RssChannel>().HasData(EFSeed.EFSeed.SeedRssChannels());
            builder.Entity<RssSetting>().HasData(EFSeed.EFSeed.SeedRssSettings());
            builder.Entity<DescendingElement>().HasData(EFSeed.EFSeed.SeedDescendantElements());
            builder.Entity<ModelElement>().HasData(EFSeed.EFSeed.SeedModelElements());
            builder.Entity<XElementModel>().HasData(EFSeed.EFSeed.SeedXElementsModels());

            this.ApplyModelConfigurations(builder);
            this.SeedDefaultAdmin(builder);

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        private void ApplyModelConfigurations(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ClientConfig());
            builder.ApplyConfiguration(new RssSettingsConfig());     
            builder.ApplyConfiguration(new RssChanelConfig());
           
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            this.ApplyDeletionRules();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ApplyAuditInfoRules();
            this.ApplyDeletionRules();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ApplyDeletionRules()
        {
            var entitiesForDeletion = this.ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Deleted && e.Entity is IDeletable);

            foreach (var entry in entitiesForDeletion)
            {
                var entity = (IDeletable)entry.Entity;
                entity.DeletedOn = this.dateTimeProvider;
                entity.IsDeleted = true;
                entry.State = EntityState.Modified;
            }
        }

        private void ApplyAuditInfoRules()
        {
            var newlyCreatedEntities = this.ChangeTracker.Entries()
                .Where(e => e.Entity is IModifiable && ((e.State == EntityState.Added) || (e.State == EntityState.Modified)));

            foreach (var entry in newlyCreatedEntities)
            {
                var entity = (IModifiable)entry.Entity;

                if (entry.State == EntityState.Added && entity.CreatedOn == null)
                {
                    entity.CreatedOn = this.dateTimeProvider;
                }
                else
                {
                    entity.ModifiedOn = this.dateTimeProvider;
                }
            }
        }

        private IdentityRole[] SeedDefaultRoles()
        {
            var administrator = new IdentityRole() { Id = "1", Name = "Administrator", NormalizedName = "ADMINISTRATOR" };
            var client = new IdentityRole() { Id = "2", Name = "Client", NormalizedName = "CLIENT" };

            return new IdentityRole[] { administrator, client };
        }

        private void SeedDefaultAdmin(ModelBuilder builder)
        {
            var adminUser = new Client
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                NormalizedUserName = "admin@mail.com".ToUpper(),
                Email = "admin@mail.com",
                TwoFactorEnabled = false,
                NormalizedEmail = "admin@mail.com".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "+359359",
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString("D"),
                AccessFailedCount = 0,
                LockoutEnabled = false
            };

            var hashePass = new PasswordHasher<Client>().HashPassword(adminUser, "!Aa12345678");
            adminUser.PasswordHash = hashePass;

            builder.Entity<Client>().HasData(adminUser);

            //builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = 1.ToString(),
            //    UserId = adminUser.Id
            //});
        }
    }
}