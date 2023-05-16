using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyFoot
{
    public partial class Form1 : Form
    {
        Button butt;
        Timer timer1;
        int score1 = 0;
        int score2 = 0;
        public Form1()
        {
            InitializeComponent();
            //this.KeyDown += Form1_KeyDown;
            timer1 = new Timer();
            timer1.Interval = 1000; // Interval défini à 1 seconde
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Logique à exécuter lorsqu'une touche est pressée (KeyPress)
            if (e.KeyCode == Keys.Enter)
            {
                // La touche "Enter" a été enfoncée
                MessageBox.Show("La touche 'Enter' a été enfoncée !");
                A1.Location = new Point(350, 247);
            }
        }

        private void SetLocationBall1(Button nomBouton)
        {
            Point buttonLocation = nomBouton.Location;
            int x = buttonLocation.X;
            int y = buttonLocation.Y;
            Size buttonSize = nomBouton.Size;
            int width = buttonSize.Width;
            int height = buttonSize.Height;

            ball.Location = new Point(x + width - 3, y);
            //MessageBox.Show((x + width - 3).ToString());
        }

        private void SetLocationBall2(Button nomBouton)
        {
            Point buttonLocation = nomBouton.Location;
            int x = buttonLocation.X;
            int y = buttonLocation.Y;
            Size buttonSize = nomBouton.Size;
            int width = buttonSize.Width;
            int height = buttonSize.Height;

            ball.Location = new Point(x - width, y);
            //MessageBox.Show((x - width).ToString());
        }

        public Button GetBall()
        {
            return butt; 
        }

        public void HaveBall(Button nomBouton)
        {
            this.butt = nomBouton;
        }
        public int GetScore1()
        {
            return this.score1; 
        }

        public void SetScore1()
        {
            this.score1 = this.score1 + 1;
        }
        public int GetScore2()
        {
            return this.score2; 
        }

        public void SetScore2()
        {
            this.score2 = this.score2 + 1;
        }

        public List<Button> GetButtons(Control parentControl)
        {
            List<Button> buttons = new List<Button>();

            foreach (Control control in parentControl.Controls)
            {
                if (control is Button button)
                {
                    buttons.Add(button);
                }
                else if (control.HasChildren)
                {
                    buttons.AddRange(GetButtons(control));
                }
            }

            return buttons;
        }



        private void SetHandA(int x)
        {
            int y = 370;
            mainA.Location = new Point(x, y);
        }
        private void SetHandB(int x)
        {
            int y = 24;
            mainB.Location = new Point(x, y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A9);
            SetHandA(236);
            HaveBall(A9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A8);
            SetHandA(236);
            HaveBall(A8);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B6);
            SetHandB(333);
            HaveBall(B6);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A10);
            SetHandA(420);
            HaveBall(A10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B2);
            SetHandB(500);
            HaveBall(B2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B3);
            SetHandB(500);
            HaveBall(B3);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void A1_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A1);
            SetHandA(24);
            HaveBall(A1);
        }

        private void A2_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A2);
            SetHandA(86);
            HaveBall(A2);
        }

        private void A3_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A3);
            SetHandA(86);
            HaveBall(A3);
        }

        private void A4_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A4);
            SetHandA(86);
            HaveBall(A4);
        }

        private void B10_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B10);
            SetHandB(165);
            HaveBall(B10);
        }

        private void B11_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B11);
            SetHandB(165);
            HaveBall(B11);
        }

        private void B12_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B12);
            SetHandB(165);
            HaveBall(B12);
        }

        private void A5_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A5);
            SetHandA(236);
            HaveBall(A5);
        }

        private void A6_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A6);
            SetHandA(236);
            HaveBall(A6);
        }

        private void A7_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A7);
            SetHandA(236);
            HaveBall(A7);
        }

        private void B5_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B5);
            SetHandB(333);
            HaveBall(B5);
        }

        private void B7_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B7);
            SetHandB(333);
            HaveBall(B7);
        }

        private void B8_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B8);
            SetHandB(333);
            HaveBall(B8);
        }

        private void B9_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B9);
            SetHandB(333);
            HaveBall(B9);
        }

        private void A11_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A11);
            SetHandA(420);
            HaveBall(A11);
        }

        private void A12_Click(object sender, EventArgs e)
        {
            SetLocationBall1(A12);
            SetHandA(420);
            HaveBall(A12);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B1);
            SetHandB(552);
            HaveBall(B1);
        }

        private void B4_Click(object sender, EventArgs e)
        {
            SetLocationBall2(B4);
            SetHandB(500);
            HaveBall(B4);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = ball.Location.X;
            Random random = new Random();
            if(x == 51 || x == 114 || x == 264 || x == 447)
            {
                int rand = random.Next(175, 230);
                ball.Location = new Point(565, rand);
                SetScore1();
                int s1 = GetScore1();
                label3.Text = s1.ToString();
                MessageBox.Show("aaaaa");
            }else if (x == 519 || x == 466 || x == 300 || x == 128)
            {
                int rand = random.Next(175, 230);
                ball.Location = new Point(8, rand);
                SetScore2();
                int s2 = GetScore2();
                label4.Text = s2.ToString();
            }
        }

        private void tsymaty_Click(object sender, EventArgs e)
        {
            int x = ball.Location.X;
            if (x == 51 || x == 114 || x == 264 || x == 447)
            {
                SetLocationBall2(B1);
                List<Button> but = GetButtons(this);
                foreach (Button butt in but)
                {
                    MessageBox.Show(butt.ToString());
                }
                
            }
            else if (x == 519 || x == 466 || x == 300 || x == 128)
            {
                SetLocationBall1(A1);
            }
        }

        private void piece_Click(object sender, EventArgs e)
        {
            Button[] tab1 = { A2, A3, A4 };
            Button[] tab2 = { A5, A6, A7, A8, A9 };
            Button[] tab3 = { A10, A11, A12 };
            Button[] tab4 = { B2, B3, B4 };
            Button[] tab5 = { B5, B6, B7, B8, B9 };
            Button[] tab6 = { B10, B11, B12 };
            Button[][] tabA = { tab1 };
            //Button[][] tabA = { tab1, tab2, tab3 };
            Button[][] tabB = { tab4, tab5, tab6 };
            int x = ball.Location.X;
            Random random = new Random();    

            // pour A
            
            if ( x == 114 )
            {
                for (int i = 0; i < tab1.Length; i++)
                {
                    if (tab1[i] == GetBall() && tab1[i+1] != null)
                    {
                        SetLocationBall1(tab1[i+1]);
                        MessageBox.Show(tab1[i+1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    else
                    {
                        SetLocationBall1(A3);
                        MessageBox.Show(A3.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    break;
                }
            }
            if ( x == 264 )
            {
                for (int i = 0; i < tab2.Length; i++)
                {
                    if (tab2[i] == GetBall() && tab2[i + 1] != null)
                    {
                        SetLocationBall1(tab2[i + 1]);
                        MessageBox.Show(tab2[i + 1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    else
                    {
                        SetLocationBall1(A8);
                        MessageBox.Show(A8.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    break;
                }
            }
            if ( x == 447)
            {
                for (int i = 0; i < tab3.Length; i++)
                {
                    if (tab3[i] == GetBall() && tab3[i + 1] != null)
                    {
                        SetLocationBall1(tab3[i + 1]);
                        MessageBox.Show(tab3[i + 1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    else
                    {
                        SetLocationBall1(A11);
                        MessageBox.Show(A11.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(565, rand);
                    }
                    break;
                }
            }

            // pour B

            if (x == 466)
            {
                for (int i = 0; i < tab4.Length; i++)
                {
                    if (tab4[i] == GetBall() && tab4[i + 1] != null)
                    {
                        SetLocationBall2(tab4[i + 1]);
                        MessageBox.Show(tab4[i + 1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    else
                    {
                        SetLocationBall2(B3);
                        MessageBox.Show(B3.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    break;
                }
            }
            if (x == 300)
            {
                for (int i = 0; i < tab5.Length; i++)
                {
                    if (tab5[i] == GetBall() && tab5[i + 1] != null)
                    {
                        SetLocationBall2(tab5[i + 1]);
                        MessageBox.Show(tab5[i + 1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    else
                    {
                        SetLocationBall2(B8);
                        MessageBox.Show(B8.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    break;
                }
            }
            if (x == 128)
            {
                for (int i = 0; i < tab6.Length; i++)
                {
                    if (tab6[i] == GetBall() && tab6[i + 1] != null)
                    {
                        SetLocationBall2(tab6[i + 1]);
                        MessageBox.Show(tab6[i + 1].ToString());
                        timer1 = new Timer();
                        timer1.Interval = 10000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    else
                    {
                        SetLocationBall2(B11);
                        MessageBox.Show(B11.ToString());
                        timer1 = new Timer();
                        timer1.Interval = 1000; // Définissez ici l'intervalle souhaité en millisecondes
                        timer1.Start();
                        timer1.Stop();
                        int rand = random.Next(175, 230);
                        ball.Location = new Point(8, rand);
                    }
                    break;
                }
            }

            /*if (x == 519 || x == 466 || x == 300 || x == 128)
            {
                for (int i = 0; i < tabB.Length; i++)
                {
                    for (int j = 0; j <= tabB[i].Length; j++)
                    {
                        //MessageBox.Show(tab[i].Location.X.ToString());
                        if (tabB[i][j + 1] != null)
                        {
                            SetLocationBall2(tabB[i][j + 1]);
                            int rand = random.Next(175, 230);
                            ball.Location = new Point(8, rand);
                        }
                        else
                        {
                            SetLocationBall2(tabB[i][j - 1]);
                            int rand = random.Next(175, 230);
                            ball.Location = new Point(8, rand);
                        }
                    }
                }
            }*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void goal1_Click(object sender, EventArgs e)
        {
            Button goal1 = new Button();
            goal1.BackColor = Color.Red;
            goal1.Location = new Point(26, 247);
            goal1.Name = "goal";
            goal1.Size = new Size(46, 34);
            goal1.TabIndex = 1;
            goal1.Text = "A1";
            goal1.UseVisualStyleBackColor = false;
            goal1.Click += new System.EventHandler(this.A1_Click);
            this.Controls.Add(goal1);
            this.Refresh();
        }

        private void goal2_Click(object sender, EventArgs e)
        {

        }
    }
}
