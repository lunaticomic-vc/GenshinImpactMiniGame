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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("insert into Players(playerid, Username, playerlevel, dateloggedfirst, CharCode, KingdomCode, birthday, pass, xp, lastlogged, streak, coins) select count (*) +1, @user, 1, Getdate(), ABS(CHECKSUM(NEWID()) %60)+1, ABS(CHECKSUM(NEWID()) %7)+1, @birthdate, @pass, 0, getdate(), 1, 0 from players");
            cmd.Connection = conn;
            cmd.Parameters.AddWithValue("@pass", this.textBox2.Text);
            cmd.Parameters.AddWithValue("@user", this.textBox1.Text);
            cmd.Parameters.AddWithValue("@birthdate", this.dateTimePicker1.Value); 
            conn.Open();
            if(!UserNameCheck() && PassMatch()==true)            
                { 
                    Form1.SetValueForText1=Convert.ToString(textBox1.Text);
                    cmd.ExecuteNonQuery(); 
                    conn.Close(); 
                    this.Hide();
                    CharacterChoice nextForm = new CharacterChoice();
                    nextForm.ShowDialog();
                    Close(); 
               }
            else if (UserNameCheck()==true && !PassMatch()) MessageBox.Show("This username is already taken!");
            else if (UserNameCheck()==true && PassMatch()==true)MessageBox.Show("This username is already taken!");
            else if (!PassMatch())MessageBox.Show("Passwords don't match!");
            
        }
    }
}
