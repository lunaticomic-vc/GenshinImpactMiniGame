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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand hp = new SqlCommand("Select charhp from characters where charname=@chara");
            hp.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            hp.Connection = conn;
            SqlCommand coins = new SqlCommand("Select coins from players where username=@user");
            coins.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            coins.Connection = conn;
            
            SqlCommand alev = new SqlCommand("Select artifactlevel from artifacts where artifactname=@arti");
            alev.Parameters.AddWithValue("@arti",CharacterChoice.arti);
            alev.Connection = conn;

            conn.Open();
            label2.Text=Convert.ToString(coins.ExecuteScalar());
            label4.Text=Convert.ToString(hp.ExecuteScalar());
            label6.Text=Convert.ToString(CharacterChoice.chara);
            label8.Text=CharacterChoice.arti;
            label10.Text=CharacterChoice.wea;
            label13.Text=Convert.ToString(alev.ExecuteScalar());

            conn.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand coins = new SqlCommand("Select coins from players where username=@user");
            coins.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            coins.Connection = conn;

            SqlCommand hp = new SqlCommand("Select charhp from characters where charname=@chara");
            hp.Parameters.AddWithValue("@chara", CharacterChoice.chara);
            hp.Connection = conn;
            
            SqlCommand arti1 = new SqlCommand("update artifacts set artifactlevel+=@k from artifacts where artifactname=@arti");
            arti1.Parameters.AddWithValue("@arti",CharacterChoice.arti);
            arti1.Parameters.AddWithValue("@k", Convert.ToInt32(textBox1.Text));
            arti1.Connection = conn;

            SqlCommand arti2 = new SqlCommand("update artifacts set hp_extra+=100 from artifacts where artifactname=@arti");
            arti2.Parameters.AddWithValue("@arti",CharacterChoice.arti);
            arti2.Connection = conn;

            SqlCommand arti7 = new SqlCommand("update players set coins-=@k where username=@user");
            arti7.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            arti7.Parameters.AddWithValue("@k", Convert.ToInt32(textBox1.Text));
            arti7.Connection = conn;
            
            SqlCommand hp1 = new SqlCommand("MERGE INTO Characters   USING Artifacts      ON Characters.ArtifactCode = Artifacts.ArtifactID WHEN MATCHED THEN    UPDATE       SET CharHP = CharLevel*100 + Artifacts.HP_extra;");
            hp1.Parameters.AddWithValue("@user", Form1.SetValueForText1);
            hp1.Connection = conn;

            SqlCommand alev = new SqlCommand("Select artifactlevel from artifacts where artifactname=@arti");
            alev.Parameters.AddWithValue("@arti",CharacterChoice.arti);
            alev.Connection = conn;

            conn.Open();
            if(Convert.ToDouble(textBox1.Text)<=Convert.ToDouble(coins.ExecuteScalar()))
            {
              arti2.ExecuteNonQuery();
                arti1.ExecuteNonQuery();
                hp1.ExecuteNonQuery();
                arti7.ExecuteNonQuery();
            label2.Text=Convert.ToString(coins.ExecuteScalar());
            label4.Text=Convert.ToString(hp.ExecuteScalar());
            label13.Text=Convert.ToString(alev.ExecuteScalar());

                MessageBox.Show("Your artifact level is now "+alev.ExecuteScalar());
            }
            else MessageBox.Show("Not enough coins!"); 
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
