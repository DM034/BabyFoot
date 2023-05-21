using Npgsql;
using System;
using System.Windows.Forms;

namespace BabyFoot
{
    public partial class Accueil : Form
    {

        public Accueil()
        {
            InitializeComponent();
            label2.Text = GetVolaPerso(2).ToString();
            label4.Text = GetVolaPerso(3).ToString();
            label6.Text = GetVolaPerso(1).ToString();
        }

        private void mise1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conne = Connexion.GetConn();
            //conne.Open();
            textBox1.AppendText("Bonjour, monde!");
            //MessageBox.Show("Le bouton a été cliqué !");
            SetVolaMise();
            label2.Text = GetVolaPerso(2).ToString();
            label4.Text = GetVolaPerso(3).ToString();
            label6.Text = GetVolaPerso(1).ToString();
            button3.Visible = true;
            remise1.Visible = true;
            mise1.Visible = false;
            //conne.Close(); 
        }

        public static double GetVolaPerso(int id)
        {
            double idB = 0;
            NpgsqlConnection conn = Connexion.GetConn();
            using (conn)
            {
                string query = "SELECT montant FROM personne where id=" + id;

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    conn.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        idB = (double)result;
                    }
                }
            }
            return idB;
        }
        public static void SetVolaMise()
        {
            int idB = 0;
            NpgsqlConnection conn = Connexion.GetConn();
            using (conn)
            {
                double mountC = GetVolaPerso(1) + 100;
                double mount1 = GetVolaPerso(2) - 500;
                double mount2 = GetVolaPerso(3) - 500;
                string query1 = "update personne set montant=" + mount1 + "  where id=2";
                string query2 = "update personne set montant=" + mount2 + "  where id=3";
                string query3 = "update personne set montant=" + mountC + "  where id=1";
                string query = query1 + ";" + query2 + ";" + query3;

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 jeu = new Form1();
            jeu.Show();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void remise1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            remise1.Visible = false;
            mise1.Visible = true;
        }
    }
}
