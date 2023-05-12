using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BabyFoot
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void mise1_Click(object sender, EventArgs e)
        {
            Connexion con = new Connexion();
            NpgsqlConnection conne = con.GetConn();
            conne.Open();
            textBox1.AppendText("Bonjour, monde!");
            conne.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 jeu = new Form1();
            //jeu.Show();
            jeu.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
