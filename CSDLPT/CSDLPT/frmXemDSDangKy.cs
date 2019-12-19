using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDLPT
{
    public partial class frmXemDSDangKy : Form
    {
        public frmXemDSDangKy()
        {
            InitializeComponent();
        }

        private void frmXemDSDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.dS.V_DSPM);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem Danh sách Đăng ký không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
