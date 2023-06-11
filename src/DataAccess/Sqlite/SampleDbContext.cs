using DataAccess.DataItems;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class SampleDbContext : DbContext
{
    public DbSet<DataItemEntity> DataItems { get; set; } = null!;
}