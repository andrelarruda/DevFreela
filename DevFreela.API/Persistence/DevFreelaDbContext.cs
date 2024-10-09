using DevFreela.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.API.Persistence
{
    public class DevFreelaDbContext : DbContext
    {
        public DevFreelaDbContext(DbContextOptions<DevFreelaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<ProjectComment> ProjectComments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(u => u.Id);

            builder.Entity<Project>()
                .HasKey(p => p.Id);

            builder.Entity<Skill>()
                .HasKey(s => s.Id);

            builder.Entity<Project>()
                .HasOne(p => p.Client)
                .WithMany(c => c.OwnedProjects)
                .HasForeignKey(p => p.IdClient);

            builder.Entity<Project>()
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer);

            builder.Entity<Project>()
                .HasMany(p => p.Comments)
                .WithOne(pc => pc.Project);

            builder.Entity<UserSkill>()
                .HasKey(us => new { us.IdUser, us.IdSkill });

            builder.Entity<UserSkill>()
                .HasOne(us => us.User)
                .WithMany(u => u.Skills)
                .HasForeignKey(us => us.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<UserSkill>()
                .HasOne(us => us.Skill)
                .WithMany(s => s.UserSkills)
                .HasForeignKey(us => us.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>(u => {
                u.HasMany(u => u.Skills)
                .WithOne(us => us.User)
                .HasForeignKey(u => u.IdUser)
                .OnDelete(DeleteBehavior.Restrict);
                
            });

            builder.Entity<ProjectComment>(e =>
            {
                e.HasKey(p => p.Id);


            });

            //builder
            //    .Entity<Skill>(e =>
            //    {
            //        e.HasKey(s => s.Id);
            //    });

            //builder
            //    .Entity<UserSkill>(e => {
            //        e.HasKey(us => us.Id);

            //        e.HasOne(u => u.Skill)
            //            .WithMany(u => u.UserSkills)
            //            .HasForeignKey(s => s.IdSkill)
            //            .OnDelete(DeleteBehavior.Restrict);

            //        //e.HasOne(u => u.User)
            //        //    .WithMany(u => u.Skills)
            //        //    .HasForeignKey(us => us.IdUser)
            //        //    .OnDelete(DeleteBehavior.Restrict);
            //    });

            //builder
            //    .Entity<ProjectComment>(e =>
            //    {
            //        e.HasKey(p => p.Id); 

            //        e.HasOne(p => p.Project)
            //            .WithMany(pr => pr.Comments)
            //            .HasForeignKey(x => x.IdProject)
            //            .OnDelete(DeleteBehavior.Restrict);
            //    });

            //builder
            //    .Entity<User>(e =>
            //    {
            //        e.HasKey(us => us.Id);

            //        e.HasMany(u => u.Skills)
            //            .WithOne(us => us.User)
            //            .HasForeignKey(us => us.IdUser)
            //            .OnDelete(DeleteBehavior.Restrict);
            //    });

            

            //base.OnModelCreating(builder);

        }
    }
}
