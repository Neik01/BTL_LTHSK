using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL
{
    public partial class FormLopHanhChinh : Form
    {
        private const string SELECT_lOP_HANH_CHINH = "selectlophanhchinh";
        private const string INSETT_LOP_HANH_CHINH = "insertlophanhchinh";
        private DataView view = new DataView();
        private DataTable table = new DataTable();
        private string connectionStr;
        private bool isExistKhoa, isExistGiaoVien, isExistMaLop, isExistTenLop;
        public FormLopHanhChinh()
        {
            InitializeComponent();
        }
        public FormLopHanhChinh(string connection)
        {
            InitializeComponent();
            this.connectionStr = connection;
        }

        private void FormLopHanhChinh_Load(object sender, EventArgs e)
        {
            loadComboBox();
            loadData();
        }
        private void loadData(string filter = "")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    using (SqlCommand command = new SqlCommand(SELECT_lOP_HANH_CHINH, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            table.Clear();
                            adapter.Fill(table);
                            view = new DataView(table);
                            if (!string.IsNullOrEmpty(filter)) view.RowFilter = filter;
                            dataGribView.DataSource = view;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }
        private void loadComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStr))
                {
                    using (SqlCommand command = new SqlCommand("select sTengv from tblGiangVien", connection))
                    {
                        command.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            foreach (DataRow row in dataTable.Rows)
                            {
                                comboBoxTenGiaoVien.Items.Add(row["sTengv"]);
                            }
                        }
                        command.CommandText = "select sTenkhoa from tblKhoa";
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            foreach (DataRow row in dataTable.Rows)
                            {
                                comboBoxTenKhoa.Items.Add(row["sTenkhoa"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);

            }
        }

        private void comboBoxTenGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string tengiaovien = comboBoxTenGiaoVien.Text.Trim();
            //using (SqlConnection connection = new SqlConnection(connectionStr))
            //{
            //    using (SqlCommand command = new SqlCommand($"select sMagv from tblGiangVien where sTengv = N'{tengiaovien}'", connection))
            //    {
            //        command.CommandType = CommandType.Text;
            //        connection.Open();
            //        text_magiaovien.Text = string.IsNullOrEmpty((string)command.ExecuteScalar()) ? "Tên lớp không phù hợp" : (string)command.ExecuteScalar();
            //    }
            //}
        }

        private void comboBoxTenGiaoVien_TextChanged(object sender, EventArgs e)
        {
            string tengiaovien = comboBoxTenGiaoVien.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand($"select sMagv from tblGiangVien where sTengv = N'{tengiaovien}'", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    string magiaovien = (string)command.ExecuteScalar();
                    isExistGiaoVien = !string.IsNullOrEmpty(magiaovien);
                    text_magiaovien.Text = isExistGiaoVien ? magiaovien : "Tên giáo viên không có trong danh sách";
                }
            }
        }

        private void comboBoxTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string tenkhoa = comboBoxTenKhoa.Text.Trim();
            //using (SqlConnection connection = new SqlConnection(connectionStr))
            //{
            //    using (SqlCommand command = new SqlCommand($"select sMaKhoa from tblKhoa where sTenkhoa = N'{tenkhoa}'", connection))
            //    {
            //        command.CommandType = CommandType.Text;
            //        connection.Open();
            //        string makhoa = (string)command.ExecuteScalar();
            //        text_MaKhoa.Text = string.IsNullOrEmpty(makhoa) ? "Tên khoa không có trong danh sách" : makhoa;
            //    }
            //}
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine(dataGribView.CurrentCell);
            int i = dataGribView.CurrentCell.RowIndex;
            txtBoxMaLop.Text = view[i]["sMalop"].ToString();
            txtBoxTenLop.Text = view[i]["sTenlop"].ToString();
            comboBoxTenGiaoVien.Text = view[i]["sTenGv"].ToString();
            comboBoxTenKhoa.Text = view[i]["sTenkhoa"].ToString();
            text_magiaovien.Text = view[i]["sMagv"].ToString();
            text_MaKhoa.Text = view[i]["sMakhoa"].ToString();
            textSiSo.Text = view[i]["iSiso"].ToString();
        }

        private void txtBoxMaLop_TextChanged(object sender, EventArgs e)
        {
            string malop = txtBoxMaLop.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand($"select sMalop from tblLopHc where sMalop = '{malop}'", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    isExistMaLop = command.ExecuteScalar() != null;
                    Console.WriteLine(isExistMaLop);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string filter = "sMalop IS NOT NULL";
            if (!string.IsNullOrEmpty(txtBoxMaLop.Text))
            {
                filter += string.Format(" AND sMalop LIKE '%{0}%'", txtBoxMaLop.Text);
            }
            if (!string.IsNullOrEmpty(txtBoxTenLop.Text))
            {
                filter += string.Format(" AND sTenlop LIKE '%{0}%'", txtBoxTenLop.Text);
            }
            if (!string.IsNullOrEmpty(comboBoxTenGiaoVien.Text))
            {
                filter += string.Format(" AND sTenGV LIKE '%{0}%'", comboBoxTenGiaoVien.Text);
            }
            if (!string.IsNullOrEmpty(comboBoxTenKhoa.Text))
            {
                filter += string.Format(" AND sTenkhoa LIKE '%{0}%'", comboBoxTenKhoa.Text);
            }
            loadData(filter);
        }

        private void txtBoxTenLop_TextChanged(object sender, EventArgs e)
        {
            string tenlop = txtBoxTenLop.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand($"select iSiSo from tblLophc where sTenLop = '{tenlop}'", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    isExistTenLop = !string.IsNullOrEmpty(Convert.ToString(command.ExecuteScalar()));
                    textSiSo.Text = isExistTenLop ? Convert.ToString(command.ExecuteScalar()) : "0";
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!isExistGiaoVien || !isExistKhoa || isExistMaLop || isExistTenLop)
            {
                MessageBox.Show("error");
                return;
            }
            string malop, tenlop, makhoa, magiaovien, tenkhoa, tengiaovien;
            int siso;
            malop = txtBoxMaLop.Text;
            tenlop = txtBoxTenLop.Text;
            makhoa = text_MaKhoa.Text;
            magiaovien = text_magiaovien.Text;
            tenkhoa = text_MaKhoa.Text;
            tengiaovien = text_magiaovien.Text;
            siso = Convert.ToInt32(textSiSo.Text);
            //DataRow row = table.NewRow();
            //row["sMalop"] = malop;
            //row["sTenlop"] = tenlop;
            //row["sTenGV"] = tengiaovien;
            //row["iSiso"] = siso;
            //row["sTenkhoa"] = tenkhoa;
            //row["sMagv"] = magiaovien;
            //row["sMakhoa"] = makhoa;
            //table.Rows.Add(row);
            //view = new DataView(table);
            //dataGribView.DataSource = view;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand(INSETT_LOP_HANH_CHINH, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@mal", malop);
                    command.Parameters.AddWithValue("@tenlop", tenlop);
                    command.Parameters.AddWithValue("@magv", magiaovien);
                    command.Parameters.AddWithValue("@makhoa", makhoa);
                    connection.Open();
                    int soluong = command.ExecuteNonQuery();
                    if (soluong > 0)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                }
            }
            loadData();
        }

        private void comboBoxTenKhoa_TextChanged(object sender, EventArgs e)
        {
            string tenkhoa = comboBoxTenKhoa.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                using (SqlCommand command = new SqlCommand($"select sMaKhoa from tblKhoa where sTenkhoa = N'{tenkhoa}'", connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    string makhoa = (string)command.ExecuteScalar();
                    isExistKhoa = !string.IsNullOrEmpty(makhoa);
                    text_MaKhoa.Text = isExistKhoa ? makhoa : "Tên khoa không có trong danh sách";
                }
            }
        }
    }
}