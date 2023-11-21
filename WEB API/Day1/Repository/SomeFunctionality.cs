using Day1.Models;

namespace Day1.Repository
{
	public class SomeFunctionality<T> : RepositoryBase<T>, ISomeFunctionality<T> where T : class
	{
		private readonly PcContext pcContext;

		public SomeFunctionality(PcContext pcContext) : base(pcContext)
		{
		}

		public IEnumerable<T> getRange(Func<T,bool> func)
		{
			return base.pcContext.Set<T>().Where(func).ToList();
		}
	}
}
