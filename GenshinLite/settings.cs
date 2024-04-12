using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GenshinLite
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {

        }
         public bool UserNameCheck()
        {
            
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("Select count(*) from Players where Username=@user");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@user", this.textBox1.Text);
            conn.Open();
            int rows = 0;
            rows = Convert.ToInt32(cmd.ExecuteScalar());
            if(rows > 0)
            {   
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PassMatch()
        {
            if(textBox2.Text == textBox3.Text) return true;
            else return false;
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            label1.Visible=true;
            textBox1.Visible=true;
            label2.Visible=false;
            label3.Visible=false;
            textBox2.Visible=false;
            textBox3.Visible=false;
            button4.Visible=true;
            button5.Visible=false;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if(!UserNameCheck())
            {
                string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(con);
                    SqlCommand cmd = new SqlCommand("update players set username=@user1 where username=@user");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@user", Form1.SetValueForText1);
                    cmd.Parameters.AddWithValue("@user1", this.textBox1.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Close(); 
                    MessageBox.Show("Username successfully changed!");
            }
            else MessageBox.Show("Username taken!");

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label1.Visible=false;
            textBox1.Visible=false;
            label2.Visible=true;
            label3.Visible=true;
            textBox2.Visible=true;
            textBox3.Visible=true;
            button4.Visible=false;
            button5.Visible=true;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if(PassMatch())
            {
                string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(con);
                    SqlCommand cmd = new SqlCommand("update players set pass=@pass1 where username=@user");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@user", Form1.SetValueForText1);
                    cmd.Parameters.AddWithValue("@pass1", this.textBox2.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Close(); 
                    MessageBox.Show("Username successfully changed!");
            this.Hide();
                   Form3 nextForm = new Form3();
                    nextForm.ShowDialog();
                    Close();
                    
            }
            else MessageBox.Show("Passwords don't match!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(con);
                    SqlCommand cmd = new SqlCommand("delete from players where username=@user");
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@user", Form1.SetValueForText1);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    Close(); 
        MessageBox.Show("Thank you for playing!");
            this.Hide();
                   Form1 nextForm = new Form1();
                    nextForm.ShowDialog();
                    Close();

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
                   Form3 nextForm = new Form3();
                    nextForm.ShowDialog();
                    Close();

        }
    }
}
