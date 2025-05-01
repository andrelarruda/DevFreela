using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Core.Persistence
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
            builder
                .Entity<Skill>(e =>
                {
                    e.HasKey(s => s.Id);
                });

            builder
                .Entity<User>(e =>
                {
                    e.HasKey(us => us.Id);
                });

            builder.Entity<User>()
                .HasMany(u => u.OwnedProjects)
                .WithOne(p => p.Client)
                .HasForeignKey(e => e.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<User>()
                .HasMany(u => u.FreelanceProjects)
                .WithOne(p => p.Freelancer)
                .HasForeignKey(e => e.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<UserSkill>(e =>
                {
                    e.HasKey(us => us.Id);

                    e.HasOne(e => e.User)
                        .WithMany(e => e.Skills)
                        .HasForeignKey(us => us.UserId)
                        .OnDelete(DeleteBehavior.Restrict);

                    e.HasOne(u => u.Skill)
                        .WithMany(u => u.UserSkills)
                        .HasForeignKey(s => s.SkillId)
                        .OnDelete(DeleteBehavior.Restrict);
                });

            builder
                .Entity<ProjectComment>(e =>
                {
                    e.HasKey(p => p.Id);

                    e.HasOne(p => p.Project)
                        .WithMany(pr => pr.Comments)
                        .HasForeignKey(x => x.projectId)
                        .OnDelete(DeleteBehavior.Restrict);

                    e.HasOne(c => c.User)
                        .WithMany(u => u.Comments)
                        .HasForeignKey(e => e.userId)
                        .OnDelete(DeleteBehavior.Restrict);
                });


            base.OnModelCreating(builder);
        }
    }
}
