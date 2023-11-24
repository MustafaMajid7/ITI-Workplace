using Day1.Models;

namespace Day1.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected readonly PcContext pcContext;

		public RepositoryBase(PcContext pcContext)
		{
			this.pcContext = pcContext;
		}
		public List<T> getAll()
		{
			return pcContext.Set<T>().ToList();
		}
		public T getOne(Func<T, bool> func)
		{
			return pcContext.Set<T>().Where(func).FirstOrDefault();
		}
		public T add(T entity)
		{
			return pcContext.Set<T>().Add(entity).Entity;
		}
		public T update(T entity)
		{
			pcContext.ChangeTracker.Clear();
			return pcContext.Set<T>().Update(entity).Entity;
		}
		public T delete(T entity)
		{
			return pcContext.Set<T>().Remove(entity).Entity;
		}

		public void addRange(List<T> entities)
		{
			pcContext.Set<T>().AddRange(entities);
		}
	}
}
