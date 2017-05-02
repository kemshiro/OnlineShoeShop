namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShoeDbContext : DbContext
    {
        public OnlineShoeDbContext()
            : base("name=OnlineShoe")
        {
        }

        public virtual DbSet<About> About { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<ContentTag> ContentTag { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Footer> Footer { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MenuType> MenuType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Slide> Slide { get; set; }
        public virtual DbSet<SystemConfig> SystemConfig { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<About>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<About>()
                .Property(e => e.metaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Category>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.metaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Content>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Content>()
                .Property(e => e.metaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<ContentTag>()
                .Property(e => e.tagID)
                .IsUnicode(false);

            modelBuilder.Entity<Footer>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.promotionPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Product>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.metaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.metaTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.metaDescriptions)
                .IsFixedLength();

            modelBuilder.Entity<Slide>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<Slide>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<SystemConfig>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.createdBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.modifiedBy)
                .IsUnicode(false);
        }
    }
}
