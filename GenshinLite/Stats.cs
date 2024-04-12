using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinLite
{
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g1DataSet9.SelectAll' table. You can move, or remove it, as needed.
            this.selectAllTableAdapter.Fill(this.g1DataSet9.SelectAll);
            // TODO: This line of code loads data into the 'g1DataSet6.Characters' table. You can move, or remove it, as needed.
            this.charactersTableAdapter.Fill(this.g1DataSet6.Characters);

        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Hide();
            Form3 nextForm = new Form3();
            nextForm.ShowDialog();
            Close();
        }
    }
}
