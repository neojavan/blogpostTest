using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace blogPostTest.Models
{
    public partial class blogpostTestContext : DbContext
    {
        public blogpostTestContext()
        {
        }

        public blogpostTestContext(DbContextOptions<blogpostTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionByProfile> PermissionByProfiles { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=PAOLAPC\\MSSQLSERVER2;Database=blogpostTest;Trusted_Connection=True;");
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.HasKey(e => e.PermsId);

                entity.ToTable("permissions");

                entity.Property(e => e.PermsId).HasColumnName("perms_id");

                entity.Property(e => e.PermsAction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("perms_action");
            });

            modelBuilder.Entity<PermissionByProfile>(entity =>
            {
                entity.HasKey(e => e.PbpId);

                entity.ToTable("permissionByProfile");

                entity.Property(e => e.PbpId).HasColumnName("pbp_id");

                entity.Property(e => e.PbpPermId).HasColumnName("pbp_permId");

                entity.Property(e => e.PbpProfId).HasColumnName("pbp_profId");

                entity.HasOne(d => d.PbpPerm)
                    .WithMany(p => p.PermissionByProfiles)
                    .HasForeignKey(d => d.PbpPermId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_permissionByProfile_permissions");

                entity.HasOne(d => d.PbpProf)
                    .WithMany(p => p.PermissionByProfiles)
                    .HasForeignKey(d => d.PbpProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_permissionByProfile_profiles");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("posts");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostContent)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("post_content");

                entity.Property(e => e.PostCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("post_created");

                entity.Property(e => e.PostPublished)
                    .HasColumnType("datetime")
                    .HasColumnName("post_published");

                entity.Property(e => e.PostStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("post_status");

                entity.Property(e => e.PostSummary)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("post_summary");

                entity.Property(e => e.PostTitle)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("post_title");

                entity.Property(e => e.PostUpdated)
                    .HasColumnType("datetime")
                    .HasColumnName("post_updated");

                entity.Property(e => e.PostUsrId).HasColumnName("post_usrId");

                entity.HasOne(d => d.PostUsr)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.PostUsrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_posts_users");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.ProfId);

                entity.ToTable("profiles");

                entity.Property(e => e.ProfId).HasColumnName("prof_id");

                entity.Property(e => e.ProfName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("prof_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UsrId);

                entity.ToTable("users");

                entity.Property(e => e.UsrId).HasColumnName("usr_id");

                entity.Property(e => e.UsrFirstname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("usr_firstname");

                entity.Property(e => e.UsrLastname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("usr_lastname");

                entity.Property(e => e.UsrLogin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("usr_login");

                entity.Property(e => e.UsrMobile)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("usr_mobile");

                entity.Property(e => e.UsrPassword)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("usr_password");

                entity.Property(e => e.UsrProfId).HasColumnName("usr_profId");

                entity.Property(e => e.UsrRegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("usr_registerDate");

                entity.HasOne(d => d.UsrProf)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UsrProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_users_profiles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
