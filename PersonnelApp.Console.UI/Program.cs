using PersonnelApp.DAL;
using PersonnelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository.Add(new Department() 
            {
                Name="Muhasebe",IsActive=true,
                CreatedDate=DateTime.Now 
            });
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Pazarlama",
                IsActive = true,
                CreatedDate = DateTime.Now
            });
            unitOfWork.Complete();
        }
    }
}
