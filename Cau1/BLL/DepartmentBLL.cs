using Cau1.DAO;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.BLL
{
    public class DepartmentBLL
    {
        DepartmentDAO dao = new DepartmentDAO();
        public List<DepartmentDTO> ReadDepartmentList()
        {
            List<DepartmentDTO> lstDepartment = dao.ReadDepartmentList();
            return lstDepartment;
        }

    }
}
