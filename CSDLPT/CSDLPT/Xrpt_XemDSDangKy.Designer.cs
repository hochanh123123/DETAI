namespace CSDLPT
{
    partial class Xrpt_XemDSDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery3 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery4 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery5 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter9 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter10 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter11 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery6 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter12 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery7 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter13 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery8 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter14 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter15 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter16 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter17 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery9 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter18 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery10 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter19 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter20 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter21 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery11 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter22 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery12 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter23 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery13 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter24 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter25 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter26 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_XemDSDangKy));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "TRACNGHIEMConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_DangNhapGiangVien";
            queryParameter1.Name = "@TENLOGIN";
            queryParameter1.Type = typeof(string);
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.StoredProcName = "SP_DangNhapGiangVien";
            storedProcQuery2.Name = "SP_DangNhapSinhVien";
            queryParameter2.Name = "@TENLOGIN";
            queryParameter2.Type = typeof(string);
            storedProcQuery2.Parameters.Add(queryParameter2);
            storedProcQuery2.StoredProcName = "SP_DangNhapSinhVien";
            storedProcQuery3.Name = "SP_KiemTraDangKy";
            queryParameter3.Name = "@MAMH";
            queryParameter3.Type = typeof(string);
            queryParameter4.Name = "@MALOP";
            queryParameter4.Type = typeof(string);
            queryParameter5.Name = "@LAN";
            queryParameter5.Type = typeof(short);
            storedProcQuery3.Parameters.Add(queryParameter3);
            storedProcQuery3.Parameters.Add(queryParameter4);
            storedProcQuery3.Parameters.Add(queryParameter5);
            storedProcQuery3.StoredProcName = "SP_KiemTraDangKy";
            storedProcQuery4.Name = "SP_KTBANGDIEM";
            queryParameter6.Name = "@MASV";
            queryParameter6.Type = typeof(string);
            queryParameter7.Name = "@MAMH";
            queryParameter7.Type = typeof(string);
            queryParameter8.Name = "@LAN";
            queryParameter8.Type = typeof(short);
            storedProcQuery4.Parameters.Add(queryParameter6);
            storedProcQuery4.Parameters.Add(queryParameter7);
            storedProcQuery4.Parameters.Add(queryParameter8);
            storedProcQuery4.StoredProcName = "SP_KTBANGDIEM";
            storedProcQuery5.Name = "SP_KTDK";
            queryParameter9.Name = "@MAMH";
            queryParameter9.Type = typeof(string);
            queryParameter10.Name = "@MALOP";
            queryParameter10.Type = typeof(string);
            queryParameter11.Name = "@LAN";
            queryParameter11.Type = typeof(short);
            storedProcQuery5.Parameters.Add(queryParameter9);
            storedProcQuery5.Parameters.Add(queryParameter10);
            storedProcQuery5.Parameters.Add(queryParameter11);
            storedProcQuery5.StoredProcName = "SP_KTDK";
            storedProcQuery6.Name = "SP_LayThongTinSV";
            queryParameter12.Name = "@X";
            queryParameter12.Type = typeof(string);
            storedProcQuery6.Parameters.Add(queryParameter12);
            storedProcQuery6.StoredProcName = "SP_LayThongTinSV";
            storedProcQuery7.Name = "SP_SOCAUHOI";
            queryParameter13.Name = "@MAMH";
            queryParameter13.Type = typeof(string);
            storedProcQuery7.Parameters.Add(queryParameter13);
            storedProcQuery7.StoredProcName = "SP_SOCAUHOI";
            storedProcQuery8.Name = "SP_TaoTaiKhoan";
            queryParameter14.Name = "@LGNAME";
            queryParameter14.Type = typeof(string);
            queryParameter15.Name = "@PASS";
            queryParameter15.Type = typeof(string);
            queryParameter16.Name = "@USERNAME";
            queryParameter16.Type = typeof(string);
            queryParameter17.Name = "@ROLE";
            queryParameter17.Type = typeof(string);
            storedProcQuery8.Parameters.Add(queryParameter14);
            storedProcQuery8.Parameters.Add(queryParameter15);
            storedProcQuery8.Parameters.Add(queryParameter16);
            storedProcQuery8.Parameters.Add(queryParameter17);
            storedProcQuery8.StoredProcName = "SP_TaoTaiKhoan";
            storedProcQuery9.Name = "SP_ThongTinSV";
            queryParameter18.Name = "@TENLOGIN";
            queryParameter18.Type = typeof(string);
            storedProcQuery9.Parameters.Add(queryParameter18);
            storedProcQuery9.StoredProcName = "SP_ThongTinSV";
            storedProcQuery10.Name = "SP_ThongTinXemKQ";
            queryParameter19.Name = "@MALOP";
            queryParameter19.Type = typeof(string);
            queryParameter20.Name = "@TENLOGIN";
            queryParameter20.Type = typeof(string);
            queryParameter21.Name = "@MAMH";
            queryParameter21.Type = typeof(string);
            storedProcQuery10.Parameters.Add(queryParameter19);
            storedProcQuery10.Parameters.Add(queryParameter20);
            storedProcQuery10.Parameters.Add(queryParameter21);
            storedProcQuery10.StoredProcName = "SP_ThongTinXemKQ";
            storedProcQuery11.Name = "SP_TimKiemMH";
            queryParameter22.Name = "@MAMH";
            queryParameter22.Type = typeof(string);
            storedProcQuery11.Parameters.Add(queryParameter22);
            storedProcQuery11.StoredProcName = "SP_TimKiemMH";
            storedProcQuery12.Name = "SP_TKMH";
            queryParameter23.Name = "@MAMH";
            queryParameter23.Type = typeof(string);
            storedProcQuery12.Parameters.Add(queryParameter23);
            storedProcQuery12.StoredProcName = "SP_TKMH";
            storedProcQuery13.Name = "SP_XemKetQua";
            queryParameter24.Name = "@MALOP";
            queryParameter24.Type = typeof(string);
            queryParameter25.Name = "@MASV";
            queryParameter25.Type = typeof(string);
            queryParameter26.Name = "@MAMH";
            queryParameter26.Type = typeof(string);
            storedProcQuery13.Parameters.Add(queryParameter24);
            storedProcQuery13.Parameters.Add(queryParameter25);
            storedProcQuery13.Parameters.Add(queryParameter26);
            storedProcQuery13.StoredProcName = "SP_XemKetQua";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1,
            storedProcQuery2,
            storedProcQuery3,
            storedProcQuery4,
            storedProcQuery5,
            storedProcQuery6,
            storedProcQuery7,
            storedProcQuery8,
            storedProcQuery9,
            storedProcQuery10,
            storedProcQuery11,
            storedProcQuery12,
            storedProcQuery13});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // Xrpt_XemDSDangKy
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "SP_DangNhapGiangVien";
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
    }
}
