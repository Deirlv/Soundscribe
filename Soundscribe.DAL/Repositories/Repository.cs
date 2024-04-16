using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Soundscribe.DAL;
namespace Soundscribe.DAL.Repositories
{
    public class Repository : IRepository
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity? GetById<TEntity>(int id) where TEntity : class
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Add(object entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(object entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(object entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return _dbContext.Set<TEntity>().ToList();
        }
    }
}
