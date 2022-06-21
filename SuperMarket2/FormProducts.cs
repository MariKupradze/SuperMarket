using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SuperMarket2
{
    public partial class FormProducts : Form
    {
        List<Product> products = new List<Product>();
        User user;
        public FormProducts(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
            /*
            Panel panel = new Panel();
            int PanelHeight = 100;
            int PanelWidth = 800;
            panel.Location = new Point(10, 10);
            panel.Size = new Size(PanelWidth, PanelHeight);
            panel.BackColor = Color.LightGray;*/

            //panel.BorderStyle = BorderStyle.Fixed3D;
            int a = 0;
            for (int i = 0; i < 10; i++)
            {

                Panel panel = new Panel();
                int PanelHeight = 100;
                int PanelWidth = 800;
                panel.Location = new Point(10,  PanelHeight * i + 60 + a);
                panel.Size = new Size(PanelWidth, PanelHeight);
                panel.BackColor = Color.LightGray;
                panel.BorderStyle = BorderStyle.Fixed3D;



                PictureBox pictureBox = new PictureBox();
                int PictureBoxHeight = 90;
                int PictureBoxWidth = 100;
                pictureBox.Location = new Point(15, PanelHeight * i + 65 + a);
                pictureBox.Size = new Size(PictureBoxWidth, PictureBoxHeight);
                pictureBox.BackColor = Color.Red;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                //pictureBox.Image = products[i].ProductImage;


                Label label = new Label();
                label.Location = new Point(130, PanelHeight * i + 65 + a);
                label.Text = "Product Name";
                label.BackColor = Color.LightGray;


                RichTextBox richTextBox = new RichTextBox();
                int TextBoxHeight = 70;
                int TextBoxWidth = 600;
                richTextBox.Location = new Point(130, PanelHeight * i + 60 + a + Convert.ToInt32(label.Height.ToString()));
                richTextBox.Size = new Size(TextBoxWidth, TextBoxHeight);
                richTextBox.BorderStyle = BorderStyle.None;
               // richTextBox.Enabled = false;
                richTextBox.BackColor = Color.LightGray;
                richTextBox.ForeColor = Color.DimGray;
                richTextBox.ReadOnly = true;
                richTextBox.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam sit amet ipsum molestie, viverra massa quis, pulvinar ipsum. Nulla felis dolor, consectetur ac metus sed, pulvinar maximus diam. Integer sed ligula non felis lacinia aliquet. Pellentesque porttitor turpis a egestas cursus. Maecenas nec suscipit magna. Praesent venenatis lorem ac pulvinar venenatis. Curabitur ullamcorper fermentum leo, faucibus rutrum elit vehicula sed.";


                Button buttonView = new Button();
                int BtnViewHeight = 30;
                int BtnViewWidth = 50;
                buttonView.Location = new Point(740, PanelHeight * i + a + Convert.ToInt32(label.Height.ToString()) + 50);
                buttonView.Size = new Size(BtnViewWidth, BtnViewHeight);
                buttonView.Text = "View";


                Button buttonAdd = new Button();
                buttonAdd.Location = new Point(740, PanelHeight * i + a + Convert.ToInt32(label.Height.ToString()) + 90);
                buttonAdd.Size = new Size(BtnViewWidth, BtnViewHeight + 10);
                buttonAdd.Text = "Add To Cart";
                


                Controls.Add(buttonAdd);
                Controls.Add(buttonView);
                Controls.Add(richTextBox);
                Controls.Add(label);
                Controls.Add(pictureBox);
                Controls.Add(panel);

                a = a + 10;
            }

        }



        private void LoadProducts()
        {
            DataTable dt = SQLProcedures.SelectProducts();
            string a = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Product product = new Product();

                product.ProductID = Convert.ToInt32(dt.Rows[i]["ProductID"]);
                product.ProductName = Convert.ToString(dt.Rows[i]["ProductName"]);
                product.ProductSummary = Convert.ToString(dt.Rows[i]["ProductSummary"]);
                product.ProductSummary = Convert.ToString(dt.Rows[i]["ProductSummary"]);
                product.ProductPrice = Convert.ToDouble(dt.Rows[i]["ProductPrice"]);
                product.ProductQuantity = Convert.ToInt32(dt.Rows[i]["ProductQuantity"]);

                a = Convert.ToString(dt.Rows[i]["ProductImage"]);
                /*for (int j = 0; i < a.Length; i++)
                {
                    product.ProductImage[i] = Convert.ToByte(a[i]);
                }*/

                products.Add(product);
            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Account account = new Account(user);
            account.ShowDialog();
            Hide();
        }
    }
}
