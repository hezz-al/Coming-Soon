using MainSite.AppCode.Infrastructure;
using MainSite.Models.DataContext;
using MainSite.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MainSite.AppCode.Repositories
{
    public class SettingRepository : AbstractRepository, IRepository<Setting>
    {
        public SettingRepository(HEZZALDBContext db)
            : base(db) { }
        public Setting Add(Setting entity)
        {
            db.Settings.Add(entity);
            return entity;
        }

        public void Delete(Setting entity)
        {
            db.Settings.Remove(entity);
        }

        public Setting Edit(Setting entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<Setting> GetAll(Expression<Func<Setting, bool>> predicate = null)
        {
            if (predicate != null)
                return db.Settings.Where(predicate);

            return db.Settings.AsQueryable();
        }

        public Setting GetById(int id)
        {
            return db.Settings.Find(id);
        }

        public async Task<Setting> GetByIdAsync(int id)
        {
            return await db.Settings.FindAsync(id);
        }
    }
}
