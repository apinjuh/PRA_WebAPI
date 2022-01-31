using PRA_WebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PRA_WebAPI.DataBase
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T Entity);
        Task<T> Delete(int id);


        Task<List<T>> Filter(Expression<Func<T, bool>> where);

    }
}
