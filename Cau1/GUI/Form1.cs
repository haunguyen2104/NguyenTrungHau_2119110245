using Cau1.BLL;
using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cau1
{
    public partial class Employee : Form
    {
        EmployeeBLL empBLL = new EmployeeBLL();
        DepartmentBLL depBLL = new DepartmentBLL();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            List<EmployeeDTO> lstEmp = empBLL.ReadEmployee();
            foreach(EmployeeDTO emp in lstEmp)
            {
                dataView.Rows.Add(emp.IdEmployee,
                                                    emp.Name,
                                                    emp.DateBirth,
                                                    emp.Gender,
                                                    emp.PlaceBirth,
                                                    emp.DepartmentName);
            }
            List<DepartmentDTO> lstDep = depBLL.ReadDepartmentList();
            foreach(DepartmentDTO dep in lstDep)
            {
                cbDepartment.Items.Add(dep);
            }
            cbDepartment.DisplayMember = "DepartmentName";
        }

        private void dataView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn đóng chương trình không ? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
