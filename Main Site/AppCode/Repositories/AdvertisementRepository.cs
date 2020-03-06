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
    public class AdvertisementRepository : AbstractRepository, IRepository<Advertisement>
    {
        public AdvertisementRepository(HEZZALDBContext db)
            : base(db) { }
        public Advertisement Add(Advertisement entity)
        {
            db.Advertisements.Add(entity);
            return entity;
        }

        public void Delete(Advertisement entity)
        {
            db.Advertisements.Remove(entity);
        }

        public Advertisement Edit(Advertisement entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<Advertisement> GetAll(Expression<Func<Advertisement, bool>> predicate = null)
        {
            if (predicate != null)
                return db.Advertisements.Where(predicate);

            return db.Advertisements.AsQueryable();
        }

        public Advertisement GetById(int id)
        {
            return db.Advertisements.Find(id);
        }

        public async Task<Advertisement> GetByIdAsync(int id)
        {
            return await db.Advertisements.FindAsync(id);
        }
    }
}
