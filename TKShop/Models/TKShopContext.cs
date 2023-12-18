using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TKShop.Models
{
    public partial class TKShopContext : DbContext
    {
        public TKShopContext()
        {
        }

        public TKShopContext(DbContextOptions<TKShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Inventory> Inventories { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Return> Returns { get; set; } = null!;
        public virtual DbSet<Shipping> Shippings { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<Wishlist> Wishlists { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builer = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration root = builer.Build();
            optionsBuilder.UseSqlServer(root.GetConnectionString("TKShop"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_id");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(255)
                    .HasColumnName("address_line_1");

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(255)
                    .HasColumnName("address_line_2");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .HasColumnName("city");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.District)
                    .HasMaxLength(100)
                    .HasColumnName("district");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(20)
                    .HasColumnName("postal_code");

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(100)
                    .HasColumnName("recipient_name");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Address__custome__628FA481");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("Brand");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_id");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("brand_name");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Brands)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Brand__category___5535A963");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("category_name");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.Property(e => e.CouponId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coupon_id");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("coupon_code");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("discount_amount");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expiration_date");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("account_type");

                entity.Property(e => e.Address)
                    .HasColumnType("text")
                    .HasColumnName("address");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Commune)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("commune");

                entity.Property(e => e.CountryId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("country_id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("date")
                    .HasColumnName("date_of_birth");

                entity.Property(e => e.District)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("district");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.ToTable("Inventory");

                entity.Property(e => e.InventoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("inventory_id");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_id");

                entity.Property(e => e.PurchasePrice)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("purchase_price");

                entity.Property(e => e.QuantityInStock).HasColumnName("quantity_in_stock");

                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_id");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Inventory__produ__49C3F6B7");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Inventories)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__Inventory__suppl__4AB81AF0");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_id");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.Note)
                    .HasMaxLength(200)
                    .HasColumnName("note");

                entity.Property(e => e.OrderDate)
                    .HasColumnType("date")
                    .HasColumnName("order_date");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_status");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("total_amount");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__customer__3B75D760");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_id");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Image)
                    .HasColumnType("image")
                    .HasColumnName("image");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("product_name");

                entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__Products__catego__3E52440B");
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.Property(e => e.ReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("return_id");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_id");

                entity.Property(e => e.ReturnDate)
                    .HasColumnType("date")
                    .HasColumnName("return_date");

                entity.Property(e => e.ReturnReason)
                    .HasColumnType("text")
                    .HasColumnName("return_reason");

                entity.Property(e => e.ReturnStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("return_status");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Returns__custome__52593CB8");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Returns__order_i__5165187F");
            });

            modelBuilder.Entity<Shipping>(entity =>
            {
                entity.ToTable("Shipping");

                entity.Property(e => e.ShippingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shipping_id");

                entity.Property(e => e.AddressId)
                    .HasMaxLength(50)
                    .HasColumnName("address_id");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("order_id");

                entity.Property(e => e.ShippingDate)
                    .HasColumnType("date")
                    .HasColumnName("shipping_date");

                entity.Property(e => e.ShippingStatus).HasColumnName("shipping_status");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shippings)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__Shipping__order___412EB0B6");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supplier_id");

                entity.Property(e => e.ContactInfo)
                    .HasColumnType("text")
                    .HasColumnName("contact_info");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supplier_name");
            });

            modelBuilder.Entity<Wishlist>(entity =>
            {
                entity.ToTable("Wishlist");

                entity.Property(e => e.WishlistId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("wishlist_id");

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_id");

                entity.Property(e => e.ProductId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("product_id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Wishlist__custom__4D94879B");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Wishlists)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Wishlist__produc__4E88ABD4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
