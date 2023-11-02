using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletim_escolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double[] notas = new double[29];
                double[] resultadosNotas = new double[7];
                

                int falta1, falta2, falta3, falta4, resultado3;
                int falta5, falta6, falta7, falta8, resultado10;
                int falta9, falta10, falta11, falta12, resultado11;
                int falta13, falta14, falta15, falta16, resultado12;
                int falta17, falta18, falta19, falta20, resultado13;
                int falta21, falta22, falta23, falta24, resultado14;
                int falta25, falta26, falta27, falta28, resultado15;

                string resultado2 = "Resultado";
                string resultado16 = "Resultado";
                string resultado17 = "Resultado";
                string resultado18 = "Resultado";
                string resultado19 = "Resultado";
                string resultado20 = "Resultado";
                string resultado21 = "Resultado";


                notas[0] = Convert.ToDouble(txtnota1.Text);
                notas[1] = Convert.ToDouble(txtnota2.Text);
                notas[2] = Convert.ToDouble(txtnota3.Text);
                notas[3] = Convert.ToDouble(txtnota4.Text);
                notas[4] = Convert.ToDouble(txtnota5.Text);
                notas[5] = Convert.ToDouble(txtnota6.Text);
                notas[6] = Convert.ToDouble(txtnota7.Text);
                notas[7] = Convert.ToDouble(txtnota8.Text);
                notas[8] = Convert.ToDouble(txtnota9.Text);
                notas[9] = Convert.ToDouble(txtnota10.Text);
                notas[10] = Convert.ToDouble(txtnota11.Text);
                notas[11] = Convert.ToDouble(txtnota12.Text);
                notas[12] = Convert.ToDouble(txtnota13.Text);
                notas[13] = Convert.ToDouble(txtnota14.Text);
                notas[14] = Convert.ToDouble(txtnota15.Text);
                notas[15] = Convert.ToDouble(txtnota16.Text);
                notas[16] = Convert.ToDouble(txtnota17.Text);
                notas[17] = Convert.ToDouble(txtnota18.Text);
                notas[18] = Convert.ToDouble(txtnota19.Text);
                notas[19] = Convert.ToDouble(txtnota20.Text);
                notas[20] = Convert.ToDouble(txtnota21.Text);
                notas[21] = Convert.ToDouble(txtnota22.Text);
                notas[22] = Convert.ToDouble(txtnota23.Text);
                notas[23] = Convert.ToDouble(txtnota24.Text);
                notas[24] = Convert.ToDouble(txtnota25.Text);
                notas[25] = Convert.ToDouble(txtnota26.Text);
                notas[26] = Convert.ToDouble(txtnota27.Text);
                notas[27] = Convert.ToDouble(txtnota28.Text);

                falta1 = Convert.ToInt32(txtfalta1.Text);
                falta2 = Convert.ToInt32(txtfalta2.Text);
                falta3 = Convert.ToInt32(txtfalta3.Text);
                falta4 = Convert.ToInt32(txtfalta4.Text);
                falta5 = Convert.ToInt32(txtfalta5.Text);
                falta6 = Convert.ToInt32(txtfalta6.Text);
                falta7 = Convert.ToInt32(txtfalta7.Text);
                falta8 = Convert.ToInt32(txtfalta8.Text);
                falta9 = Convert.ToInt32(txtfalta9.Text);
                falta10 = Convert.ToInt32(txtfalta10.Text);
                falta11 = Convert.ToInt32(txtfalta11.Text);
                falta12 = Convert.ToInt32(txtfalta12.Text);
                falta13 = Convert.ToInt32(txtfalta13.Text);
                falta14 = Convert.ToInt32(txtfalta14.Text);
                falta15 = Convert.ToInt32(txtfalta15.Text);
                falta16 = Convert.ToInt32(txtfalta16.Text);
                falta17 = Convert.ToInt32(txtfalta17.Text);
                falta18 = Convert.ToInt32(txtfalta18.Text);
                falta19 = Convert.ToInt32(txtfalta19.Text);
                falta20 = Convert.ToInt32(txtfalta20.Text);
                falta21 = Convert.ToInt32(txtfalta21.Text);
                falta22 = Convert.ToInt32(txtfalta22.Text);
                falta23 = Convert.ToInt32(txtfalta23.Text);
                falta24 = Convert.ToInt32(txtfalta24.Text);
                falta25 = Convert.ToInt32(txtfalta25.Text);
                falta26 = Convert.ToInt32(txtfalta26.Text);
                falta27 = Convert.ToInt32(txtfalta27.Text);
                falta28 = Convert.ToInt32(txtfalta28.Text);


                resultadosNotas[0] = notas[0] + notas[1] + notas[2] + notas[3];
                resultadosNotas[1] = notas[4] + notas[5] + notas[6] + notas[7];
                resultadosNotas[2] = notas[8] + notas[9] + notas[10] + notas[11];
                resultadosNotas[3] = notas[12] + notas[13] + notas[14] + notas[15];
                resultadosNotas[4] = notas[16] + notas[17] + notas[18] + notas[19];
                resultadosNotas[5] = notas[20] + notas[21] + notas[22] + notas[23];
                resultadosNotas[6] = notas[24] + notas[25] + notas[26] + notas[27];

                lblresultado.Text = Convert.ToString(resultadosNotas[0]);
                lblresultado4.Text = Convert.ToString(resultadosNotas[1]);
                lblresultado5.Text = Convert.ToString(resultadosNotas[2]);
                lblresultado6.Text = Convert.ToString(resultadosNotas[3]);
                lblresultado7.Text = Convert.ToString(resultadosNotas[4]);
                lblresultado8.Text = Convert.ToString(resultadosNotas[5]);
                lblresultado9.Text = Convert.ToString(resultadosNotas[6]);

                resultado3 = falta1 + falta2 + falta3 + falta4;
                resultado10 = falta5 + falta6 + falta7 + falta8;
                resultado11 = falta9 + falta10 + falta11 + falta12;
                resultado12 = falta13 + falta14 + falta15 + falta16;
                resultado13 = falta17 + falta18 + falta19 + falta20;
                resultado14 = falta21 + falta22 + falta23 + falta24;
                resultado15 = falta25 + falta26 + falta27 + falta28;

                lblresultado3.Text = Convert.ToString(resultado3);
                lblresultado10.Text = Convert.ToString(resultado10);
                lblresultado11.Text = Convert.ToString(resultado11);
                lblresultado12.Text = Convert.ToString(resultado12);
                lblresultado13.Text = Convert.ToString(resultado13);
                lblresultado14.Text = Convert.ToString(resultado14);
                lblresultado15.Text = Convert.ToString(resultado15);

                if (((resultadosNotas[0] <= 22.0) || (resultadosNotas[0] <= 23.0) && (resultado3 > 15)))
                {
                    resultado2= "Reprovado";
                    lblresultado2.ForeColor = Color.Red;
                }
               
                else
                if  ((resultadosNotas[0] <= 23.0) || (resultadosNotas[0] <= 24.0) && (resultado3 > 15) || (resultado3 > 25))
                {
                    resultado2 = "Recuperação final";
                    lblresultado2.ForeColor = Color.Green;
                }
   
                 else
                {
                    resultado2 = "Aprovado";
                    lblresultado2.ForeColor = Color.Blue;
                }
                lblresultado2.Text = resultado2;
                

                if ((resultadosNotas[1] <= 22.0) || (resultadosNotas[1] <= 23.0) && (resultado10 > 15))
                {
                    resultado16 = "Reprovado";
                    lblresultado16.ForeColor = Color.Red;
                }
                
                else
               if ((resultadosNotas[1] <= 23.0) || (resultadosNotas[1] <= 24.0) && (resultado10 > 15) || (resultado10 > 25))
                {
                    resultado16 = "Recuperação final";
                    lblresultado16.ForeColor = Color.Green;
                }
                
                else
                {
                    resultado16 = "Aprovado";
                    lblresultado16.ForeColor = Color.Blue;
                }
                lblresultado16.Text = resultado16;


                if ((resultadosNotas[2] <= 22.0) || (resultadosNotas[2] <= 23.0) && (resultado11 > 15))
                {
                    resultado17 = "Reprovado";
                    lblresultado17.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[2] <= 23.0) || (resultadosNotas[2] <= 24.0) && (resultado11 > 15) || (resultado11 > 25))
                {
                    resultado17 = "Recuperação final";
                    lblresultado17.ForeColor = Color.Green;
                }
               
                else
                {
                    resultado17 = "Aprovado";
                    lblresultado17.ForeColor = Color.Blue;
                }
                lblresultado17.Text = resultado17;


                if ((resultadosNotas[3] <= 22.0) || (resultadosNotas[3] <= 23.0) && (resultado12 > 15))
                {
                    resultado18 = "Reprovado";
                    lblresultado18.ForeColor = Color.Red;
                }
              
                else
               if ((resultadosNotas[3] <= 23.0) || (resultadosNotas[3] <= 24.0) && (resultado12 > 15) || (resultado12 > 25))
                {
                    resultado18 = "Recuperação final";
                    lblresultado18.ForeColor = Color.Green;
                }
                
                else
                {
                    resultado18 = "Aprovado";
                    lblresultado18.ForeColor = Color.Blue;
                }
                lblresultado18.Text = resultado18;


                if ((resultadosNotas[4] <= 22.0) || (resultadosNotas[4] <= 23.0) && (resultado13 > 15))
                {
                    resultado19 = "Reprovado";
                    lblresultado19.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[4] <= 23.0) || (resultadosNotas[4] <= 24.0) && (resultado13 > 15) || (resultado13 > 25))
                {
                    resultado19 = "Recuperação final";
                    lblresultado19.ForeColor = Color.Green;
                }
               
                else
                {
                    resultado19 = "Aprovado";
                    lblresultado19.ForeColor = Color.Blue;
                }
                lblresultado19.Text = resultado19;


                if ((resultadosNotas[5] <= 22.0) || (resultadosNotas[5] <= 23.0) && (resultado14 > 15))
                {
                    resultado20 = "Reprovado";
                    lblresultado20.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[5] <= 23.0) || (resultadosNotas[5] <= 24.0) && (resultado14 > 15) || (resultado14 > 25))
                {
                    resultado20 = "Recuperação final";
                    lblresultado20.ForeColor = Color.Green;
                }
                
                else
                {
                    resultado20 = "Aprovado";
                    lblresultado20.ForeColor = Color.Blue;
                }
                lblresultado20.Text = resultado20;


                if ((resultadosNotas[6] <= 22.0) || (resultadosNotas[6] <= 23.0) && (resultado15 > 15))
                {
                    resultado21 = "Reprovado";
                    lblresultado21.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[6] <= 23.0) || (resultadosNotas[6] <= 24.0) && (resultado15 > 15) || (resultado15 > 25))
                {
                    resultado21 = "Recuperação final";
                    lblresultado21.ForeColor = Color.Green;
                }
             
                else
                {
                    resultado21 = "Aprovado";
                    lblresultado21.ForeColor = Color.Blue;
                }
                lblresultado21.Text = resultado21;
            }
            //vai apresentra erro se digitar letra no campo
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Bloco catch");
            }

            //vai apresentar erro de número muito grande
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Segundo bloco catch");
            }

            //erro desconhecido
            catch (Exception ex)
            {
                MessageBox.Show("erro Desconhecido", "Segundo bloco catch");
            }
             
            //código opicional 
            finally
            {
                MessageBox.Show("Este bloco sempre será executado, independente de erros", "Bloco finally");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtnota4.Clear();
            txtnota5.Clear();
            txtnota6.Clear();
            txtnota7.Clear();
            txtnota8.Clear();
            txtnota9.Clear();
            txtnota10.Clear();
            txtnota11.Clear();
            txtnota12.Clear();
            txtnota13.Clear();
            txtnota14.Clear();
            txtnota15.Clear();
            txtnota16.Clear();
            txtnota17.Clear();
            txtnota18.Clear();
            txtnota19.Clear();
            txtnota20.Clear();
            txtnota21.Clear();
            txtnota22.Clear();
            txtnota23.Clear();
            txtnota24.Clear();
            txtnota25.Clear();
            txtnota26.Clear();
            txtnota27.Clear();
            txtnota28.Clear();

            txtfalta1.Clear();
            txtfalta2.Clear();
            txtfalta3.Clear();
            txtfalta4.Clear();
            txtfalta5.Clear();
            txtfalta6.Clear();
            txtfalta7.Clear();
            txtfalta8.Clear();
            txtfalta9.Clear();
            txtfalta10.Clear();
            txtfalta11.Clear();
            txtfalta12.Clear();
            txtfalta13.Clear();
            txtfalta14.Clear();
            txtfalta15.Clear();
            txtfalta16.Clear();
            txtfalta17.Clear();
            txtfalta18.Clear();
            txtfalta19.Clear();
            txtfalta20.Clear();
            txtfalta21.Clear();
            txtfalta22.Clear();
            txtfalta23.Clear();
            txtfalta24.Clear();
            txtfalta25.Clear();
            txtfalta26.Clear();
            txtfalta27.Clear();
            txtfalta28.Clear();

            lblresultado3.Clear();
            lblresultado10.Clear();
            lblresultado11.Clear();
            lblresultado12.Clear();
            lblresultado13.Clear();
            lblresultado14.Clear();
            lblresultado15.Clear();

            lblresultado2.Text="Resultado";    lblresultado2.ForeColor = Color.Black;
            lblresultado16.Text = "Resultado"; lblresultado16.ForeColor = Color.Black;
            lblresultado17.Text = "Resultado"; lblresultado17.ForeColor = Color.Black;
            lblresultado18.Text = "Resultado"; lblresultado18.ForeColor = Color.Black;
            lblresultado19.Text = "Resultado"; lblresultado19.ForeColor = Color.Black;
            lblresultado20.Text = "Resultado"; lblresultado20.ForeColor = Color.Black;
            lblresultado21.Text = "Resultado"; lblresultado21.ForeColor = Color.Black;

            lblresultado.Clear();
            lblresultado4.Clear();
            lblresultado5.Clear();
            lblresultado6.Clear();
            lblresultado7.Clear();
            lblresultado8.Clear();
            lblresultado9.Clear();
            
        }

       

      
    }
}
