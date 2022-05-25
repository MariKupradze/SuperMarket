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
    public partial class FormSignIn : Form
    {
        List<User> users = new List<User>();
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (textBoxLogInEmail.Text =="" || textBoxLogInPassword.Text == "")
            {
                MessageBox.Show("Fill All Textboxes!");
            }
            LoadUsers();

            foreach(User user in users)
            {
                if (user.Email == textBoxLogInEmail.Text || user.Password == textBoxLogInPassword.Text)
                {
                    Account account = new Account(user);
                    account.ShowDialog();
                    break;
                }
            }
        }

        private void LoadUsers()
        {
            DataTable dt = SQLProcedures.SelectUsers();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                User user = new User();
                user.Id = Convert.ToInt32(dt.Rows[i]["UserId"]);
                user.Name = Convert.ToString(dt.Rows[i]["UserName"]);
                user.Surname = Convert.ToString(dt.Rows[i]["UserSurname"]);
                user.Age = Convert.ToInt32(dt.Rows[i]["UserAge"]);
                user.Email = Convert.ToString(dt.Rows[i]["UserEmail"]);
                user.Password = Convert.ToString(dt.Rows[i]["UserPassword"]);
                user.Address = Convert.ToString(dt.Rows[i]["UserAddress"]);
                user.PhoneNumber = Convert.ToString(dt.Rows[i]["UserPhoneNumber"]);

                users.Add(user);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister f = new FormRegister();
            f.ShowDialog();
            this.Close();
        }
    }
}
