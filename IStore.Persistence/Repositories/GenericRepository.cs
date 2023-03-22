using IStore.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IStore.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly IStoreDbContext _dbContext;

    public GenericRepository(IStoreDbContext dbContext) =>
        _dbContext = dbContext;

    public async Task<T> Get(int id) =>
        await _dbContext.Set<T>().FindAsync(id);

    public async Task<IReadOnlyList<T>> GetAll() =>
        await _dbContext.Set<T>().ToListAsync();

    public async Task<T> Add(T entity)
    {
        await _dbContext.AddAsync(entity);
        return entity;
    }

    public async Task<bool> Exists(int id)
    {
        var entity = await Get(id);
        return entity != null;
    }

    public async Task Update(T entity) =>
        _dbContext.Entry(entity).State = EntityState.Modified;

    public async Task Delete(T entity) =>
        _dbContext.Set<T>().Remove(entity);
}