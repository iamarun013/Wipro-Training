namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            unameTB.Text = "";
            upassTB.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                upassTB.UseSystemPasswordChar = false; // Mask password
            }
            else
            {
                upassTB.UseSystemPasswordChar = true; // Show password as plain text
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}