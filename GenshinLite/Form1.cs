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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
        public bool PassWordCheck()
        {
            
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("Select count(*) from Players where pass=@pass AND username=@user");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@pass", this.textBox2.Text);
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
        public static string SetValueForText1 = "";
        private void button2_Click(object sender, EventArgs e)
        {
            SetValueForText1=textBox1.Text;
            if(!(UserNameCheck())) 
            {  
             MessageBox.Show("Incorrect username or password!");
            }
            else 
            { 
                 if(!(PassWordCheck()))
                {
                    
             MessageBox.Show("Incorrect username or password!"); } 
                else 
                { 
                    string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
                    SqlConnection conn = new SqlConnection(con);
                    SqlCommand cmd = new SqlCommand("update players set streak+=1 where username=@user");
                    SqlCommand cmd1 = new SqlCommand("Select lastlogged from players where username=@user");
                    SqlCommand cmd2 = new SqlCommand("Select DATEADD(day, -1, GETDATE()) from players where username=@user");
                    SqlCommand cmd3 = new SqlCommand("update players set streak=1 where username=@user");
                    cmd.Connection = conn;
                    cmd1.Connection=conn;
                    cmd2.Connection=conn;
                    cmd3.Connection=conn;
                    cmd.Parameters.AddWithValue("@user", this.textBox1.Text);
                    cmd1.Parameters.AddWithValue("@user", this.textBox1.Text);
                    cmd2.Parameters.AddWithValue("@user", this.textBox1.Text);
                    cmd3.Parameters.AddWithValue("@user", this.textBox1.Text);
                    conn.Open();
                    if(cmd1.ExecuteScalar()==cmd2.ExecuteScalar())cmd.ExecuteNonQuery();
                    else cmd3.ExecuteNonQuery();
                    this.Hide();
                    CharacterChoice nextForm = new CharacterChoice();
                    nextForm.ShowDialog();
                    Close(); 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
                    Form4 nextForm = new Form4();
                    nextForm.ShowDialog();
                    Close();
        }
    }
}
