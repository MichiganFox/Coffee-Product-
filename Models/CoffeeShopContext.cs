using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Coffee.Models;

public partial class CoffeeShopContext : DbContext
{
    public CoffeeShopContext()
    {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CoffeeShop> CoffeeShops { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=CoffeeShop; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CoffeeShop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CoffeeSh__3214EC0770A0FB22");

            entity.ToTable("CoffeeShop");

            entity.Property(e => e.Drink).HasMaxLength(50);
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Post__3214EC071A152045");

            entity.ToTable("Post");

            entity.Property(e => e.Drink).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
