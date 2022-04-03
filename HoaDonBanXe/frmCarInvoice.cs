using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaDonBanXe
{
    public partial class frmCarInvoice : Form
    {
        public frmCarInvoice()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
                Close();
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtPrice.Text = "";
            txtSurcharge.Text = "";
            txtTax.Text = "";
            txtPayment.Text = "";
            radBlack.Checked = false;
            radOther.Checked = false;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(KiemTraThongTinKhachHang()==false)
                MessageBox.Show("Thông tin khách hàng chưa đầy đủ. Hãy kiểm tra lại")
        }

        private bool KiemTraThongTinKhachHang()
        {
            if (txtName.Text == "")
                return false;
            if (txtAddress.Text == "")
                return false;
            if (txtPhone.Text == "")
                return false;
            return true;
        }
    }
}
