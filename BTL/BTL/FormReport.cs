using CrystalDecisions.CrystalReports.Engine;
using System;
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

namespace BTL
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
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
