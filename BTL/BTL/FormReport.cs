﻿using CrystalDecisions.CrystalReports.Engine;
using System;

using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Xml;

using System.Xml;
using System.Configuration;

namespace BTL
{
    public partial class FormReport : Form
    {

        private string connectionStr = ConfigurationManager.ConnectionStrings["QUANLYGIANGDAY2ConnectionString"].ConnectionString;
        private const string SELECT_lOP_HANH_CHINH_THEO_MA = "selectlophanhchinhtheoma";

        public void thongkelophanhchinhtheomalop(string malop)
        {
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand(SELECT_lOP_HANH_CHINH_THEO_MA, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@malop", malop);
                    using(SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using(DataTable table = new DataTable())
                        {
                            adapter.Fill(table);
                            Report report = new Report(SELECT_lOP_HANH_CHINH_THEO_MA);
                            string path = $@"{Application.StartupPath}\BaoCao\lophanhchinh\thongkedonlophanhchinh.rpt";
                            this.crystalReportViewer.ReportSource = report.CreateReportDocument(table, path);
                        }
                    }
                }
            }
        }
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {

            //using(SqlConnection connection = new SqlConnection(connectionStr))
            //{
            //    using (SqlCommand command = new SqlCommand(SELECT_lOP_HANH_CHINH, connection))
            //    {
            //        command.CommandType = CommandType.StoredProcedure;
            //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //        {
            //            DataTable table = new DataTable("lophanhchinh");
            //            adapter.Fill(table);
            //            ReportDocument report = new ReportDocument();
            //            string path = $@"{Application.StartupPath}\report\lophanhchinh\Reportlophanhchinh.rpt";
            //            report.Load(path);
            //            report.Database.Tables["selectlophanhchinh"].SetDataSource(table);
            //            crystalReportViewer.ReportSource = report;
            //        }
            //    }
            //}

        }

        public void showReport(string reportFileName, string spName, string connection)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connection))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = spName;
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            using (DataTable table = new DataTable())
                            {
                                da.Fill(table);
                                ReportDocument reportDocument = new ReportDocument();
                                string path = string.Format
                                    ("{0}\\BaoCao\\{1}", Application.StartupPath, reportFileName);
                                reportDocument.Load(path);
                                reportDocument.Database.Tables[spName]
                                    .SetDataSource(table);



                                crystalReportViewer.ReportSource = reportDocument;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void showSubjectDetails(string subjectId, string connection, string spName, string reportFileName)
        {
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connection))
                    {
                        using (SqlCommand cmd = con.CreateCommand())
                        {
                            cmd.CommandText = spName;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@maMon", subjectId);
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                using (DataTable table = new DataTable())
                                {
                                    da.Fill(table);
                                    ReportDocument reportDocument = new ReportDocument();
                                    string path = string.Format
                                        ("{0}\\BaoCao\\{1}", Application.StartupPath, reportFileName);
                                    reportDocument.Load(path);
                                    reportDocument.Database.Tables[spName]
                                        .SetDataSource(table);



                                    crystalReportViewer.ReportSource = reportDocument;
                                }
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }

}





