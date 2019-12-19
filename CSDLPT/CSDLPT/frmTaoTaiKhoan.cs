﻿using System;
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
            // TODO: This line of code loads data into the 'dS.V_DSGVChuaCoTaiKhoan' table. You can move, or remove it, as needed.
            this.v_DSGVChuaCoTaiKhoanTableAdapter.Fill(this.dS.V_DSGVChuaCoTaiKhoan);
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

            //Goi cai view tra ve DataTable
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("SELECT * FROM V_DSGVChuaCoTaiKhoan"); //dau cai chuoi lenh nay vao cai ham nay, ham nay thuc thi lenh, roi tra ve DataTable
            //lien ket giua bindingSource với combobox
            cmbTenGV.DataSource = dt;
            cmbTenGV.DisplayMember = "HOTEN"; //ten cot muon hien len
            cmbTenGV.ValueMember = "MAGV"; //gia tri muon hien len

            cmbTenGV.SelectedIndex = 0;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMatKhau.Focus();
                return;
            }

            try
            {
                MessageBox.Show(" " + txtTaiKhoan.Text + " " + cmbTenGV.SelectedValue.ToString() + " " + cmbNhom.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                String strLenh = "EXEC sp_TaoTaiKhoan '" + txtTaiKhoan.Text + "', '" + txtMatKhau.Text + "', '" + cmbTenGV.SelectedValue.ToString() + "' , '" + cmbNhom.SelectedItem.ToString();
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                if(ex.Message.Contains("unique") || ex.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Mời nhập tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTaiKhoan.Focus();
                    Program.myReader.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Lỗi tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
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
