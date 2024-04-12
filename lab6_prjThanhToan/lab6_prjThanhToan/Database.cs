using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Database
{
    public static SqlConnection connection;
    public static bool OpenConnection()
    {
        try
        {
            connection = new SqlConnection("Server=MINHIFY\\MYB2014996;Database=ThanhToan;uid=mylogin;pwd=mylogin");
            connection.Open();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            return false;
        }
        return true;
    }

    public static bool CloseConnection()
    {
        connection.Close(); 
        return true;
    }
}
