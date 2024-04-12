using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6_prjThanhToan
{
    public partial class frmThanhToan : Form
    {
        int maHD;
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void ResetFields(bool status)
        {
            tbSoHD.Clear();
            tbName.Clear();
            tbSoCMND.Clear();
            tbTienTT.Clear();
            cbSoPhong.SelectedIndex = - 1;
            dtNgay.Value = DateTime.Now;
            btnAdd.Enabled = !status;
            btnSave.Enabled = status;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select max(SoHD) from KhachHang", Database.connection);
                maHD = Convert.ToInt32(cmd.ExecuteScalar());
                Database.CloseConnection();

            } catch (Exception)
            {
                maHD = 0;
            }
            maHD++;
            ResetFields(true);
            tbSoHD.Text = maHD.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
