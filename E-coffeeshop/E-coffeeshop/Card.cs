using System;
using System.Windows.Forms;

namespace E_coffeeshop
{
    public partial class Card : Form
    {
        private int id;

        public Card(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credit card added!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id);

            this.Visible = false;

            hm.Show();
        }
    }
}
