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
                double[] notas = new double[28];
                int[] faltas = new int[28];
                double[] resultadosNotas = new double[7];
                int[] resultadosFaltas = new int[7];
                string[] resultadoEscrito = new string[7];

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

                faltas[0] = Convert.ToInt32(txtfalta1.Text);
                faltas[1] = Convert.ToInt32(txtfalta2.Text);
                faltas[2] = Convert.ToInt32(txtfalta3.Text);
                faltas[3] = Convert.ToInt32(txtfalta4.Text);
                faltas[4] = Convert.ToInt32(txtfalta5.Text);
                faltas[5] = Convert.ToInt32(txtfalta6.Text);
                faltas[6] = Convert.ToInt32(txtfalta7.Text);
                faltas[7] = Convert.ToInt32(txtfalta8.Text);
                faltas[8] = Convert.ToInt32(txtfalta9.Text);
                faltas[9] = Convert.ToInt32(txtfalta10.Text);
                faltas[10] = Convert.ToInt32(txtfalta11.Text);
                faltas[11] = Convert.ToInt32(txtfalta12.Text);
                faltas[12] = Convert.ToInt32(txtfalta13.Text);
                faltas[13] = Convert.ToInt32(txtfalta14.Text);
                faltas[14] = Convert.ToInt32(txtfalta15.Text);
                faltas[15] = Convert.ToInt32(txtfalta16.Text);
                faltas[16] = Convert.ToInt32(txtfalta17.Text);
                faltas[17] = Convert.ToInt32(txtfalta18.Text);
                faltas[18] = Convert.ToInt32(txtfalta19.Text);
                faltas[19] = Convert.ToInt32(txtfalta20.Text);
                faltas[20] = Convert.ToInt32(txtfalta21.Text);
                faltas[21] = Convert.ToInt32(txtfalta22.Text);
                faltas[22] = Convert.ToInt32(txtfalta23.Text);
                faltas[23] = Convert.ToInt32(txtfalta24.Text);
                faltas[24] = Convert.ToInt32(txtfalta25.Text);
                faltas[25] = Convert.ToInt32(txtfalta26.Text);
                faltas[26] = Convert.ToInt32(txtfalta27.Text);
                faltas[27] = Convert.ToInt32(txtfalta28.Text);


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

                resultadosFaltas[0] = faltas[0] + faltas[1] + faltas[2] + faltas[3];
                resultadosFaltas[1] = faltas[4] + faltas[5] + faltas[6] + faltas[7];
                resultadosFaltas[2] = faltas[8] + faltas[9] + faltas[10] + faltas[11];
                resultadosFaltas[3] = faltas[12] + faltas[13] + faltas[14] + faltas[15];
                resultadosFaltas[4] = faltas[16] + faltas[17] + faltas[18] + faltas[19];
                resultadosFaltas[5] = faltas[20] + faltas[21] + faltas[22] + faltas[23];
                resultadosFaltas[6] = faltas[24] + faltas[25] + faltas[26] + faltas[27];

                lblresultado3.Text = Convert.ToString(resultadosFaltas[0]);
                lblresultado10.Text = Convert.ToString(resultadosFaltas[1]);
                lblresultado11.Text = Convert.ToString(resultadosFaltas[2]);
                lblresultado12.Text = Convert.ToString(resultadosFaltas[3]);
                lblresultado13.Text = Convert.ToString(resultadosFaltas[4]);
                lblresultado14.Text = Convert.ToString(resultadosFaltas[5]);
                lblresultado15.Text = Convert.ToString(resultadosFaltas[6]);

                if (((resultadosNotas[0] <= 22.0) || (resultadosNotas[0] <= 23.0) && (resultadosFaltas[0] > 15)))
                {
                    resultadoEscrito[0]= "Reprovado";
                    lblresultado2.ForeColor = Color.Red;
                }
               
                else
                if  ((resultadosNotas[0] <= 23.0) || (resultadosNotas[0] <= 24.0) && (resultadosFaltas[0] > 15) || (resultadosFaltas[0] > 25))
                {
                    resultadoEscrito[0] = "Recuperação final";
                    lblresultado2.ForeColor = Color.Green;
                }
   
                 else
                {
                    resultadoEscrito[0] = "Aprovado";
                    lblresultado2.ForeColor = Color.Blue;
                }
                lblresultado2.Text = resultadoEscrito[0];
                

                if ((resultadosNotas[1] <= 22.0) || (resultadosNotas[1] <= 23.0) && (resultadosFaltas[1] > 15))
                {
                    resultadoEscrito[1] = "Reprovado";
                    lblresultado16.ForeColor = Color.Red;
                }
                
                else
               if ((resultadosNotas[1] <= 23.0) || (resultadosNotas[1] <= 24.0) && (resultadosFaltas[1] > 15) || (resultadosFaltas[1] > 25))
                {
                    resultadoEscrito[1] = "Recuperação final";
                    lblresultado16.ForeColor = Color.Green;
                }
                
                else
                {
                    resultadoEscrito[1] = "Aprovado";
                    lblresultado16.ForeColor = Color.Blue;
                }
                lblresultado16.Text = resultadoEscrito[1];


                if ((resultadosNotas[2] <= 22.0) || (resultadosNotas[2] <= 23.0) && (resultadosFaltas[2] > 15))
                {
                    resultadoEscrito[2] = "Reprovado";
                    lblresultado17.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[2] <= 23.0) || (resultadosNotas[2] <= 24.0) && (resultadosFaltas[2] > 15) || (resultadosFaltas[2] > 25))
                {
                    resultadoEscrito[2] = "Recuperação final";
                    lblresultado17.ForeColor = Color.Green;
                }
               
                else
                {
                    resultadoEscrito[2] = "Aprovado";
                    lblresultado17.ForeColor = Color.Blue;
                }
                lblresultado17.Text = resultadoEscrito[2];


                if ((resultadosNotas[3] <= 22.0) || (resultadosNotas[3] <= 23.0) && (resultadosFaltas[3] > 15))
                {
                    resultadoEscrito[3] = "Reprovado";
                    lblresultado18.ForeColor = Color.Red;
                }
              
                else
               if ((resultadosNotas[3] <= 23.0) || (resultadosNotas[3] <= 24.0) && (resultadosFaltas[3]> 15) || (resultadosFaltas[3] > 25))
                {
                    resultadoEscrito[3] = "Recuperação final";
                    lblresultado18.ForeColor = Color.Green;
                }
                
                else
                {
                    resultadoEscrito[3] = "Aprovado";
                    lblresultado18.ForeColor = Color.Blue;
                }
                lblresultado18.Text = resultadoEscrito[2];


                if ((resultadosNotas[4] <= 22.0) || (resultadosNotas[4] <= 23.0) && (resultadosFaltas[4] > 15))
                {
                    resultadoEscrito[4] = "Reprovado";
                    lblresultado19.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[4] <= 23.0) || (resultadosNotas[4] <= 24.0) && (resultadosFaltas[4] > 15) || (resultadosFaltas[4] > 25))
                {
                    resultadoEscrito[4] = "Recuperação final";
                    lblresultado19.ForeColor = Color.Green;
                }
               
                else
                {
                    resultadoEscrito[4] = "Aprovado";
                    lblresultado19.ForeColor = Color.Blue;
                }
                lblresultado19.Text = resultadoEscrito[4];


                if ((resultadosNotas[5] <= 22.0) || (resultadosNotas[5] <= 23.0) && (resultadosFaltas[5] > 15))
                {
                    resultadoEscrito[5] = "Reprovado";
                    lblresultado20.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[5] <= 23.0) || (resultadosNotas[5] <= 24.0) && (resultadosFaltas[5] > 15) || (resultadosFaltas[5] > 25))
                {
                    resultadoEscrito[5] = "Recuperação final";
                    lblresultado20.ForeColor = Color.Green;
                }
                
                else
                {
                    resultadoEscrito[5] = "Aprovado";
                    lblresultado20.ForeColor = Color.Blue;
                }
                lblresultado20.Text = resultadoEscrito[5];


                if ((resultadosNotas[6] <= 22.0) || (resultadosNotas[6] <= 23.0) && (resultadosFaltas[6] > 15))
                {
                    resultadoEscrito[6] = "Reprovado";
                    lblresultado21.ForeColor = Color.Red;
                }
               
                else
               if ((resultadosNotas[6] <= 23.0) || (resultadosNotas[6] <= 24.0) && (resultadosFaltas[6] > 15) || (resultadosFaltas[6] > 25))
                {
                    resultadoEscrito[6] = "Recuperação final";
                    lblresultado21.ForeColor = Color.Green;
                }
             
                else
                {
                    resultadoEscrito[6] = "Aprovado";
                    lblresultado21.ForeColor = Color.Blue;
                }
                lblresultado21.Text = resultadoEscrito[6];
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
  } }
