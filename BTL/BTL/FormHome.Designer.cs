namespace BTL
{
    partial class FormHome
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
            this.btn_Students = new System.Windows.Forms.Button();
            this.btn_Teachers = new System.Windows.Forms.Button();
            this.btn_Subjects = new System.Windows.Forms.Button();
            this.btn_Classes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Students
            // 
            this.btn_Students.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Students.Location = new System.Drawing.Point(128, 65);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(169, 54);
            this.btn_Students.TabIndex = 0;
            this.btn_Students.Text = "Sinh viên";
            this.btn_Students.UseVisualStyleBackColor = true;
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // btn_Teachers
            // 
            this.btn_Teachers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teachers.Location = new System.Drawing.Point(337, 65);
            this.btn_Teachers.Name = "btn_Teachers";
            this.btn_Teachers.Size = new System.Drawing.Size(169, 54);
            this.btn_Teachers.TabIndex = 1;
            this.btn_Teachers.Text = "Giảng viên";
            this.btn_Teachers.UseVisualStyleBackColor = true;
            // 
            // btn_Subjects
            // 
            this.btn_Subjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Subjects.Location = new System.Drawing.Point(128, 166);
            this.btn_Subjects.Name = "btn_Subjects";
            this.btn_Subjects.Size = new System.Drawing.Size(169, 54);
            this.btn_Subjects.TabIndex = 2;
            this.btn_Subjects.Text = "Môn học";
            this.btn_Subjects.UseVisualStyleBackColor = true;
            this.btn_Subjects.Click += new System.EventHandler(this.btn_Subjects_Click);
            // 
            // btn_Classes
            // 
            this.btn_Classes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Classes.Location = new System.Drawing.Point(337, 166);
            this.btn_Classes.Name = "btn_Classes";
            this.btn_Classes.Size = new System.Drawing.Size(169, 54);
            this.btn_Classes.TabIndex = 3;
            this.btn_Classes.Text = "Lớp hành chính";
            this.btn_Classes.UseVisualStyleBackColor = true;
            this.btn_Classes.Click += new System.EventHandler(this.btn_Classes_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Classes);
            this.Controls.Add(this.btn_Subjects);
            this.Controls.Add(this.btn_Teachers);
            this.Controls.Add(this.btn_Students);
            this.Name = "FormHome";
            this.Text = "Trang chủ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Button btn_Teachers;
        private System.Windows.Forms.Button btn_Subjects;
        private System.Windows.Forms.Button btn_Classes;
    }
}