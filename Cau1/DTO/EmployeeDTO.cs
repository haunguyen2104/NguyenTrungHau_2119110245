using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class EmployeeDTO
    {
        public int IdEmployee { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public string Gender { get; set; }
        public string PlaceBirth { get; set; }
        public DepartmentDTO Departments { get; set; }
        public string DepartmentName
        {
            get
            {
                return Departments.NameDep;
            }
        }
    }
}
