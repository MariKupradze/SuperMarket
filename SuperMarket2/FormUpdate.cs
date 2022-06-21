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
    public partial class FormUpdate : Form
    {
        private User user;
        List<User> users = new List<User>();
        public FormUpdate()
        {
            InitializeComponent();
        }

        public FormUpdate(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLProcedures.UpdateUsers(user.Id, textBoxName.Text, textBoxSurname.Text, textBoxPassword.Text, 
                Convert.ToInt32(ageNumericUpDown.Text),textBoxAddress.Text, textBoxPhoneNumber.Text);
            this.Hide();
        }
    }
}
