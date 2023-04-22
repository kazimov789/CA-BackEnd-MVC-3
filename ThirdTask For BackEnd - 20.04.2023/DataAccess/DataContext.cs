using Microsoft.EntityFrameworkCore;
using ThirdTask_For_BackEnd___20._04._2023.Models;

namespace ThirdTask_For_BackEnd___20._04._2023.DataAccess
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        public DbSet<FeatureForHome> FeatureForHome { get; set; }
        public DbSet<FeatureForService> FeatureForService { get; set; }
        public DbSet<Slider> Slider { get; set; }
    }

}