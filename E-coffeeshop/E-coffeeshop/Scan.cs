using System;
using System.Windows.Forms;

namespace E_coffeeshop
{
    public partial class Scan : Form
    {
        private int id;

        public Scan(int userid)
        {
            InitializeComponent();
            this.id = userid;
            pictureBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id);

            this.Visible = false;

            hm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
        }
    }
}
