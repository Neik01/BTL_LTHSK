
namespace BTL
{
    partial class FormLopHanhChinh
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGribView = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.comboBoxTenGiaoVien = new System.Windows.Forms.ComboBox();
            this.lb_TC = new System.Windows.Forms.Label();
            this.txtBoxTenLop = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.txtBoxMaLop = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTenKhoa = new System.Windows.Forms.ComboBox();
            this.textMaGiaoVien = new System.Windows.Forms.Label();
            this.textSiSo = new System.Windows.Forms.Label();
            this.textMaKhoa = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGribView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGribView
            // 
            this.dataGribView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGribView.Location = new System.Drawing.Point(12, 242);
            this.dataGribView.Name = "dataGribView";
            this.dataGribView.Size = new System.Drawing.Size(647, 150);
            this.dataGribView.TabIndex = 0;
            this.dataGribView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(553, 76);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(553, 47);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 33;
            this.btn_add.Text = "Thêm mới môn học";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // comboBoxTenGiaoVien
            // 
            this.comboBoxTenGiaoVien.FormattingEnabled = true;
            this.comboBoxTenGiaoVien.Location = new System.Drawing.Point(180, 100);
            this.comboBoxTenGiaoVien.Name = "comboBoxTenGiaoVien";
            this.comboBoxTenGiaoVien.Size = new System.Drawing.Size(301, 21);
            this.comboBoxTenGiaoVien.TabIndex = 32;
            this.comboBoxTenGiaoVien.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenGiaoVien_SelectedIndexChanged);
            this.comboBoxTenGiaoVien.TextChanged += new System.EventHandler(this.comboBoxTenGiaoVien_TextChanged);
            // 
            // lb_TC
            // 
            this.lb_TC.AutoSize = true;
            this.lb_TC.Location = new System.Drawing.Point(50, 125);
            this.lb_TC.Name = "lb_TC";
            this.lb_TC.Size = new System.Drawing.Size(53, 13);
            this.lb_TC.TabIndex = 29;
            this.lb_TC.Text = "Tên khoa";
            // 
            // txtBoxTenLop
            // 
            this.txtBoxTenLop.Location = new System.Drawing.Point(180, 75);
            this.txtBoxTenLop.Name = "txtBoxTenLop";
            this.txtBoxTenLop.Size = new System.Drawing.Size(301, 20);
            this.txtBoxTenLop.TabIndex = 28;
            this.txtBoxTenLop.TextChanged += new System.EventHandler(this.txtBoxTenLop_TextChanged);
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(50, 100);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(101, 13);
            this.lb_Id.TabIndex = 27;
            this.lb_Id.Text = "Tên cố vấn học tập";
            // 
            // txtBoxMaLop
            // 
            this.txtBoxMaLop.Location = new System.Drawing.Point(180, 50);
            this.txtBoxMaLop.Name = "txtBoxMaLop";
            this.txtBoxMaLop.Size = new System.Drawing.Size(301, 20);
            this.txtBoxMaLop.TabIndex = 26;
            this.txtBoxMaLop.TextChanged += new System.EventHandler(this.txtBoxMaLop_TextChanged);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(50, 75);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(43, 13);
            this.lb_Name.TabIndex = 25;
            this.lb_Name.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sĩ số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mã khoa";
            // 
            // comboBoxTenKhoa
            // 
            this.comboBoxTenKhoa.FormattingEnabled = true;
            this.comboBoxTenKhoa.Location = new System.Drawing.Point(180, 125);
            this.comboBoxTenKhoa.Name = "comboBoxTenKhoa";
            this.comboBoxTenKhoa.Size = new System.Drawing.Size(301, 21);
            this.comboBoxTenKhoa.TabIndex = 32;
            this.comboBoxTenKhoa.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenKhoa_SelectedIndexChanged);
            this.comboBoxTenKhoa.TextChanged += new System.EventHandler(this.comboBoxTenKhoa_TextChanged);
            // 
            // textMaGiaoVien
            // 
            this.textMaGiaoVien.AutoSize = true;
            this.textMaGiaoVien.Location = new System.Drawing.Point(180, 175);
            this.textMaGiaoVien.Name = "textMaGiaoVien";
            this.textMaGiaoVien.Size = new System.Drawing.Size(0, 13);
            this.textMaGiaoVien.TabIndex = 29;
            // 
            // textSiSo
            // 
            this.textSiSo.AutoSize = true;
            this.textSiSo.Location = new System.Drawing.Point(180, 150);
            this.textSiSo.Name = "textSiSo";
            this.textSiSo.Size = new System.Drawing.Size(0, 13);
            this.textSiSo.TabIndex = 29;
            // 
            // textMaKhoa
            // 
            this.textMaKhoa.AutoSize = true;
            this.textMaKhoa.Location = new System.Drawing.Point(180, 200);
            this.textMaKhoa.Name = "textMaKhoa";
            this.textMaKhoa.Size = new System.Drawing.Size(0, 13);
            this.textMaKhoa.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Báo cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(553, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Thống kê lớp hành chính";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLopHanhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.comboBoxTenKhoa);
            this.Controls.Add(this.comboBoxTenGiaoVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSiSo);
            this.Controls.Add(this.textMaKhoa);
            this.Controls.Add(this.textMaGiaoVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_TC);
            this.Controls.Add(this.txtBoxTenLop);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.txtBoxMaLop);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGribView);
            this.Name = "FormLopHanhChinh";
            this.Text = "FormLopHanhChinh";
            this.Load += new System.EventHandler(this.FormLopHanhChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGribView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGribView;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox comboBoxTenGiaoVien;
        private System.Windows.Forms.Label lb_TC;
        private System.Windows.Forms.TextBox txtBoxTenLop;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox txtBoxMaLop;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTenKhoa;
        private System.Windows.Forms.Label textMaGiaoVien;
        private System.Windows.Forms.Label textSiSo;
        private System.Windows.Forms.Label textMaKhoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}