using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP04_200581
{
    public partial class FrmPrincipal : Form
    {
        #region Inicializção
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Variáveis Globais
        int vezdojogador = 0;
        int casa1, casa2, casa3, casa4, casa5, casa6, casa7, casa8, casa9;
        int contador1 = 0;
        int contador2 = 0;
        #endregion

        #region Casa2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa2 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa2 = 2;
            }
            trocavezdojogador2(casa2);


            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa3 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa3 = 2;
            }
            else if (casa3 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador3(casa3);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa4 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa4 = 2;
            }
            else if (casa4 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador4(casa4);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa5
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa5 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa5 = 2;
            }
            else if (casa5 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador5(casa5);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa6

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa6 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa6 = 2;
            }
            else if (casa6 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador6(casa6);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa7

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa7 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa7 = 2;
            }
            else if (casa7 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador7(casa7);
            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa8

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa8 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa8 = 2;
            }
            else if (casa8 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador8(casa8);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Casa9

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa9 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa9 = 2;
            }
            else if (casa9 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador9(casa9);

            verificaseexisteumvencedor();

        }
        #endregion

        #region Lixo
        private void LblPlacarPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void LblPlacarPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void LblPlayer2_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Nome Player 1
        private void TxtNomePlayer1_TextChanged(object sender, EventArgs e)
        {
            LblMostrarNomePlayer1.ForeColor = Color.Blue;
            LblMostrarNomePlayer1.Text = TxtNomePlayer1.Text;
            LblVezDoJogador.Text = "1 ( X )";
            vezdojogador = 1;

            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
        }
        #endregion

        #region Nome Player 2
        private void TxtNomePlayer2_TextChanged(object sender, EventArgs e)
        {
            LblMostrarNomePlayer2.ForeColor = Color.Red;
            LblMostrarNomePlayer2.Text = TxtNomePlayer2.Text;
        }
        #endregion

        #region Lixo
        private void LblVezDoJogador_Click(object sender, EventArgs e)
        {


        }

        #endregion

        #region Casa1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (vezdojogador == 1)
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgX.png");
                casa1 = 1;
            }
            else if (vezdojogador == 2)
            {
                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgO.png");
                casa1 = 2;
            }
            else if (casa1 == 1)
            {
                vezdojogador = 2;
            }
            else
            {
                vezdojogador = 1;
            }

            trocavezdojogador1(casa1);

            verificaseexisteumvencedor();
        }
        #endregion

        #region Verifica se existe um vencedor

        void verificaseexisteumvencedor()
        {
            if (casa1 == 1 && casa2 == 1 && casa3 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();

      

                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;

                
            }
            else if (casa4 == 1 && casa5 == 1 && casa6 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa7 == 1 && casa8 == 1 && casa9 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa1 == 1 && casa4 == 1 && casa7 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa2 == 1 && casa5 == 1 && casa8 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa3 == 1 && casa6 == 1 && casa9 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa1 == 1 && casa5 == 1 && casa9 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa3 == 1 && casa5 == 1 && casa7 == 1)
            {
                MessageBox.Show("O player 1 ( X ) Venceu !!!");
                contador1++;

                LblContagemPlayer1.Text = contador1.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa1 == 2 && casa2 == 2 && casa3 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa4 == 2 && casa5 == 2 && casa6 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa7 == 2 && casa8 == 2 && casa9 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa1 == 2 && casa4 == 2 && casa7 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa2 == 2 && casa5 == 2 && casa8 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

            }
            else if (casa3 == 2 && casa6 == 2 && casa9 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa1 == 2 && casa5 == 2 && casa9 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;
            }
            else if (casa3 == 2 && casa5 == 2 && casa7 == 2)
            {
                MessageBox.Show("O player 2 ( O ) Venceu !!!");
                contador2++;

                LblContagemPlayer2.Text = contador2.ToString();


                pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
                pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

                casa1 = 0;
                casa2 = 0;
                casa3 = 0;
                casa4 = 0;
                casa5 = 0;
                casa6 = 0;
                casa7 = 0;
                casa8 = 0;
                casa9 = 0;

            }
            else
            {
               
            }
        }
        
        #endregion

        #region trocavezdojogador2
        void trocavezdojogador2(int casa2)
        {
            if (casa2 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region Reiniciar O Jogo
        private void BtnReiniciarJogo_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

            LblContagemPlayer1.Text = " ";
            LblContagemPlayer2.Text = " ";

            TxtNomePlayer1.Clear();
            TxtNomePlayer2.Clear();

            contador1 = 0;
            contador2 = 0;

            casa1 = 0;
            casa2 = 0;
            casa3 = 0;
            casa4 = 0;
            casa5 = 0;
            casa6 = 0;
            casa7 = 0;
            casa8 = 0;
            casa9 = 0;

            vezdojogador = 1;
        }
        #endregion

        #region Empate
        private void BtnEmpate_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox2.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox3.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox4.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox5.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox6.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox7.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox8.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");
            pictureBox9.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ImgQuestion.png");

            casa1 = 0;
            casa2 = 0;
            casa3 = 0;
            casa4 = 0;
            casa5 = 0;
            casa6 = 0;
            casa7 = 0;
            casa8 = 0;
            casa9 = 0;
        }
        #endregion

        #region trocavezdojogador3
        void trocavezdojogador3(int casa3)
        {
            if (casa3 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador4
        void trocavezdojogador4(int casa4)
        {
            if (casa4 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador5
        void trocavezdojogador5(int casa5)
        {
            if (casa5 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }


        }
        #endregion

        #region trocavezdojogador6
        void trocavezdojogador6(int casa6)
        {
            if (casa6 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador7
        void trocavezdojogador7(int casa7)
        {
            if (casa7 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador8
        void trocavezdojogador8(int casa8)
        {
            if (casa8 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador9
        void trocavezdojogador9(int casa9)
        {
            if (casa9 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion

        #region trocavezdojogador1
        void trocavezdojogador1(int casa1)
        {
            if (casa1 == 1)
            {
                vezdojogador = 2;
                LblVezDoJogador.Text = "2 ( O )";
            }
            else
            {
                vezdojogador = 1;
                LblVezDoJogador.Text = "1 ( X )";
            }
        }
        #endregion
    }
}
