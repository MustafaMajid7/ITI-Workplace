using MVCPRO.Models;

namespace MVCPRO.Repository.DepartmentRepository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //InstituteCTX instituteCTX = new InstituteCTX();
        InstituteCTX instituteCTX;
        public DepartmentRepository(InstituteCTX instituteCTX)
        {
            this.instituteCTX = instituteCTX;
        }
        public void Delete(int departID)
        {
            instituteCTX.Remove(GetByDepartmentId(departID));
        }

        public List<Department> GetAll()
        {
            return instituteCTX.Departments.ToList();
        }

        public Department GetByDepartmentId(int departID)
        {
            return instituteCTX.Departments.FirstOrDefault(d => d.id == departID);
        }

        public void Insert(Department department)
        {
            instituteCTX.Add(department);
        }

        public int Save()
        {
            return instituteCTX.SaveChanges();
        }

        public void Update(Department department)
        {
            instituteCTX.Update(department);
        }
    }
}
