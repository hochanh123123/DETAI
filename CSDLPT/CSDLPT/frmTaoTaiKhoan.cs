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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void frmTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSGV' table. You can move, or remove it, as needed.
            this.dSGVTableAdapter.Fill(this.dS.DSGV);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            cmbNhom.Items.Add("Truong");
            cmbNhom.Items.Add("Giangvien");
            cmbNhom.Items.Add("Coso");
            
            cmbNhom.SelectedIndex = 0;

            if(Program.mGroup == "Truong")
            {
                cmbNhom.SelectedItem = "Truong";
                cmbNhom.Enabled = false;
            }
            else if(Program.mGroup == "Coso")
            {
                cmbNhom.SelectedItem = "Truong";
                cmbNhom.Enabled = false;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Tạo tài khoản không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
