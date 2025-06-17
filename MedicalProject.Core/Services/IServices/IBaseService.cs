using MedicineProject.Data.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Core.Services.IServices
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(string id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<List<TEntity>> UpdateRange(List<TEntity> entities);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> DeleteAsync(string id);

    }
}
