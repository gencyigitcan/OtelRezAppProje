using OtelRezAppProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezAppProje.Repositories
{
    public class Repository<T> where T : class, new()
    {
        Db_OtelRezAppEntities db = new Db_OtelRezAppEntities();

        public List <T> GetAll()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id) 
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate()
        {
            db.SaveChanges();
        }
        public T Find(Expression<Func<T, bool>> where) 
        {
            return db.Set<T>().FirstOrDefault(where);
        }
    }
}
