using LinkDevelopment.JobsPortal.Domain.Entities;


namespace LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces
{
    public interface ICrudRepository<T> where T : BaseEntity
    {
        T Get(Guid id);
        T GetByName(string name);
        T Insert(T entity);
        T Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
