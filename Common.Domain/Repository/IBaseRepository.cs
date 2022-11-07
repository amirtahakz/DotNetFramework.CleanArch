using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T?> GetAsync(Guid id);

        Task<T?> GetTracking(Guid id);

        void Add(T entity);

        void AddRange(ICollection<T> entities);

        void Update(T entity);


        Task<int> Save();

        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);
        bool Exists(Expression<Func<T, bool>> expression);
    }
}
