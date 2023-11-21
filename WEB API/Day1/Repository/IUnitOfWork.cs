using Day1.Models;

namespace Day1.Repository
{
	public interface IUnitOfWork :IDisposable
	{
        public SomeFunctionality<Course> Course { get; }
        public RepositoryBase<Instructor> Instructor { get; }
        int complete();
	}
}
