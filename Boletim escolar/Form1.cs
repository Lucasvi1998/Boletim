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

             for (int i = 0; i < 28; i++)
                {
                   string textBoxName = "txtnota" + (i + 1).ToString();
                   notas[i] = Convert.ToDouble(((TextBox)Controls[textBoxName]).Text);
                }

             for (int i = 0; i < 28; i++)
                {
                    string textBoxName1 = "txtfalta" + (i + 1).ToString();
                    faltas[i] = Convert.ToInt32(((TextBox)Controls[textBoxName1]).Text);
                }

               
             for (int i = 0; i < 7; i++)
               {
                  int startIndex = i * 4;
                  resultadosNotas[i] = notas[startIndex] + notas[startIndex + 1] + notas[startIndex + 2] + notas[startIndex + 3];
               }

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
//Este código itera sobre todos os controles dentro do formulário e verifica se o controle é um TextBox e se o nome do controle começa com "txtnota".Se ambas as condições forem atendidas, o método Clear() é chamado para limpar o conteúdo do TextBox.Isso evita a necessidade de manter uma contagem explícita de índices.
            foreach (Control control in Controls)      
            {
                if (control is TextBox && control.Name.StartsWith("txtnota"))
                {
                    ((TextBox)control).Clear();
                }
            }

            foreach(Control control in Controls)
            {
                if(control is TextBox && control.Name.StartsWith("txtfalta"))
                {
                    ((TextBox)control).Clear();
                }
            }

            foreach (Control control in Controls)
            {
                if (control is TextBox && control.Name.StartsWith("lblresultado"))
                {
                    ((TextBox)control).Clear();
                }
            }

            lblresultado2.Text= "Resultado";   lblresultado2.ForeColor = Color.Black;
            lblresultado16.Text = "Resultado"; lblresultado16.ForeColor = Color.Black;
            lblresultado17.Text = "Resultado"; lblresultado17.ForeColor = Color.Black;
            lblresultado18.Text = "Resultado"; lblresultado18.ForeColor = Color.Black;
            lblresultado19.Text = "Resultado"; lblresultado19.ForeColor = Color.Black;
            lblresultado20.Text = "Resultado"; lblresultado20.ForeColor = Color.Black;
            lblresultado21.Text = "Resultado"; lblresultado21.ForeColor = Color.Black;

         
       }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
