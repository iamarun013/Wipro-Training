using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Inventory_Management_System
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e) //Header Manager user title label
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KIIT\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "SELECT * FROM UserTable";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UserGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO UserTable (Uname, Ufullname, Upassword, Uphone) VALUES (@UName, @FName, @Password, @Phone)";
            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.Parameters.AddWithValue("@UName", unameTb.Text);
            cmd.Parameters.AddWithValue("@FName", FnameTb.Text);
            cmd.Parameters.AddWithValue("@Password", PasswordTb.Text);
            cmd.Parameters.AddWithValue("@Phone", PhoneTb.Text);

            try
            {
                Con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully added");
                Con.Close();
                populate(); // Call the populate method to refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); // Show the error message for debugging
                Con.Close();
            }
        }

        private void UserGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populate();

        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit functionality not implemented yet.");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete functionality not implemented yet.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home button clicked.");
        }
    }
}
