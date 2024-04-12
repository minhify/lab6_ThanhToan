using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_prjThanhToan
{
    class PhongController
    {
        public List<PhongModel.Phong> GetPhong()
        {
            List<PhongModel.Phong> listPhong = new List<PhongModel.Phong>();
            try
            {
                Database.OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter("Select MaPhong, TenPhong from Phong", Database.connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                
                foreach (DataRow row in dataTable.Rows)
                {
                    PhongModel.Phong  phong = new PhongModel.Phong();
                    phong._maPhong = Convert.ToInt32(row["MaPhong"]);
                    phong._tenPhong = row["TenPhong"].ToString();
                    listPhong.Add(phong);
                }   
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return listPhong;
        }
    }
}
