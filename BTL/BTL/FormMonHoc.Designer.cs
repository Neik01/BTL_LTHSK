namespace BTL
{
    partial class FormMonHoc
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
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Id = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.lb_TC = new System.Windows.Forms.Label();
            this.tb_TC = new System.Windows.Forms.TextBox();
            this.lb_falcultyName = new System.Windows.Forms.Label();
            this.comboBox_falcultyName = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.sMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thông tin môn học";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(23, 59);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(70, 13);
            this.lb_Name.TabIndex = 4;
            this.lb_Name.Text = "Tên môn học";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(142, 52);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(301, 20);
            this.tb_Name.TabIndex = 8;
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(23, 109);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(45, 13);
            this.lb_Id.TabIndex = 9;
            this.lb_Id.Text = "Mã môn";
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(142, 102);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(301, 20);
            this.tb_Id.TabIndex = 10;
            // 
            // lb_TC
            // 
            this.lb_TC.AutoSize = true;
            this.lb_TC.Location = new System.Drawing.Point(23, 151);
            this.lb_TC.Name = "lb_TC";
            this.lb_TC.Size = new System.Drawing.Size(53, 13);
            this.lb_TC.TabIndex = 11;
            this.lb_TC.Text = "Số tín chỉ";
            // 
            // tb_TC
            // 
            this.tb_TC.Location = new System.Drawing.Point(142, 144);
            this.tb_TC.Name = "tb_TC";
            this.tb_TC.Size = new System.Drawing.Size(301, 20);
            this.tb_TC.TabIndex = 12;
            // 
            // lb_falcultyName
            // 
            this.lb_falcultyName.AutoSize = true;
            this.lb_falcultyName.Location = new System.Drawing.Point(23, 206);
            this.lb_falcultyName.Name = "lb_falcultyName";
            this.lb_falcultyName.Size = new System.Drawing.Size(53, 13);
            this.lb_falcultyName.TabIndex = 13;
            this.lb_falcultyName.Text = "Tên khoa";
            // 
            // comboBox_falcultyName
            // 
            this.comboBox_falcultyName.FormattingEnabled = true;
            this.comboBox_falcultyName.Location = new System.Drawing.Point(142, 198);
            this.comboBox_falcultyName.Name = "comboBox_falcultyName";
            this.comboBox_falcultyName.Size = new System.Drawing.Size(301, 21);
            this.comboBox_falcultyName.TabIndex = 17;
            // 
            // btn_add
            // 
            this.btn_add.Enabled = false;
            this.btn_add.Location = new System.Drawing.Point(523, 34);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Thêm mới môn học";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Enabled = false;
            this.btn_update.Location = new System.Drawing.Point(523, 81);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 19;
            this.btn_update.Text = "Sửa ";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(523, 130);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Xoá môn học";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(523, 179);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 21;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sMaMon,
            this.sTenMon,
            this.iSoTC,
            this.sTenKhoa});
            this.dgv_data.Location = new System.Drawing.Point(26, 260);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.Size = new System.Drawing.Size(524, 150);
            this.dgv_data.TabIndex = 22;
            this.dgv_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellContentClick);
            // 
            // sMaMon
            // 
            this.sMaMon.DataPropertyName = "sMaMon";
            this.sMaMon.HeaderText = "Mã môn học";
            this.sMaMon.Name = "sMaMon";
            // 
            // sTenMon
            // 
            this.sTenMon.DataPropertyName = "sTenMon";
            this.sTenMon.HeaderText = "Tên môn học";
            this.sTenMon.Name = "sTenMon";
            // 
            // iSoTC
            // 
            this.iSoTC.DataPropertyName = "iSoTC";
            this.iSoTC.HeaderText = "Số tín chỉ";
            this.iSoTC.Name = "iSoTC";
            // 
            // sTenKhoa
            // 
            this.sTenKhoa.DataPropertyName = "sTenKhoa";
            this.sTenKhoa.HeaderText = "Tên khoa";
            this.sTenKhoa.Name = "sTenKhoa";
            // 
            // FormMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.comboBox_falcultyName);
            this.Controls.Add(this.lb_falcultyName);
            this.Controls.Add(this.tb_TC);
            this.Controls.Add(this.lb_TC);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.lb_Id);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.label2);
            this.Name = "FormMonHoc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label lb_TC;
        private System.Windows.Forms.TextBox tb_TC;
        private System.Windows.Forms.Label lb_falcultyName;
        private System.Windows.Forms.ComboBox comboBox_falcultyName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSoTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTenKhoa;
    }
}

