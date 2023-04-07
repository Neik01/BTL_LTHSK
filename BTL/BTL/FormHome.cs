using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {

        }

        private void btn_Subjects_Click(object sender, EventArgs e)
        {
            FormMonHoc formMonHoc = new FormMonHoc();
            formMonHoc.Show();
        }

        private void btn_Classes_Click(object sender, EventArgs e)
        {
            FormLopHanhChinh formLopHanhChinh=new FormLopHanhChinh();
            formLopHanhChinh.Show();
        }
    }
}
