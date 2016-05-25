using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c=1;
        double a, b,l;
        bool s = true;
        private void button16_Click(object sender, EventArgs e)
        {
            if(s==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                s = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                s = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (s == true) { textBox1.Text = textBox1.Text + ","; s = false; }
                else { textBox1.Text = textBox1.Text.Replace(",", ""); s = true; }
            }
            catch { textBox1.Text = ""; }
         
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch(c)
            {
                case 1:
                    try
                    {
                        b = a + double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                    catch { textBox1.Text = ""; break; }
                case 2:
                    try
                    {
                        b = a - double.Parse(textBox1.Text);
                        textBox1.Text = b.ToString();
                        break;
                    }
                    catch { textBox1.Text = ""; break; }
                case 3: try
                    {
                    b = a * double.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;}
                      catch { textBox1.Text = ""; break; }
                  
                case 4:
                    try
                    {
                        if (b == 0)
                        {
                            textBox1.Text = "Eroare";
                        }
                        else
                        {
                            b = a / double.Parse(textBox1.Text);
                            textBox1.Text = b.ToString();
                        }
                        break;
                    }
                    catch { textBox1.Text = ""; break; }
                case 5:
                    try
                    {
                        if (a == 0) { textBox1.Text = "Eroare"; }
                        else
                        {
                            b = 1 / a;
                            textBox1.Text = b.ToString();
                        }
                        break;
                    }
                    catch { textBox1.Text = ""; break; }
                case 6: b = Math.Pow(a , 2 );
                    textBox1.Text = b.ToString();
                    break;
                case 7:
                    if(a<0)
                    { textBox1.Text = "Eroare"; }
                    else{  b = Math.Sqrt(a);
                        textBox1.Text = b.ToString();
                    }
                    
                    break;
                case 8:
                    b = Math.Exp(a);
                    textBox1.Text = b.ToString();
                    break;
                case 9:
                    b = Math.Log(a);
                    textBox1.Text = b.ToString();
                    break;
                case 10:
                    b = Math.Log10(a);
                    textBox1.Text = b.ToString();
                    break;
                case 11:
                    b = Math.Cos(a);
                    textBox1.Text = b.ToString();
                    break;
                case 15:
                    b = Math.Sin(a);
                    textBox1.Text = b.ToString();
                    break;
                case 16:
                    b = Math.Tan(a);
                    textBox1.Text = b.ToString();
                    break;

                default: 
                           break;
            }
            label1.Text = "";
           
        }
        
        
        private void button12_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = textBox1.Text + "1";
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
          
            textBox1.Text = textBox1.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            try
            {
                c = 1;
                a = double.Parse(textBox1.Text);
               
                label1.Text = a.ToString() + "+";
               textBox1.Clear();

               
        
            }
                
            catch
            {
               
                textBox1.Text ="";
            }
           
          
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
               textBox1.Clear();
                c = 2;
               label1.Text = a.ToString() + "-";
            }
            catch { textBox1.Text = ""; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
               textBox1.Clear();
                c = 3;
                label1.Text = a.ToString() + "x";
            }
            catch { textBox1.Text = ""; }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
               textBox1.Clear();
                c = 4;
                label1.Text = a.ToString() + "÷";
            }
            catch
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           textBox1.Clear();
            label1.Text = "" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length -1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i=0; i<lenght;i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "1/" + textBox1.Text;
                c = 5;
                label1.Text = "1/"+a.ToString();
            }
            catch { textBox1.Text = ""; }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = textBox1.Text + "^2";
                c = 6;
                label1.Text = a.ToString() + "^2";
            }
            catch { textBox1.Text = ""; }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
             
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = "√" + textBox1.Text;
                    c = 7;
                    label1.Text = "√" + a.ToString();
                
                
               
            }
            catch { textBox1.Text = ""; }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "e^" + textBox1.Text;
                c = 8;
                label1.Text = "e^"+ a.ToString() ;
            }
            catch { textBox1.Text = ""; }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "log " + textBox1.Text;
                c = 9;
                label1.Text ="log "+ a.ToString() ;
            }
            catch { textBox1.Text = ""; }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "log10 " + textBox1.Text;
                c = 10;
                label1.Text ="log10"+"("+ a.ToString()+")" ;
            }
            catch { textBox1.Text = ""; }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "Cos " + textBox1.Text;
                c = 11;
                label1.Text ="Cos "+ a.ToString() ;
            }
            catch { textBox1.Text = ""; }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text);
                textBox1.Text = "Sin " + textBox1.Text;
                c = 15;
                label1.Text ="Sin "+ a.ToString() ;
            }
            catch { textBox1.Text = ""; }
        }
        

        private void button25_Click(object sender, EventArgs e)
        {
            
            
            try
            {   
               
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Text = "tg " + textBox1.Text;
                    c = 16;
                    label1.Text ="tg "+ a.ToString() ;
                }
            
               
            }
             catch { textBox1.Text = ""; }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 44 && textBox1.Text.Contains(',')) e.Handled = true;
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 44)
                e.Handled = true;

            if (e.KeyChar == 47) button3_Click(sender, e);
            if (e.KeyChar == 43) button15_Click(sender, e);
            if (e.KeyChar == 45) button11_Click(sender, e);
            if (e.KeyChar == 42) button7_Click(sender, e);
            if (e.KeyChar == 13) button19_Click(sender, e);
            if (e.KeyChar == 8) button2_Click(sender, e);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
}
