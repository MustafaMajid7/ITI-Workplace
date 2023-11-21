namespace Day1.Repository
{
	public interface IRepositoryBase<T> where T : class
	{
		T addCourse(T entity);
		List<T> getAll();
		T getOne(Func<T, bool> func);
		T updateCourse(T entity);
	}
}