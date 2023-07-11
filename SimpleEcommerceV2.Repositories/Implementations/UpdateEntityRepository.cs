﻿using Microsoft.EntityFrameworkCore;
using SimpleEcommerceV2.Repositories.Contracts;

namespace SimpleEcommerceV2.Repositories.Implementations
{
    public class UpdateEntityRepository<TEntity> : IUpdateEntityRepository<TEntity>
        where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly DbContext _databaseContext;

        public UpdateEntityRepository(DbContext databaseContext)
        {
            _dbSet = databaseContext.Set<TEntity>();
            _databaseContext = databaseContext;
        }

        public async Task<TEntity> ExecuteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _dbSet.Update(entity);
            await _databaseContext.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}
