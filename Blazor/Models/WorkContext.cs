using Microsoft.EntityFrameworkCore;

namespace Blazor.Models;

public class WorkContext : DbContext
{
    public WorkContext(DbContextOptions<WorkContext> options) : base(options) { }

    public DbSet<WorkDays> WorkDays { get; set; } // Example entity
}