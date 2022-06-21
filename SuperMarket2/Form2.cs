using System;
using System.Windows.Forms;

namespace SuperMarket2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            frm.ShowDialog();
            this.Hide();
        }


        private void BtnSignIn_Click_1(object sender, EventArgs e)
        {
            FormSignIn frm = new FormSignIn();
            frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
