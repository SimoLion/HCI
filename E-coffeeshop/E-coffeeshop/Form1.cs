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
    public partial class Form1 : Form
    {
        private int id;
        public Form1(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (id == 1)
            {

                button1.Visible = true;
            }

            else
            {

                button2.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
