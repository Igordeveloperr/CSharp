using System.Data.Entity;

namespace first_mvc.Models
{
    public class WeightContext : DbContext
    {
        public DbSet<WeightModel> Weights { get; set; }
    }
}
