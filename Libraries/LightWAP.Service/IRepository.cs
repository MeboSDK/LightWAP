using LightWAP.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LightWAP.Services
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task InsertAsync(TEntity obj);
        Task UpdateAsync(TEntity obj);
        Task DeleteAsync(TEntity existing);
        Task<IList<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(object id);
        Task SaveAsync();
    }
}
