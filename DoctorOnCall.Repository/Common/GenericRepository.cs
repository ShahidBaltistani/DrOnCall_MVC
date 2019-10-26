using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DoctorOnCall.Repository.Common
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DoctorOnCallContext db;
        private DbSet<T> table;
        public GenericRepository()
        {
            this.db = new DoctorOnCallContext();
            this.table = db.Set<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                this.table.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int? id)
        {
            try
            {
                var temp = table.Find(id);
                if (temp == null) return false;
                this.table.Remove(temp);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public ICollection<T> Get()
        {
            return table.ToList();
        }

        public T Get(int? id)
        {
            return this.table.Find(id);
        }
        public T Get(Func<T,bool> query)
        {
            return this.table.Where(query).FirstOrDefault();
        }

        public bool Update(T entity)
        {
            try
            {
                this.db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

    }
}
