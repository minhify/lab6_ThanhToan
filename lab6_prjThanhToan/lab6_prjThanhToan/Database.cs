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
    public static Boolean OpenConnection()
    {
        try
        {
            connection = new SqlConnection("Server=MINHIFY\\MYB2014996;Database=ThanhToan;Integrated Security=true");
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            return false;
        }
    }

    public static Boolean CloseConnection()
    {
        connection.Close(); 
        return true;
    }
}
