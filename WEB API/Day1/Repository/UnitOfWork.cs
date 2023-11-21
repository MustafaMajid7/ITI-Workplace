using Day1.Models;

namespace Day1.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly PcContext pcContext;

		public SomeFunctionality<Course> Course { get ; private set ; }
		public RepositoryBase<Instructor> Instructor { get; private set; }

        public UnitOfWork(PcContext pcContext)
        {
			this.pcContext = pcContext;
			Course = new SomeFunctionality<Course>(pcContext);
			Instructor = new RepositoryBase<Instructor>(pcContext);
		}

        public int complete()
		{
			return pcContext.SaveChanges();
		}

		public void Dispose()
		{
			pcContext.Dispose();
		}
	}
}
