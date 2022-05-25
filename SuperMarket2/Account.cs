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
    public partial class Account : Form
    {
        public User user { get; set; }
        public Account()
        {
            InitializeComponent();

        }

        public Account (User user)
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
            LblId.Text = Convert.ToString(user.Id);
            LblName.Text = Convert.ToString(user.Name);
            LblSurname.Text = Convert.ToString(user.Surname);
            LblEmail.Text = Convert.ToString(user.Email);   
            LblAge.Text = Convert.ToString(user.Age);
            LblPhoneNumber.Text = Convert.ToString(user.PhoneNumber);
            lblAddress.Text = Convert.ToString(user.Address);
        }
    }
}
