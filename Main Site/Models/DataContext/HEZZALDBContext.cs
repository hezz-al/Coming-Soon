using MainSite.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace MainSite.Models.DataContext
{
    public class HEZZALDBContext :DbContext
{
		public HEZZALDBContext(DbContextOptions options)
			: base(options)
		{

		}
		public DbSet <Setting> Settings { get; set; }
		public DbSet <Advertisement> Advertisements { get; set; }

	}
}
