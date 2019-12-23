using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace CSDLPT
{
    public partial class frmXemKetQua : Form
    {
        public frmXemKetQua()
        {
            InitializeComponent();
        }

        private void frmXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.DSSV' table. You can move, or remove it, as needed.
            this.dSSVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSSVTableAdapter.Fill(this.dS.DSSV);
            // TODO: This line of code loads data into the 'dS.DSMH' table. You can move, or remove it, as needed.
            this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSMHTableAdapter.Fill(this.dS.DSMH);
            // TODO: This line of code loads data into the 'dS.DSLOP' table. You can move, or remove it, as needed.
            this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSLOPTableAdapter.Fill(this.dS.DSLOP);

            cmbLan.Items.Add("1");
            cmbLan.Items.Add("2");

            cmbTrinhDo.Items.Add("A");
            cmbTrinhDo.Items.Add("B");
            cmbTrinhDo.Items.Add("C");

            cmbLan.SelectedIndex = 0;
            cmbTrinhDo.SelectedIndex = 0;

            if (Program.mGroup == "Sinhvien")
            {
                cmbHoTen.SelectedValue = Program.username;
                cmbHoTen.Enabled = false;
                labelTrinhDo.Visible = false;
                labelCoSo.Visible = false;
                cmbTrinhDo.Visible = false;
                cmbCoSo.Visible = false;
            }

        }

        private void btnXem_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (Program.mGroup == "Sinhvien")
            {
                string strLenh = "EXEC SP_KiemTraDaThi '" + Program.username + "', '" + cmbTenMH.SelectedValue.ToString() + "',  " + cmbLan.SelectedItem.ToString();
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int kq = Int32.Parse(Program.myReader.GetInt32(0).ToString());
                if (kq == 0)
                {
                    MessageBox.Show("Bạn chưa thi môn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Program.myReader.Close();
                    cmbTenMH.Focus();
                    return;
                }
                int maBD = Int32.Parse(Program.myReader.GetInt32(1).ToString());
                Program.myReader.Close();

                string strLenh1 = "EXEC SP_ThongTinXemKQ '" + cmbTenMH.SelectedValue.ToString() + "', '" + cmbTenLop.SelectedValue.ToString() + "', " + maBD;
                Program.myReader = Program.ExecSqlDataReader(strLenh1);

                Program.myReader.Read();
                string ngayThi = Program.myReader.GetDateTime(0).ToString();
                string lan = Program.myReader.GetInt16(1).ToString(); //vi smallint
                string[] str = ngayThi.Split(' '); 
                Program.myReader.Close();
                Xrpt_XemKetQua xrpt = new Xrpt_XemKetQua(maBD);
                xrpt.lbLop.Text = cmbTenLop.SelectedValue.ToString();
                xrpt.lbHoTen.Text = Program.mHoten;
                xrpt.lbMonThi.Text = cmbTenMH.SelectedValue.ToString();
                xrpt.lbNgayThi.Text = str[0];
                xrpt.lbLanThi.Text = lan;
                ReportPrintTool print = new ReportPrintTool(xrpt);
                print.ShowPreviewDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form Xem kết quả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();
            }
            catch (Exception) { };
            if (cmbCoSo.SelectedIndex != Program.mCoso)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    this.dSSVTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSSVTableAdapter.Fill(this.dS.DSSV);
                    this.dSMHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSMHTableAdapter.Fill(this.dS.DSMH);
                    this.dSLOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.dSLOPTableAdapter.Fill(this.dS.DSLOP);
                }
                catch (Exception ex) { }
            }
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
