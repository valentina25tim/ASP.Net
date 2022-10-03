using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace IlCats_Application.Contracts
{
    public interface  IAsyncRepository<T> 
        where T: class

    {
        Task<T> GetByIdAsync(int id, CancellationToken ct);
        Task<IReadOnlyList<T>> ListAllAsync(CancellationToken ct);
        Task<T> AddAsync(T entity, CancellationToken ct);
        Task<T> UpdateAsync(T entity, CancellationToken ct);
        Task<T> DeleteAsync(T entity, CancellationToken ct);
        Task GetAsync(Func<object, bool> value);
    }
}
