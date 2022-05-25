using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket2
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxAge.Text == "" ||
                textBoxEmail.Text == "" || textBoxPassword.Text == "" || textBoxAddress.Text == "" ||
                textBoxPhoneNumber.Text == "")
            {
                MessageBox.Show("Fill All TextBoxes!");
            }

            else
            {
                SQLProcedures.InsertUsers(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxPassword.Text, Convert.ToInt32(textBoxAge.Text), textBoxAddress.Text, textBoxPhoneNumber.Text);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignIn f = new FormSignIn();
            f.ShowDialog();
            this.Close();
        }
    }
}
