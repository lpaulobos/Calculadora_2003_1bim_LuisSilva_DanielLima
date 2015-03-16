using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Calculadora : Form
    {
        public float indice;
        public float resultado = 0;
        public double raiz1;
        public double raiz3;
        public double raiz2;
        public List<float> list = new List<float>();
        public string operation;
        public double d;
        public double num;  

        public Calculadora()
        {
            InitializeComponent();
        }

        private void digitou(object sender, EventArgs e)
        {
            Button digito = sender as Button;
            visor.Text += digito.Text;
        }

        private void fclear_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                visor.Text = visor.Text.Remove(visor.Text.Length - 1);
            }
        }

        private void fclearall_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                visor.Text = null;
                visor2.Text = null;
                indice = 0;
                resultado = 0;
                list.Clear();
            }
        }

        private void fsom_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = visor.Text + " + ";
                visor.Text = null;
                operation = "soma";
            }
        }

        private void fsub_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = visor.Text + " - ";
                visor.Text = null;
                operation = "sub";
            } 
        }

        private void fmult_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = visor.Text + " * ";
                visor.Text = null;
                operation = "mult";
            }
        }

        private void fdiv_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = visor.Text + " / ";
                visor.Text = null;
                operation = "div";
            }
        }

        private void fpot_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(int.Parse(visor.Text));
                visor2.Text = visor.Text + " Elevado ";
                visor.Text = null;
                operation = "pot";
            }
        }

        private void fraiz_Click(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                raiz1 = Convert.ToDouble(visor.Text);
                visor2.Text =  "√ " + visor.Text;
                visor.Text = null;
                operation = "raiz";
            }

        }

        private void fsin_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                list[list.Count - 1] *= -1;
                visor2.Text = list[list.Count - 1].ToString();
            }
        }

        private void fsen(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = "Seno " + visor.Text + "º";
                visor.Text = null;
                operation = "seno";
            }
        }

        private void fcos(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = "Seno " + visor.Text + "º";
                visor.Text = null;
                operation = "seno";
            }
        }

        private void ftg(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = "Tangente " + visor.Text + "º";
                visor.Text = null;
                operation = "tangente";
            }
        }

        private void fresto(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = " Resto " + visor.Text ;
                visor.Text = null;
                operation = "rest";
            }
        }

        private void fporc(object sender, EventArgs e)
        {
            if (visor.Text != "")
            {
                list.Add(float.Parse(visor.Text));
                visor2.Text = visor.Text + " '\' ";
                visor.Text = null;
                operation = "porc";
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "soma":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = list[0].ToString() + " + " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = list[0] + list[i];
                    }
                    visor.Text = resultado.ToString();
                    break;
                case "sub":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = list[0].ToString() + " - " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = list[0] - list[i];
                    }
                    visor.Text = resultado.ToString();
                    break;
               
                case "mult":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = list[0].ToString() + " * " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = list[0] * list[i];
                    }
                    visor.Text = resultado.ToString();
                    break;

                case "div":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = list[0].ToString() + " / " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = list[0] / list[i];
                    }
                    visor.Text = resultado.ToString();
                    break;
               
                case "rest":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = "Resto " + list[0].ToString() + " / " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = list[0] % list[i];
                    }
                    visor.Text = resultado.ToString();
                    break;

                case "porc":
                    list.Add(float.Parse(visor.Text));
                    visor2.Text = list[0].ToString() + " % " + list[1].ToString() + " =";
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado = (list[0] * list[i]) / 100;
                    }
                    visor.Text = resultado.ToString();
                    break;

                case "pot":
                    indice = float.Parse(visor.Text);
                    visor2.Text = list[0].ToString() + " Elevado " + indice.ToString() + " =";
                    for (int i = 0; i < indice; i++)
                    {
                        list.Add(list[0]);
                        if (i > 0)
                        {
                            resultado = list[0] * list[i];
                            list.Insert(0, resultado);
                            visor.Text = resultado.ToString();
                        }
                    }
                        break;
                case "raiz":
                    raiz2 = Convert.ToDouble(visor.Text);
                    visor2.Text = raiz2.ToString() + " √ " + raiz1.ToString() + " =";
                    raiz3 = Math.Pow(raiz1, (1 / raiz2));
                    visor.Text = raiz3.ToString();;
                    break;
                case "seno":
                    list[0] = (float)(list[0] * (Math.PI / 180));
                    resultado = (float)Math.Sin(list[0]);
                    visor.Text = resultado.ToString();
                    break;
                case "cosseno":
                    list[0] = (float)(list[0] * (Math.PI / 180));
                    resultado = (float)Math.Cos(list[0]);
                    visor.Text = resultado.ToString();
                    break;
                case "tangente":
                    list[0] = (float)(list[0] * (Math.PI / 180));
                    resultado = (float)Math.Tan(list[0]);
                    visor.Text = resultado.ToString();
                    break;
            }
        }

        private void fclearlast_Click(object sender, EventArgs e)
        {
            if(visor2.Text != "")
			{
				visor2.Text = null;
				list.Remove(list.Count-1);
			}
			else{
				visor.Text = null;
				list.Remove(list.Count-1);				
			}
        }

    }
}