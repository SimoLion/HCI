﻿using System;
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
    public partial class Basket : Form
    {
        private int id;

        public Basket(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id);

            this.Visible = false;

            hm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your pay confirmed");
        }
    }
}
