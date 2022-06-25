using System.Collections.Generic;
using System.Threading.Tasks;

namespace gelateca.solidaria.domain.Interfaces;

internal interface IEntityBase<T>
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(int? id);
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<T> Remove(T entity);
}
