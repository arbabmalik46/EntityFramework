using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstWithExistingDB
{
    public partial class ExistingDB : DbContext
    {
        public ExistingDB()
            : base("ExistingDB")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<VideoGenreAssociation> VideoGenreAssociation { get; set; }
        public virtual DbSet<Videos> Videos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Authors)
                .HasForeignKey(e => e.Author_Id);

            modelBuilder.Entity<Courses>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Courses)
                .Map(m => m.ToTable("TagCourses").MapLeftKey("Course_Id").MapRightKey("Tag_Id"));

            modelBuilder.Entity<Genre>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Videos>()
                .Property(e => e.VideoName)
                .IsFixedLength();
        }
    }
}
