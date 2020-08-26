using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_coffeeshop
{
    public partial class Cafe : Form
    {
        private int id;

        public Cafe(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked || checkBox4.Checked || checkBox5.Checked || checkBox6.Checked || checkBox7.Checked || checkBox8.Checked || checkBox9.Checked)
            {
                MessageBox.Show("Order confirmed");
            }
            else
            {
                MessageBox.Show("Choose something");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home hm = new Home(id);

            this.Visible = false;

            hm.Show();
        }
    }
}
