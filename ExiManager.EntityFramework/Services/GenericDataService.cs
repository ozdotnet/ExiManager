using ExiManager.Shared.Model;
using ExiManager.Shared.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExiManager.EntityFramework.Services
{
    //Enntity Frameworks DbContext is not thread safe. Create a new DbContext for each CRUD operation
    public class GenericDataService<T> : IDataService<T> where T : class, IDomainObject
    {
        private readonly ExiManagerDbContextFactory _exiManagerDbContextFactory;

        public GenericDataService(ExiManagerDbContextFactory exiManagerDbContextFactory)
        {
            _exiManagerDbContextFactory = exiManagerDbContextFactory;
        }

        public async Task<T> Create(T entity)
        {
            using (var dbContext = _exiManagerDbContextFactory.CreateDbContext())
            {
                var createdResult = await dbContext.Set<T>().AddAsync(entity);
                await dbContext.SaveChangesAsync();

                return createdResult.Entity;
            }
        }

        public async Task<bool> Delete(int id)
        {
            using (var dbContext = _exiManagerDbContextFactory.CreateDbContext())
            {
                T entity = await dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                dbContext.Set<T>().Remove(entity);
                await dbContext.SaveChangesAsync();

                return true;
            }
        }

        public async Task<T> Get(int id)
        {
            using (var dbContext = _exiManagerDbContextFactory.CreateDbContext())
            {
                T entity = await dbContext.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
                
                return entity;
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            using (var dbContext = _exiManagerDbContextFactory.CreateDbContext())
            {
                var entities = await dbContext.Set<T>().ToListAsync();

                return entities;
            }
        }

        public async Task<T> Update(int id, T entity)
        {
            using (var dbContext = _exiManagerDbContextFactory.CreateDbContext())
            {
                entity.Id = id;
                dbContext.Set<T>().Update(entity);
                await dbContext.SaveChangesAsync();

                return entity; ;
            }
        }
    }
}
