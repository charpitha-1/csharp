using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DbFirst;

public partial class BlogAppDelContext : DbContext
{
    public BlogAppDelContext()
    {
    }

    public BlogAppDelContext(DbContextOptions<BlogAppDelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BlogComment> BlogComments { get; set; }

    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=WKSCHE03TRNG078\\SQLEXPRESS;Initial Catalog=BlogAppDel;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BlogComment>(entity =>
        {
            entity.HasKey(e => e.CommentId);

            entity.ToTable("BlogComment");

            entity.Property(e => e.CommentBy)
                .HasMaxLength(50)
                .HasColumnName("commentBy");
            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Post).WithMany(p => p.BlogComments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BlogComment_BlogPost");
        });

        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.HasKey(e => e.PostId);

            entity.ToTable("BlogPost");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.PostedBy).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
