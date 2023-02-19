using LinkDevelopment.JobsPortal.Domain.Entities;
using LinkDevelopment.JobsPortal.Repository.Contexts;
using LinkDevelopment.JobsPortal.Repository.Interfaces.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;


namespace LinkDevelopment.JobsPortal.Repository.Repositories
{
    public class CrudRepository<T> : ICrudRepository<T> where T : BaseEntity
    {
        private readonly PortalContext context;
        private DbSet<T> entities;

        public CrudRepository(PortalContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public T Get(Guid id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }
        public T GetByName(String name)
        {
            return entities.SingleOrDefault(s => s.Name == name);
        }

        public T Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<T>().Update(entity);
            context.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
