using EF_FluentAPIEntityConfiguration.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_FluentAPIEntityConfiguration.Data;

public class FluentAPIEntityConfigurationDbContext : DbContext
{
    public FluentAPIEntityConfigurationDbContext(DbContextOptions<FluentAPIEntityConfigurationDbContext> options): base(options){}
    
    // DbSets
    public DbSet<Customer> customers { get; set; } = null!;
    
    public DbSet<CustomerProfile> customer_profiles { get; set; } = null!;
    
    public DbSet<Address> addresses { get; set; } = null!;
    
    public DbSet<Product> products { get; set; } = null!;
    
    public DbSet<Category> categories { get; set; } = null!;
    
    public DbSet<ProductCategory> product_categories { get; set; } = null!;
    
    public DbSet<Order> orders { get; set; } = null!;
    
    public DbSet<OrderItem> order_items { get; set; } = null!;
    
    public DbSet<Payment> payments { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    
    // Customer
    private void ConfigureCustomer(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("customers", "sales");

            entity.HasKey(c => c.id);
            
            // Alternate key (Business identifier)
            entity.HasAlternateKey(c => c.customer_number)
                .HasName("ak_customers_customer_number");
            
            // Indexes
            entity.HasIndex(c => c.email)
                .HasDatabaseName("ix_customers_email");
            
            entity.HasIndex(c => c.phone_number)
                .HasDatabaseName("ix_customers_phone_number");
            
            // One-to-many: Customer -> Addresses
            entity.HasMany(c => c.addresses)
                .WithOne(a => a.customer)
                .HasForeignKey(a => a.customer_id)
                .OnDelete(DeleteBehavior.Cascade);
            
            // Table splitting
            entity.HasOne(c => c.profile)
                .WithOne(p => p.customer)
                .HasForeignKey<CustomerProfile>(p => p.customer_id);
        });
    }

    // Customer profile (Table splitting)
    public void ConfigureCustomerProfile(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomerProfile>(entity =>
        {
            entity.ToTable("customers", "sales");
        });
    }
}