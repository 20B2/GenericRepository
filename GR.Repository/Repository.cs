using GR.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GR.Repository
{
    class Repository<T> : IRepository<T> where T : class
    {
        private ForumContext db = new ForumContext();
        public void Create(T entity)
        {
            //db.Users.Add(users);
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            //db.Users.Remove(users);
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public IQueryable<T> Read()
        {
            return db.Set<T>().AsQueryable();
        }

        public void Update(T entity)
        {
            //db.Entry(users).State = EntityState.Modified;
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
