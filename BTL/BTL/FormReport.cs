using CrystalDecisions.CrystalReports.Engine;
using System;
<<<<<<< HEAD
<<<<<<< HEAD
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
=======
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
<<<<<<< HEAD
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using System.Xml;
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
=======
using System.Xml;
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571

namespace BTL
{
    public partial class FormReport : Form
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private string connectionStr;
        private const string SELECT_lOP_HANH_CHINH = "selectlophanhchinh";
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
        public FormReport()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
<<<<<<< HEAD
        public FormReport(string connection)
        {
            InitializeComponent();
            this.connectionStr = connection;
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
    }
}
=======
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571

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



                                crystalReportViewer1.ReportSource = reportDocument;
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

        public void showSubjectDetails(string subjectId, string connection, string spName,string reportFileName)
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



                                    crystalReportViewer1.ReportSource = reportDocument;
                                }
                            }
                        }
                    }
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }    
            }
        }
    } }
<<<<<<< HEAD
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
=======
>>>>>>> 90f90133754c72bded4f4958e319c48b0d653571
