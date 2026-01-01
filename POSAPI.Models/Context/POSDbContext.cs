using Microsoft.EntityFrameworkCore;
using POSAPI.Models.Models;

namespace POSAPI.Models.Context;

public class POSDbContext : DbContext
{
    public POSDbContext(DbContextOptions<POSDbContext> options) : base(options)
    {

    }

    public DbSet<InvoiceInfo> InvoiceInfos { get; set; }
    public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
}
