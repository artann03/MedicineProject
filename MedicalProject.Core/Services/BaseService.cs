using MedicineProject.Core.Repository.IRepository;
using MedicineProject.Core.Services.IServices;
using MedicineProject.Data.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<TEntity> GetByIdAsync(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    return null;

                var entity = await _baseRepository.GetByIdAsync(id);
                if (entity == null)
                    return null;

                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                var entities = await _baseRepository.GetAllAsync();
                if (!entities.Any())
                {
                    return new();
                }

                return entities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                if (entity == null)
                    return null;

                entity = await _baseRepository.Update(entity);
                await _baseRepository.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {
                if (entity == null)
                    return null;

                entity = await _baseRepository.AddAsync(entity);

                await _baseRepository.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public async Task<TEntity> DeleteAsync(string id)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(id))
                    return null;

                var entity = await _baseRepository.Delete(id);
                if (entity == null)
                    return null;

                await _baseRepository.SaveChangesAsync();
                return entity;
            }
            catch (Exception ex) 
            {
                return null;
            }
        }

        public async Task<List<TEntity>> UpdateRange(List<TEntity> entities)
        {
            try
            {
                if (!entities.Any())
                    return null;

                entities = await _baseRepository.UpdateRange(entities);
                if (entities == null)
                    return null;

                await _baseRepository.SaveChangesAsync();
                return entities;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
