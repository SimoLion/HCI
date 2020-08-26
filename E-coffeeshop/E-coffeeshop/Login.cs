using System;
using System.Data.OleDb;
using System.Windows.Forms;





namespace E_coffeeshop
{
    public partial class Login : Form
    {
        String connectionString = "Provider =Microsoft.Jet.OLEDB.4.0;Data Source = Database.mdb";
        OleDbConnection connection;


        public Login()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                connection.Open();
                String query = " select User_id  from LibUser where Username = '" + textBox1.Text + "'and Pass = '" + textBox2.Text + "' ";
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbCommand command2 = new OleDbCommand(query, connection);
                OleDbDataReader reader = command.ExecuteReader();


                int count = 0;

                while (reader.Read())
                {
                    count += 1;

                }

                if (count == 1)
                {


                    int output = (int)command2.ExecuteScalar();
                    connection.Close();

                    Home hm = new Home(output);

                    this.Visible = false;

                    hm.Show();

                }
                else { MessageBox.Show("Check username or password"); }

            }
            else { MessageBox.Show("Input username or password"); }

            connection.Close();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            try
            {
                connection = new OleDbConnection(connectionString);
            }

            catch (Exception ex)
            {
                MessageBox.Show("eRROR" + ex);
            }

        }

    }
}
