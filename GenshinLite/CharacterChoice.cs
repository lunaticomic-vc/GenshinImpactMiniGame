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
    public partial class CharacterChoice : Form
    {
        public CharacterChoice()
        {
            InitializeComponent();
        }

        private void CharacterChoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g1DataSet2.Weapons' table. You can move, or remove it, as needed.
            this.weaponsTableAdapter.Fill(this.g1DataSet2.Weapons);
            // TODO: This line of code loads data into the 'g1DataSet1.Artifacts' table. You can move, or remove it, as needed.
            this.artifactsTableAdapter.Fill(this.g1DataSet1.Artifacts);
            // TODO: This line of code loads data into the 'g1DataSet.Characters' table. You can move, or remove it, as needed.
            this.charactersTableAdapter.Fill(this.g1DataSet.Characters);

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string character = listBox1.SelectedItem.ToString();
            string artifact = listBox2.SelectedItem.ToString();
            string weapon = listBox1.SelectedItem.ToString();
        }
        
        public static string chara = "";
        public static string wea = "";
        public static string arti = "";

        private void button1_Click_1(object sender, EventArgs e)
        {
            string character = listBox1.Text;
            chara=character;
            string artifact = listBox2.Text;
            arti=artifact;
            string weapon = listBox3.Text;
            wea=weapon;
            string con = @"Data Source=KZ2-RM05\SQLEXPRESS;Initial Catalog=g1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(con);
            SqlCommand cmd = new SqlCommand("update characters set weaponid=(select weaponid from weapons where weaponname=@weapon) where charname=@character");
            SqlCommand cmd1 = new SqlCommand("update characters set artifactcode=(select artifactid from artifacts where artifactname=@artifact) where charname=@character");
            SqlCommand cmd2 = new SqlCommand("MERGE INTO Characters USING Artifacts      ON Characters.ArtifactCode = Artifacts.ArtifactID WHEN MATCHED THEN    UPDATE       SET CharHP = CharLevel*100 + Artifacts.HP_extra;");
            cmd.Connection = conn;
            cmd1.Connection = conn;
            cmd2.Connection = conn;
            cmd.Parameters.AddWithValue("@character", character);
            cmd1.Parameters.AddWithValue("@character", character);
            cmd1.Parameters.AddWithValue("@artifact", artifact);
            cmd.Parameters.AddWithValue("@weapon", weapon);
            conn.Open();
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            this.Hide();
            Form3 nextForm = new Form3();
            nextForm.ShowDialog();
            Close();
        }
    }
}
