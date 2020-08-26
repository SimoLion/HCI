using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using System.Drawing.Printing;

namespace E_coffeeshop
{
    public partial class Print : Form
    {
        private int id;

        public Print(int userid)
        {
            InitializeComponent();
            this.id = userid;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "All Files|*.*|Texts| *.txt; *.docx;*.pdf|Images| *.jpg; *.png ";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                //string filenameforprint = fd.FileName;
                // MessageBox.Show(filenameforprint);
                PrintDialog dlg = new PrintDialog();
                dlg.ShowDialog();
                PdfDocument pdf = new PdfDocument();
                //pdf.LoadFromFile("notes.pdf");

            }
            else
            {
                MessageBox.Show("File not Loaded");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id);

            this.Visible = false;

            hm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
