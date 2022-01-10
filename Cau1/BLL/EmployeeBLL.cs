using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    public class EmployeeBLL
    {
        EmployeeDAO dao = new EmployeeDAO();
        public List<EmployeeDTO> ReadEmployee()
        {
            List<EmployeeDTO> lstEmployee = dao.ReadEmployee();
            return lstEmployee;
        }

        public void NewEmployee(EmployeeDTO employee)
        {
            dao.NewEmployee(employee);
        }
        public void EditEmployee(EmployeeDTO employee)
        {
            dao.EditEmployee(employee);
        }
        public void DeleteEmployee(EmployeeDTO employee)
        {
            dao.DeleteEmployee(employee);
        }
    }
}
