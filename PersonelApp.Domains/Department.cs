using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.Domains
{
    public class Department:BaseEntity
    {
        public Department()
        {
            Personnels = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personnel> Personnels { get; set; }
    }
}
