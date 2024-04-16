namespace Soundscribe.DAL.Repositories
{
    public interface IRepository
    {
        TEntity? GetById<TEntity>(int id) where TEntity : class;
        void Add(object entity);
        void Update(object entity);
        void Delete(object entity);
        public List<TEntity> GetAll<TEntity>() where TEntity : class;
    }
}
