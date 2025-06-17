using MedicineProject.Core.DbContexts;
using MedicineProject.Core.Repository.IRepository;
using MedicineProject.Data.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace MedicineProject.Core.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly MedicineProjectDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public BaseRepository(MedicineProjectDbContext dbContext) 
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            return await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TEntity> Update(TEntity entity)
        {
            _dbSet.Update(entity);
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            return (await _dbSet.AddAsync(entity)).Entity;
        } 

        public async Task<TEntity> Delete(string id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
            if (entity == null)
                return null;

            entity.IsDeleted = true;
            entity.UpdatedOn = DateTime.UtcNow;
            _dbSet.Update(entity);
            return entity;
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
            return entities;
        }

        public async Task<bool> SaveChangesAsync()
        {
            var isSuccess = await _dbContext.SaveChangesAsync();
            return isSuccess > 0;
        }
    }
}
