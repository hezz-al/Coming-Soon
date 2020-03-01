using MainSite.Models.DataContext;
using System.Threading.Tasks;

namespace MainSite.AppCode.Repositories
{
    public class AbstractRepository
    {
        protected readonly HEZZALDBContext db;

        public AbstractRepository(HEZZALDBContext db)
        {
            this.db = db;
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
        public Task<int> SaveChangesAsync()
        {
            return db.SaveChangesAsync();
        }
    }
}
