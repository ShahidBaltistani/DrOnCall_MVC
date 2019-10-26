using System.Collections.Generic;

namespace DoctorOnCall.Repository.Common
{
    public interface IGenericRepository<T>
    {
        bool Add(T entity);
        bool Delete(int? id);
        bool Update(T entity);
        ICollection<T> Get();
        T Get(int? id);
    }
}