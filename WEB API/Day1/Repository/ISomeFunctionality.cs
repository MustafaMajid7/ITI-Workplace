namespace Day1.Repository
{
	public interface ISomeFunctionality<T> : IRepositoryBase<T> where T : class
	{
		IEnumerable<T> getRange(Func<T, bool> func);
	}
}
