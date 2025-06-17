using MedicineProject.Data.Entities.BaseEntities;

namespace MedicineProject.Core.Repository.IRepository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetByIdAsync(string id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> Delete(string id);
        Task<List<TEntity>> UpdateRange(List<TEntity> entities);
        Task<bool> SaveChangesAsync();
    }
}
