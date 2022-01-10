using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class EmployeeDAO:DBConnection
    {
        public List<EmployeeDTO> ReadEmployee()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAllEmployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            List<EmployeeDTO> lstEmployee = new List<EmployeeDTO>();
            DepartmentDAO dep = new DepartmentDAO();
            while(reader.Read())
            {
                EmployeeDTO Employee = new EmployeeDTO();
                Employee.IdEmployee = int.Parse(reader["IdEmployee"].ToString());
                Employee.Name = reader["Name"].ToString();
                Employee.DateBirth = DateTime.Parse(reader["DateBirth"].ToString());
               Employee.Gender = reader["Gender"].ToString();
                Employee.PlaceBirth = reader["PlaceBirth"].ToString();
                Employee.Departments = dep.ReadDepartment(reader["IdDepartment"].ToString());

                lstEmployee.Add(Employee);
            }
            conn.Close();
            return lstEmployee;
        }

        public void NewEmployee(EmployeeDTO emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("IdEmployee",emp.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("IdDepartment", emp.Departments.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void EditEmployee(EmployeeDTO emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("IdEmployee", emp.IdEmployee));
            cmd.Parameters.Add(new SqlParameter("Name", emp.Name));
            cmd.Parameters.Add(new SqlParameter("DateBirth", emp.DateBirth));
            cmd.Parameters.Add(new SqlParameter("Gender", emp.Gender));
            cmd.Parameters.Add(new SqlParameter("PlaceBirth", emp.PlaceBirth));
            cmd.Parameters.Add(new SqlParameter("IdDepartment", emp.Departments.IdDepartment));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteEmployee(EmployeeDTO emp)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete_Employee", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("IdEmployee", emp.IdEmployee));
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
