using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace basic_element_database.Repository.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<IQueryable<T>> FindAll();
        Task <IQueryable<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
