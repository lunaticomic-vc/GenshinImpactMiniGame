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
    public partial class fontaine : Form
    {
        public fontaine()
        {
            InitializeComponent();
        }
        private static List<string> CreateCommand(string queryString, string connectionString)
        {
            List<string> spisyk = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                using(SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection))
                {
                    while (reader.Read())
                    {
                        spisyk.Add(Convert.ToString(reader[0]));
                    }
                }
            }
            return spisyk;
        }
        private void fontaine_Load(object sender, EventArgs e)
        {
            
            foreach(string item in CreateCommand("Select enemyname from enemy where kingdomid=7", @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True"))
            {
                listBox1.Items.Add(item);
            }
            
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd2 = new SqlCommand("Select xp from players where username=@user");
            cmd2.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd2.Connection = conn;

            
            SqlCommand cmd3 = new SqlCommand("Select coins from players where username=@user");
            cmd3.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd3.Connection = conn;

            conn.Open();
            label3.Text= Convert.ToString(cmd2.ExecuteScalar());
            label5.Text= Convert.ToString(cmd3.ExecuteScalar());
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd2 = new SqlCommand("Select charhp from characters where charname=@chara");
            cmd2.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            cmd2.Connection = conn;
            
            SqlCommand cmd1 = new SqlCommand("update characters set charhp+=1000 where charname=@chara");
            cmd1.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            cmd1.Connection = conn;

            SqlCommand cmd = new SqlCommand("update characters set charlevel+=1 where charname=@chara");
            cmd.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            cmd.Connection = conn;

            SqlCommand cmd3 = new SqlCommand("Select hp from enemy where enemyname=@ene");
            cmd3.Parameters.AddWithValue("@ene", Convert.ToString(listBox1.SelectedItem));
            cmd3.Connection = conn;

            SqlCommand cmd5 = new SqlCommand("Select xp from players where username=@user");
            cmd5.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd5.Connection = conn;

            SqlCommand cmd6 = new SqlCommand("Update players set xp-=500 where username=@user AND xp>=500");
            cmd6.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd6.Connection = conn;

            SqlCommand cmd7 = new SqlCommand("Update players set xp+=200 where username=@user");
            cmd7.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd7.Connection = conn;

            SqlCommand cmd10 = new SqlCommand("Update enemy set hp+=200 where enemyname=@ene");
            cmd10.Parameters.AddWithValue("@ene", Convert.ToString(listBox1.SelectedItem));
            cmd10.Connection = conn;

            SqlCommand cmd11 = new SqlCommand("Select charlevel from characters where charname=@chara");
            cmd11.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            cmd11.Connection = conn;
            
            SqlCommand cmd12 = new SqlCommand("Update players set level+=1 where username=@user");
            cmd12.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd12.Connection = conn;

             SqlCommand cmd15 = new SqlCommand("select playerlevel from players where username=@user");
            cmd15.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd15.Connection = conn;
            
            SqlCommand cmd17 = new SqlCommand("Update players set coins+=1 where username=@user");
            cmd17.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd17.Connection = conn;

            
            SqlCommand cmd20 = new SqlCommand("Select coins from players where username=@user");
            cmd20.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd20.Connection = conn;


            conn.Open();
            if(Convert.ToInt32(cmd2.ExecuteScalar())>Convert.ToInt32(cmd3.ExecuteScalar()))
            {
                label1.Text="Win!";
                cmd17.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
                cmd10.ExecuteNonQuery();
                label3.Text= Convert.ToString(cmd5.ExecuteScalar());
                label5.Text= Convert.ToString(cmd20.ExecuteScalar());
                if(Convert.ToInt32(cmd5.ExecuteScalar())>=Convert.ToInt32(Math.Pow(Convert.ToInt32(cmd11.ExecuteScalar()),2)*1000))
                {
                    cmd12.ExecuteNonQuery();
                    MessageBox.Show("Level "+cmd11.ExecuteScalar()+" reached!");
                }
                if(Convert.ToInt32(cmd15.ExecuteScalar())%5==0)
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                }
            }
            else 
            { 
                label1.Text="Lose!"; 
            if(Convert.ToInt32(cmd5.ExecuteScalar())<500)MessageBox.Show("You don't have enough XP to fight! Come back again!");
                else {cmd6.ExecuteNonQuery();
                label3.Text= Convert.ToString(cmd5.ExecuteScalar()); }
            }
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
                    this.Hide();
                    Form3 nextForm = new Form3();
                    nextForm.ShowDialog();
                    Close();

        }
    }
}
