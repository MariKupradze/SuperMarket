using System;
using System.Windows.Forms;

namespace SuperMarket2
{
    public partial class Account : Form
    {
        public User user { get; set; }
        public Account()
        {
            InitializeComponent();

        }

        public Account(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLProcedures.DeleteUsers(user.Id);
            this.Close();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            LblName.Text = Convert.ToString(user.Name);
            LblSurname.Text = Convert.ToString(user.Surname);
            LblEmail.Text = Convert.ToString(user.Email);
            LblAge.Text = Convert.ToString(user.Age);
            LblPhoneNumber.Text = Convert.ToString(user.PhoneNumber);
            lblAddress.Text = Convert.ToString(user.Address);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            FormUpdate f = new FormUpdate(user);
            f.Show();
            LblName.Text = Convert.ToString(user.Name);
            LblSurname.Text = Convert.ToString(user.Surname);
            LblEmail.Text = Convert.ToString(user.Email);
            LblAge.Text = Convert.ToString(user.Age);
            LblPhoneNumber.Text = Convert.ToString(user.PhoneNumber);
            lblAddress.Text = Convert.ToString(user.Address);
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts(user);
            f.Show();
            this.Hide();
        }
    }
}
