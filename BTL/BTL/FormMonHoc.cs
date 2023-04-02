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

namespace BTL
{
    public partial class FormMonHoc : Form
    {

        private ErrorProvider errorProvider = new ErrorProvider();
        string connectionString = "Data Source=DESKTOP-2HP30CE;Initial Catalog=QUANLYGIANGDAY;Integrated Security=True";
        private DataTable tableGridView = new DataTable();

        private DataView dv = new DataView();
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
            loadDataToCb();
        }

        private void LoadDataToGridView(string filter = "")
        {
            try
            {
                tableGridView.Clear();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = sqlConnection.CreateCommand())
                    {
                        cmd.CommandText = "getAllSubject";
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(tableGridView);

                            if (tableGridView.Rows.Count > 0)
                            {

                                dv = tableGridView.DefaultView;
                                dgv_data.AutoGenerateColumns = false;

                                //Lọc dữ liệu
                                if (!string.IsNullOrEmpty(filter)) dv.RowFilter = filter;

                                dgv_data.DataSource = dv;
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại dữ liệu");
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

        public void loadDataToCb()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "select sTenKhoa from tblKhoa";
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            foreach (DataRow row in dataTable.Rows)
                            {
                                comboBox_falcultyName.Items.Add(row["sTenKhoa"]);
                            }
                        }
                    }
                }
            }
        }

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_data.CurrentRow.Index;
            tb_Name.Text = dv[index]["sTenMon"].ToString();
            tb_Id.Text = dv[index]["sMaMon"].ToString();
            tb_TC.Text = dv[index]["iSoTC"].ToString();
            comboBox_falcultyName.Text = dv[index]["sTenKhoa"].ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = connection.CreateCommand())
                {


                    cmd.CommandText = "checkPrimaryKeySubject";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", tb_Id.Text.Trim().ToString());

                    connection.Open();
                    var idsv_sql = cmd.ExecuteScalar();
                    connection.Close();

                    if (idsv_sql == null)
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {

                            cmd.Parameters.Clear();
                            cmd.CommandText = "getAllSubject";
                            cmd.CommandType = CommandType.StoredProcedure;
                            adapter.SelectCommand = cmd;

                            using (DataTable tblMonHoc = new DataTable("tblMonHoc"))
                            {
                                adapter.Fill(tblMonHoc);

                                using (DataSet ds = new DataSet())
                                {

                                    ds.Tables.Add(tblMonHoc);
                                    //them moi ban ghi vao datatable
                                    DataRow newRow = tblMonHoc.NewRow();

                                    newRow["sMaMon"] = tb_Id.Text.Trim();
                                    newRow["sTenMon"] = tb_Name.Text.Trim();
                                    newRow["sMaKhoa"] = findFalcultyId(comboBox_falcultyName.Text);
                                    newRow["iSoTC"] = tb_TC.Text.Trim();
                                    tblMonHoc.Rows.Add(newRow);

                                    cmd.Parameters.Clear();
                                    cmd.CommandText = "insertMon";
                                    cmd.CommandType = CommandType.StoredProcedure;


                                    cmd.Parameters.AddWithValue("@Mamon1", tb_Id.Text.Trim().ToString());
                                    cmd.Parameters.AddWithValue("@MaKhoa", findFalcultyId(comboBox_falcultyName.Text));
                                    cmd.Parameters.AddWithValue("@TenMon", tb_Name.Text.Trim().ToString());
                                    cmd.Parameters.AddWithValue("@Tc", tb_TC.Text.Trim().ToString());

                                    adapter.InsertCommand = cmd;
                                    adapter.Update(ds, "tblMonHoc");
                                    MessageBox.Show("Thêm mới thành công");
                                    LoadDataToGridView();
                                }
                            }



                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm mới do mã sinh viên đã tồn tại");
                    }
                }
            }
        }



        private string findFalcultyId(String name)
        {
            foreach (DataRow row in tableGridView.Rows)
            {
                if (row["sTenKhoa"].ToString().Equals(name))
                    return row["sMaKhoa"].ToString();
            }

            return null;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "getAllSubject";
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        using (DataTable tblMonHoc = new DataTable("tblMonHoc"))
                        {
                            adapter.Fill(tblMonHoc);
                            //add tung datatable vao dataset
                            using (DataSet dataSet = new DataSet())
                            {
                                dataSet.Tables.Add(tblMonHoc);

                                //Chinh sua du lieu trong dtSINHVIEN cua dataset
                                //tim khoa chinh
                                tblMonHoc.PrimaryKey = new DataColumn[] { tblMonHoc.Columns["sMaMon"] };
                                DataRow row = tblMonHoc.Rows.Find(tb_Id.Text);
                                row["sTenMon"] = tb_Name.Text;
                                row["sMaKhoa"] = findFalcultyId(comboBox_falcultyName.Text);
                                row["iSoTC"] = tb_TC.Text;


                                //thuc hien UpdateCommand
                                command.CommandText = "updateMon";
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Clear();

                                command.Parameters.AddWithValue("@Mamon", tb_Id.Text);
                                command.Parameters.AddWithValue("@MaKhoa", findFalcultyId(comboBox_falcultyName.Text));
                                command.Parameters.AddWithValue("@TenMon", tb_Name.Text);
                                command.Parameters.AddWithValue("@Tc", tb_TC.Text);

                                //....

                                adapter.UpdateCommand = command;
                                adapter.Update(dataSet, "tblMonHoc");
                                MessageBox.Show("Cập nhật thành công!");

                                LoadDataToGridView();
                            }
                        }
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //hien dialog de xac nhan 1 lan nua
                DialogResult dialog_delete = MessageBox.
                    Show("Bạn có muốn xoá môn học " + tb_Id.Text + " không?",
                            "Warning",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                if (dialog_delete == DialogResult.Yes)
                {
                    //Cách 1: kiểm tra thông qua ràng buộc giữa các bảng
                    //KiemTraRangBuoc_tblDIEM(maSV);

                    //thuc hien xoa
                    string deleteQuery = "deleteMon";
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = sqlConnection.CreateCommand())
                        {
                            command.CommandText = deleteQuery;
                            command.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {


                                DataTable dt_tblMonHoc = new DataTable("tblMonHoc");
                                adapter.Fill(dt_tblMonHoc);

                                //add cac datatable vao dataset
                                DataSet ds = new DataSet();
                                ds.Tables.Add(dt_tblMonHoc);

                                dt_tblMonHoc.PrimaryKey = new DataColumn[] { dt_tblMonHoc.Columns["sMaSV"] };
                                string subjectId = dv[dgv_data.CurrentRow.Index]["sMaMon"].ToString();
                                checkFkMonHoc(subjectId);
                                DataRow dataRow = dt_tblMonHoc.Rows.Find(subjectId);
                                dataRow.Delete();

                                //xoa trong DB 
                                using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                                {
                                    sqlCommand.CommandText = deleteQuery;
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.Parameters.AddWithValue("@Mamon", subjectId);

                                    adapter.DeleteCommand = sqlCommand;
                                    adapter.Update(ds, "tblMonHoc");
                                }
                            }
                        }

                    }
                    LoadDataToGridView();
                }
            }

            catch (Exception ex)
            {



                MessageBox.Show("Ràng buộc: Môn học này" +
                        " có phát sinh ràng buộc dữ liệu, không xoá được!");


            }
        }


        private void checkFkMonHoc(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "checkPrimaryKeySubject";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    bool exist = (command.ExecuteScalar() != null);
                    connection.Close();
                    if (exist)
                    {
                        throw new Exception();
                    }
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string filter = "sMaMon IS NOT NULL";
            if (!string.IsNullOrEmpty(tb_Name.Text))
            {
                filter += string.Format(" AND sTenMon LIKE '%{0}%'", tb_Name.Text);
            }
            if (!string.IsNullOrEmpty(tb_TC.Text))
                filter += string.Format(" AND iTc LIKE '%{0}%'", tb_TC.Text);


            LoadDataToGridView(filter);
        }

        private void tb_Name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Name.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider.SetError(tb_Name, "Tên môn học không được trống!");
            }
            else
            {
                e.Cancel = false;
                btn_add.Enabled = true;
                btn_delete.Enabled = true;
                btn_update.Enabled = true;
                errorProvider.SetError(tb_Name, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLopHanhChinh hanhChinh = new FormLopHanhChinh(connectionString);
            hanhChinh.Show();
        }
    }


}
