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
    public class DepartmentDAO : DBConnection
    {
        public List<DepartmentDTO> ReadDepartmentList()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("GetAllDepartment", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            List<DepartmentDTO> lstDepartment = new List<DepartmentDTO>();
            while (reader.Read())
            {
                DepartmentDTO dep = new DepartmentDTO();
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.NameDep = reader["NameDep"].ToString();
                lstDepartment.Add(dep);
            }
            conn.Close();
            return lstDepartment;
        }

        public DepartmentDTO ReadDepartment(string IdDepartment)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand( "select * from Department_2119110245 where IdDepartment = " +"'" +IdDepartment.ToString()+"'", conn);
            DepartmentDTO dep = new DepartmentDTO();
            SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows && reader.Read())
            {
                dep.IdDepartment = reader["IdDepartment"].ToString();
                dep.NameDep = reader["NameDep"].ToString();
            }
            conn.Close();
            return dep;
        }
    }
}
