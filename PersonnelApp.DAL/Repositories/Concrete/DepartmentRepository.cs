using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context) : base(context)
        {
            
        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            return PersonnelContext.Departments.Include("Personnels").ToList();
        }

        public IEnumerable<Department> GetTopDepartments(int count)
        {
            return PersonnelContext.Departments.Take(count);
        }
        public PersonnelContext PersonnelContext { get { return _context as PersonnelContext; } }
    }
}
