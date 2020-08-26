using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace E_coffeeshop
{
    public partial class Home : Form
    {
        private int id;

        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database.mdb";
        OleDbConnection connection;

        public Home(int userid)
        {
            InitializeComponent();
            this.id = userid;
        }



        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1(id);

            this.Visible = false;

            fm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            button3.Visible = false;

            try
            {

                connection = new OleDbConnection(connectionString);
                connection.Open();

                String query1 = " select FName from LibUser  where User_id = " + id + "  ";
                OleDbCommand command1 = new OleDbCommand(query1, connection);

                string Fname = (command1.ExecuteScalar()).ToString();

                String query2 = " select LName from LibUser  where User_id = " + id + "  ";

                OleDbCommand command2 = new OleDbCommand(query2, connection);
                string Lname = (command2.ExecuteScalar()).ToString();

                label1.Text = "" + Fname + "";

                connection.Close();

            }
            catch (Exception ex)
            { MessageBox.Show("eRROR" + ex); }



            if (id == 1)
            {
                button1.Visible = true;
            }

            else
            {
                button2.Visible = false;
                label11.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Search sr = new Search(id);

            this.Visible = false;

            sr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Search sr = new Search(id);

            this.Visible = false;

            sr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cafe cf = new Cafe(id);

            this.Visible = false;

            cf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Cafe cf = new Cafe(id);

            this.Visible = false;

            cf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Card cr = new Card(id);

            this.Visible = false;

            cr.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Card cr = new Card(id);

            this.Visible = false;

            cr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πρόγραμμα Μεταπτυχιακών Σπουδών «Πληροφορική»" + "\n" + "Μάθημα Αλληλεπίδραση Ανθρώπου - Υπολογιστή " + "\n" + "Μεταπτυχιακοί Φοιτητές: " + "\n" + "Σχίζα Όλγα ΜΠΠΛ180ΧΧ" + "\n" + "Ζαπσής Συμεών ΜΠΠΛ18018");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πρόγραμμα Μεταπτυχιακών Σπουδών «Πληροφορική»" + "\n" + "Μάθημα Αλληλεπίδραση Ανθρώπου - Υπολογιστή " + "\n" + "Μεταπτυχιακοί Φοιτητές: " + "\n" + " Σχίζα Όλγα ΜΠΠΛ180ΧΧ" + "\n" + "Ζαπσής Συμεών ΜΠΠΛ18018");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Print pr = new Print(id);

            this.Visible = false;

            pr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Scan sc = new Scan(id);

            this.Visible = false;

            sc.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Print pr = new Print(id);

            this.Visible = false;

            pr.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Scan sc = new Scan(id);

            this.Visible = false;

            sc.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Bookbindink bd = new Bookbindink(id);

            this.Visible = false;

            bd.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bookbindink bd = new Bookbindink(id);

            this.Visible = false;

            bd.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Basket bk = new Basket(id);

            this.Visible = false;

            bk.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Basket bk = new Basket(id);

            this.Visible = false;

            bk.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ControlRoom cr = new ControlRoom(id);

            this.Visible = false;

            cr.Show();

        }

        private void button3_Click(object sender, EventArgs e)

        {
            this.BackgroundImage = Properties.Resources.home;
            button11.Visible = true;
            button3.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.homeBlack;
            button3.Visible = true;
            button11.Visible = false;
        }
    }

}
