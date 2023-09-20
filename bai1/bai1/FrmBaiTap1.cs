using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace bai1
{
    public partial class FrmBaiTap1 : Form
    {
        ErrorProvider errorProvider1 = new ErrorProvider();
        public FrmBaiTap1()
        {
            InitializeComponent();
        }

        private void FrmBaiTap1_Load(object sender, FormClosingEventArgs e)
        {
            DialogResult r;

            r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void text_YourName_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length == 0)
                this.errorProvider1.SetError(ctr, "You must enter your name");
            else
                this.errorProvider1.Clear();
        }

        private void txt_Year_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if(ctr.Text.Length>0 && !Char.IsDigit(ctr.Text[ctr.Text.Length-1]))
                this.errorProvider1.SetError(ctr,"This is not avalid number");
            else
                this.errorProvider1.Clear();
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            int age;
            string s;
            s = "My name is: " + text_YourName.Text + "\n";
            age = DateTime.Now.Year - Convert.ToInt32(txt_Year.Text);
            s = s + "Age: " + age.ToString();
            MessageBox.Show(s);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            text_YourName.Clear();
            txt_Year.Clear();
            text_YourName.Focus();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
