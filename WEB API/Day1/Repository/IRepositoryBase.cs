namespace Day1.Repository
{
	public interface IRepositoryBase<T> where T : class
	{
		T add(T entity);
		void addRange(List<T> entities);
		T delete(T entity);
		List<T> getAll();
		T getOne(Func<T, bool> func);
		T update(T entity);
	}
}