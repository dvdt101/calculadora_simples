using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class calculadora : Form
    {

        private String x , y; //variavies para receber o valor e ser calculado.
        
        private double resultado ; //variavel para guardar resultado.

        private double xc, yc; //variaveis para receber x e y em double.
        
        private int tipo; /*variavel indica o tipo de operação que irá ser executada 
                          1- divisão, 2-substração, 3-soma, 4-multiplicação */

        private double uResult ; //guarda o resultado da ultima operação.

        public calculadora()
        {
            InitializeComponent();
            result.Text = "0";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //botão numero 8
        private void button12_Click(object sender, EventArgs e)
        {
            
            if (uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else{ y = y + 8;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 8;
                result.Text = x;
            }
            else 
            {
                y = y + 8;
                result.Text = y;
            }
            
        }
        //botão numero 1
        private void button1_Click(object sender, EventArgs e)
        {
            if(uResult != 0)
            {
                if (tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
                else
                {
                    y = y + 1;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 1;
                result.Text = x;
            }
            else 
            {
                y = y + 1;
                result.Text = y;
            }


        }
        //botão numero 3
        private void button8_Click(object sender, EventArgs e)
        {
            if(uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else{
                    y = y + 3;
                    result.Text = y;
                }
            }

           else if (x == null || tipo == 0)
            {
                x = x + 3;
                result.Text = x;
            }
            else 
            {
                y = y + 3;
                result.Text = y;
            }
        }
        //botão numero 2
        private void button2_Click(object sender, EventArgs e)
        {if(uResult != 0)
            {
                if (tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
                else
                {
                    y = y + 2;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 2;
                result.Text = x;
            }
            else 
            {
                y = y + 2;
                result.Text = y;
            }
        }
        //botão numero 4
        private void button10_Click(object sender, EventArgs e)
        {if(uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else{
                    y = y + 4;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 4;
                result.Text = x;
            }
            else 
            {
                y = y + 4;
                result.Text = y;
            }
        }
        //botão numero 5
        private void button9_Click(object sender, EventArgs e)
        {   if(uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
               else{
                    y = y + 5;
                    result.Text = y;
                }
            }
            
            else if (x == null || tipo == 0)
            {
                x = x + 5;
                result.Text = x;
            }
            else 
            {
                y = y + 5;
                result.Text = y;
            }
        }
        //botão numero 6
        private void button5_Click(object sender, EventArgs e)
        {   if(uResult != 0)
            {
                if (tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
               else{ y = y + 6;
                    result.Text = y;
                }
            }

          else  if (x == null || tipo == 0)
            {
                x = x + 6;
                result.Text = x;
            }
            else 
            {
                y = y + 6;
                result.Text = y;
            }
        }
        //botão numero 7
        private void button11_Click(object sender, EventArgs e)
        {   if(uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else{ y = y + 7;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 7;
                result.Text = x;
            }
            else 
            {
                y = y + 7;
                result.Text = y;
            }
        }
        //botão numero 9
        private void button13_Click(object sender, EventArgs e)
        {   if(uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else{ y = y + 9;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 9;
                result.Text = x;
            }
            else 
            {
                y = y + 9;
                result.Text = y;
            }
        }
        //Botão divisão
        private void button3_Click(object sender, EventArgs e)
        {
            tipo = 1;
            result.Text = "0";
            if (uResult == 0)
            {
                lastResult.Text = x + "/";
            }
            else
                lastResult.Text = uResult.ToString() + "/";
        }
        // Botão subtração
        private void button6_Click(object sender, EventArgs e)
        {
            tipo = 2;
            result.Text = "0";
            if (uResult == 0)
            {
                lastResult.Text = x + "-";
            }
            else
                lastResult.Text = uResult.ToString() + "-";
        }
        // Botão soma
        private void button7_Click(object sender, EventArgs e)
        {
            tipo = 3; 
            result.Text = "0";
            if (uResult == 0)
            {
                lastResult.Text = x + "+";
            }
            else
                lastResult.Text = uResult.ToString() + "+";
        }
        //botão numero 0
        private void button15_Click(object sender, EventArgs e)
        {
            if (uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
                else { y = y + 0;
                    result.Text = y;
                }
            }

            else if (x == null || tipo == 0)
            {
                x = x + 0;
                result.Text = x;
            }
            else
            {
                y = y + 0;
                result.Text = y;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //botão C
        private void button17_Click(object sender, EventArgs e)
        {
            resultado = xc = yc = uResult = tipo = 0;
            x =y= null;
            result.Text = "0";
            lastResult.Clear();
        }

        // Botão apagar
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (y != null)
                {
                    y = y.Remove(y.Length - 1);
                    result.Text = y;
                }
                else if (x != null || tipo == 0)
                {
                    x = x.Remove(x.Length - 1);
                    result.Text = x;
                }
            }
            catch { }
        }
        //Botão vírgula
        private void button18_Click(object sender, EventArgs e)
        {
            if (uResult != 0)
            {
                if(tipo == 0)
                {
                    resultado = xc = yc = uResult = tipo = 0;
                    x = y = null;
                    result.Text = "0";
                    lastResult.Clear();
                }
              else {
                    result.Text = y + ",";
                    y = y + ",";
                }
            }

            else if (x == null || tipo == 0)
            {
                result.Text = x + ",";
                x = x + ",";
               
            }
            else
            {
                result.Text = y + ",";
                y = y + ",";
                
            }
        }

        private void lastResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por David Tavares ");
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Botão multiplicação
        private void button4_Click(object sender, EventArgs e)
        {
            tipo = 4;
            result.Text = "0";
            if (uResult == 0)
            {
                lastResult.Text = x + "*";
            }
            else
                lastResult.Text = uResult.ToString() + "*";
        }
        //Botão Calcular
        private void button14_Click(object sender, EventArgs e)
        {
           
            xc = Convert.ToDouble(x);
            yc = Convert.ToDouble(y);
            
            switch (tipo)
            {
                case 1:
                    if(xc == 0)
                    {
                        resultado = (uResult / yc);
                        lastResult.Text = (uResult + "/" + y);
                    }
                    else
                    {
                        resultado = (xc / yc);
                        lastResult.Text = (x + "/" + y);
                    }

                    break;

                case 2:

                    if(xc == 0)
                    {
                        resultado = (uResult - yc);
                        lastResult.Text = (uResult + "-" + y);
                    }
                    else
                    {
                        resultado = (xc - yc);
                        lastResult.Text = (x + "-" + y);
                    }

                    break;

                case 3:

                    if (xc == 0)
                    {
                        resultado = (uResult + yc);
                        lastResult.Text = (uResult + "+" + y);
                    }
                    else
                    {
                        resultado = (xc + yc);
                        lastResult.Text = (x + "+" + y);
                    }

                    break;

                case 4:
                    if (xc == 0)
                    {
                        resultado = (uResult * yc);
                        lastResult.Text = (uResult + "*" + y);
                    }
                    else
                    {
                        resultado = (xc * yc);
                        lastResult.Text = (x + "*" + y);
                    }
                    break;
                  
            }
            uResult = resultado;
            result.Text = resultado.ToString();
           
            x = null;
            y = null;
            tipo = 0;
           
            
        }
    }
}
