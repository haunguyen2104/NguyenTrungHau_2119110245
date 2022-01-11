using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DTO
{
    public class DepartmentDTO
    {
        //Ánh xạ cơ sở dữ liệu từ bảng Department_2119110245
        public string IdDepartment { get; set; }
        public string NameDep { get; set; } 
        public List<EmployeeDTO> Employees { get; set; }
    }
}
