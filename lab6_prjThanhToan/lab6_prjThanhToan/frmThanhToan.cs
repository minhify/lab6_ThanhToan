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
        int SoPhong;
        private PhongController phongController = new PhongController();

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
            cbSoPhong.SelectedIndex = -1;
            dtNgay.Value = DateTime.Now;
            btnAdd.Enabled = !status;
            btnSave.Enabled = status;

            tbName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Database.OpenConnection();
                SqlCommand cmd = new SqlCommand("Select max(SoHD) from KhachHang", Database.connection);
                maHD = Convert.ToInt32(cmd.ExecuteScalar());
                Database.CloseConnection();

            } catch (Exception ex)
            {
                maHD = 0;
                MessageBox.Show(ex.Message);
            }
            maHD++;
            ResetFields(true);
            tbSoHD.Text = maHD.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Database.OpenConnection();
            string strInsert = "insert into KhachHang values(@SoHD, @TenKH, @SoCMND, @SoTienTT, @NgayTT, @Phong";
            SqlCommand cmd = new SqlCommand(@strInsert, Database.connection);

            SqlParameter[] parameters =
            {
                new SqlParameter("@SoHD", SqlDbType.Int) { Value = tbSoHD.Text },
                new SqlParameter("@TenKH", SqlDbType.NVarChar) { Value = tbName.Text },
                new SqlParameter("@SoCMND", SqlDbType.NVarChar) {Value = tbSoCMND.Text },
                new SqlParameter("@SoTienTT", SqlDbType.Money) {Value = decimal.Parse(tbTienTT.Text)},
                new SqlParameter("@NgayTT", SqlDbType.DateTime) { Value = DateTime.Now },
                new SqlParameter("@Phong", SqlDbType.Int) {Value = cbSoPhong.SelectedIndex}
            };
            cmd.Parameters.AddRange(parameters);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            List<PhongModel.Phong> listPhong = phongController.GetPhong();
            cbSoPhong.DataSource = listPhong;
            cbSoPhong.DisplayMember = "_tenPhong";
            cbSoPhong.ValueMember = "_maPhong";
            cbSoPhong.SelectedIndex = 0;
            ResetFields(false);
        }

        private void cbSoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSoPhong.SelectedIndex == -1) return;
            PhongModel.Phong selectedPhong = (PhongModel.Phong)cbSoPhong.SelectedItem;
            SoPhong = selectedPhong._maPhong;
        }
    }
}
