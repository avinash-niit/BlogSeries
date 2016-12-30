namespace WebAPI.Projects.Setup.Models
{
    using System.Data.Entity;

    public partial class ProjectsContext : DbContext
    {
        public ProjectsContext()
            : base("name=ProjectsContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectSkill> ProjectSkills { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .Property(e => e.RowVersion)
                .IsFixedLength();

            modelBuilder.Entity<Project>()
                .HasMany(e => e.ProjectSkills)
                .WithRequired(e => e.Project)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Skill>()
                .HasMany(e => e.ProjectSkills)
                .WithRequired(e => e.Skill)
                .WillCascadeOnDelete(false);
        }
    }
}
