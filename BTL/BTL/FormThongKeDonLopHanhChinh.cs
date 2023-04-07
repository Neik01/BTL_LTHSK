using CrystalDecisions.CrystalReports.Engine;
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

namespace BTL.report
{
    public partial class FormThongKeDonLopHanhChinh : Form
    {
        string connectionStr, malop;
        private const string SELECT_LOP_HANH_CHINH_THEO_MA = "selectlophanhchinhtheoma";

        public FormThongKeDonLopHanhChinh()
        {
            InitializeComponent();
        }
        public FormThongKeDonLopHanhChinh(string connection, string malop)
        {
            this.connectionStr = connection;
            this.malop = malop;
            InitializeComponent();
        }

        private void crystalReportViewer_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand(SELECT_LOP_HANH_CHINH_THEO_MA, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@malop", this.malop);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        string path = $@"{Application.StartupPath}\report\lophanhchinh\thongkedonlophanhchinh.rpt";
                        report.Load(path);
                        report.Database.Tables["selectlophanhchinhtheoma"].SetDataSource(table);
                        crystalReportViewer.ReportSource = report;
                    }
                }
            }
        }
    }
}
