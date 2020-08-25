using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace E_coffeeshop
{
    public partial class Search : Form
    {
        private int id;
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";
        OleDbConnection connection;

        public Search(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.databaseDataSet.Book);
            try
            {

                connection = new OleDbConnection(connectionString);


            }
            catch (Exception ex)
            { MessageBox.Show("eRROR" + ex); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            String query1 = " select Book_id,Title,Writer,Cost from Book  ";

            OleDbCommand comm = new OleDbCommand(query1, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query1 = " select Book_id,Title,Writer,Cost from Book where Title = '" + textBox1.Text + "' ";

            OleDbCommand comm = new OleDbCommand(query1, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

            OleDbDataReader reader = comm.ExecuteReader();
            int count = 0;
            connection.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            connection.Open();
            String query1 = " select Book_id,Title,Writer,Cost from Book where Writer = '" + textBox2.Text + "' ";

            OleDbCommand comm = new OleDbCommand(query1, connection);
            OleDbDataAdapter da = new OleDbDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            OleDbDataReader reader = comm.ExecuteReader();
            connection.Close();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                MessageBox.Show("Book added");
            }
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.plus.Width;
                var h = Properties.Resources.plus.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.plus, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home hm = new Home(id);
            this.Visible = false;
            hm.Show();
        }
    }
}
