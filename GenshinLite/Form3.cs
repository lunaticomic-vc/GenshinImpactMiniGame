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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("Select streak from players where username=@user");
            cmd.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd.Connection = conn;

            SqlCommand cmd1 = new SqlCommand("Select playerlevel from players where username=@user");
            cmd1.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd1.Connection = conn;

            SqlCommand cmd2 = new SqlCommand("Select xp from players where username=@user");
            cmd2.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd2.Connection = conn;

            
            SqlCommand cmd9 = new SqlCommand("Select charhp from characters where charname=@chara");
            cmd9.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            cmd9.Connection = conn;

            conn.Open();


           streak.Text=Convert.ToString(cmd.ExecuteScalar());
            level.Text=Convert.ToString(cmd1.ExecuteScalar());
            xp.Text= Convert.ToString(cmd2.ExecuteScalar());
            label7.Text=Form1.SetValueForText1;
            label9.Text=Convert.ToString(cmd9.ExecuteScalar());
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {   
                    this.Hide();
                    mondstadt nextForm = new mondstadt();
                    nextForm.ShowDialog();
                    Close();
            }
            else if(radioButton2.Checked==true)
            {   
                    this.Hide();
                    liyue nextForm = new liyue();
                    nextForm.ShowDialog();
                    Close();
            }else if(radioButton3.Checked==true)
            {   
                    this.Hide();
                    inazuma nextForm = new inazuma();
                    nextForm.ShowDialog();
                    Close();
            }else if(radioButton4.Checked==true)
            {   
                    this.Hide();
                    sumeru nextForm = new sumeru();
                    nextForm.ShowDialog();
                    Close();
            }else if(radioButton5.Checked==true)
            {   
                    this.Hide();
                    snezhnaya nextForm = new snezhnaya();
                    nextForm.ShowDialog();
                    Close();
            }else if(radioButton6.Checked==true)
            {   
                    this.Hide();
                    natlan nextForm = new natlan();
                    nextForm.ShowDialog();
                    Close();
            } else if (radioButton7.Checked==true)
            {   
                    this.Hide();
                    fontaine nextForm = new fontaine();
                    nextForm.ShowDialog();
                    Close();
            }
            else  {   
                    this.Hide();
                   Shop nextForm = new Shop();
                    nextForm.ShowDialog();
                    Close();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        public static bool ratata=false;

        private void button1_Click(object sender, EventArgs e)
        {
            
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("update players set xp+=streak*100 where username=@user");
            cmd.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd.Connection = conn;

                SqlCommand cmd5 = new SqlCommand("select CONVERT(date, lastdateclaimed) from players where username=@user");
            cmd5.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd5.Connection = conn;
            
                SqlCommand cmd7 = new SqlCommand("update players set lastdateclaimed=getdate() where username=@user");
            cmd7.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd7.Connection = conn;

            SqlCommand cmd2 = new SqlCommand("Select xp from players where username=@user");
            cmd2.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd2.Connection = conn;

            SqlCommand cmd8 = new SqlCommand("Select CONVERT(date, GETDATE()) from players where username=@user");
            cmd8.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            cmd8.Connection = conn;

            conn.Open();

            if(Convert.ToString(cmd5.ExecuteScalar())==Convert.ToString(cmd8.ExecuteScalar()))
                MessageBox.Show("Daily bonus has already been collected!");
            else
            {
            cmd.ExecuteNonQuery();
                cmd7.ExecuteNonQuery();
            xp.Text= Convert.ToString(cmd2.ExecuteScalar());
                MessageBox.Show("Daily bonus collected!");

            }

            conn.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
                   settings nextForm = new settings();
                    nextForm.ShowDialog();
                    Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
                   Stats nextForm = new Stats();
                    nextForm.ShowDialog();
                    Close();

        }
    }
}
