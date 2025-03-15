using BalanceMate.DataAccess.Models.Incomes;
using BalanceMate.Utilities;
using Humanizer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Define your tables here
    public DbSet<Income> Incomes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        foreach (var entity in modelBuilder.Model.GetEntityTypes())
        {
            var tableName = entity.GetTableName();

            // Convert table names to snake_case
            if (tableName != null && !entity.IsOwned()) // Ignore owned types
            {
                entity.SetTableName(StringUtilities.ToSnakeCase(tableName.Pluralize())); // Pluralize + snake_case
            }

            foreach (var property in entity.GetProperties())
            {
                // Convert column names to snake_case
                property.SetColumnName(StringUtilities.ToSnakeCase(property.GetColumnName()));
            }
        }
    }
}
