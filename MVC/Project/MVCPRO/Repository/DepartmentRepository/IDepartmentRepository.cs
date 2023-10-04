using MVCPRO.Models;

namespace MVCPRO.Repository.DepartmentRepository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAll();
        Department GetByDepartmentId(int departID);
        void Insert(Department department);
        void Update(Department department);
        void Delete(int departID);
        int Save();
    }
}
