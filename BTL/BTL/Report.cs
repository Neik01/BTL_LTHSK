using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BTL
{
    class Report
    {
        private string Filter; 
        private string tableName;
        public Report(string tableName)
        {
            this.tableName = tableName;
            this.Filter = "";
        }
        public void addFilerColumn(DataTable table, string column, string value)
        {
            if (string.IsNullOrEmpty(value)) return;
            Type datatypeColumn = table.Columns[column].DataType;
            if (datatypeColumn.Equals(typeof(int)))
            {
                if (!string.IsNullOrEmpty(Filter)) Filter += " AND";
                Filter += string.Format(" {0} = {1}", $"{{{this.tableName}.{column}}}", value);
                return;
            }
            if (datatypeColumn.Equals(typeof(string)))
            {
                if (!string.IsNullOrEmpty(Filter)) Filter += " AND";
                Filter += string.Format(" {0} LIKE \"*{1}*\"", $"{{{this.tableName}.{column}}}", value);
                return;
            }
        }

        public ReportDocument CreateReportDocument(DataTable table, string pathFileReport)
        {
            ReportDocument report = new ReportDocument();
            report.Load(pathFileReport);
            report.Database.Tables[this.tableName].SetDataSource(table);
            if (!string.IsNullOrEmpty(Filter))
            {
                report.RecordSelectionFormula = Filter;
            }
            return report;
        }
        public ReportDocument CreateReportDocument(string connectionStr, string procName, string pathFileReport)
        {
            ReportDocument report = new ReportDocument();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand(procName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        report.Load(pathFileReport);
                        report.Database.Tables[this.tableName].SetDataSource(table);
                        if (!string.IsNullOrEmpty(Filter))
                        {
                            report.RecordSelectionFormula = Filter;
                        }
                    }
                }
            }
            return report;
        }
    }
}
