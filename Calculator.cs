using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        decimal  temp = 0;
        char app=' ';
        decimal result = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'1');
            }
            else
                textBox1.Text = textBox1.Text + ((char)'1');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'2');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'2');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'0');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'0');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'3');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'3');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'4');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'4');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'5');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'6');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'6');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'7');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'7');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'8');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'8');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "NaN")
            {
                textBox1.Clear();
                textBox1.Text = textBox1.Text + ((char)'9');
            }
            else
            textBox1.Text = textBox1.Text + ((char)'9');
        }

        private void button11_Click(object sender, EventArgs e)
        {
                        //sayida virgul yoksa
            if (textBox1.Text.IndexOf(",") <= 0)
            {
                if (textBox1.Text.Length == 0)
                    //hiç karakter yoksa 0, ekle
                    textBox1.Text = "0,";
                else
                    //sayi varsa sonuna virgul ekle
                    textBox1.Text = textBox1.Text + ",";
            }
        

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                 if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = '+';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = '+';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = '+';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = '+';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = '+';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = '+';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = '+';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = '+';
                }
            }
            else
            {
                app = '+';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = '-';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = '-';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = '-';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = '-';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = '-';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = '-';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = '-';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = '-';
                }
            }
            else
            {
                app = '-';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = '*';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = '*';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = '*';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = '*';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = '*';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = '*';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = '*';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = '*';
                }
            }
            else
            {
                app = '*';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
               if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = '/';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = '/';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = '/';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = '/';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = '/';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = '/';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = '/';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = '/';
                }
            }
            else
            {
                app = '/';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = ' ' ;
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = ' ';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = ' ';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = ' ';
                }
            }
            else
            {
                app = ' ';
            }
            textBox1.Text = Math.Sqrt((double)temp).ToString();
            textBox1.Focus();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    if (app == '+')
                    {
                        textBox1.Text = (temp + decimal.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == '-')
                    {
                        textBox1.Text = (temp - decimal.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == '*')
                    {
                        textBox1.Text = (temp * decimal.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == '/')
                    {
                        textBox1.Text = (temp / decimal.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == '%')
                    {
                        textBox1.Text = (temp % decimal.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == 'x')
                    {
                        textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else if (app == 'y')
                    {
                        textBox1.Text = Math.Pow((double)temp,double.Parse(textBox1.Text)).ToString();
                        app = ' ';
                    }
                    else
                    {
                        textBox1.Text = temp.ToString();
                        app = ' ';
                    }
                }
                else
                {
                    textBox1.Text = temp.ToString();
                    app = ' ';
                }
            }

            catch
            { }
   
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = '%';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = '%';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = '%';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = '%';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = '%';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = '%';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = '%';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = '%';
                }
            }
            else
            {
                app = '%';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = 'x';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = 'x';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = 'x';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = 'x';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = 'x';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app='x';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app='x';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = 'x';
                }
            }
            else
            {
                app = 'x';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = ' ';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = ' ';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = ' ';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = ' ';
                }
            }
            else
            {
                app = ' ';
            }
           
            if (temp == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = 1; i <= temp; i++)
                {
                    result = result * i;
                }
            }
            textBox1.Text = result.ToString();
            textBox1.Focus();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            temp = 0;
            app=' ';
            textBox1.Focus();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Substring(0, 1) == "-")
                    //Sayinin basinda - varsa sil
                    textBox1.Text = textBox1.Text.Substring(1);
                else
                    //- yoksa - ekle
                    textBox1.Text = "-" + textBox1.Text.Substring(0);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
               if (app == '+')
                {
                    temp = temp + decimal.Parse(textBox1.Text);
                    app = 'y';
                }
                else if (app == '-')
                {
                    temp = temp - decimal.Parse(textBox1.Text);
                    app = 'y';
                }
                else if (app == '*')
                {
                    temp = temp * decimal.Parse(textBox1.Text);
                    app = 'y';
                }
                else if (app == '/')
                {
                    temp = temp / decimal.Parse(textBox1.Text);
                    app = 'y';
                }
                else if (app == '%')
                {
                    temp = temp % decimal.Parse(textBox1.Text);
                    app = 'y';
                }
                else if (app == 'x')
                {
                    textBox1.Text = Math.Pow((double)temp, 1 / double.Parse(textBox1.Text)).ToString();
                    app = 'y';
                }
                else if (app == 'y')
                {
                    textBox1.Text = Math.Pow((double)temp, double.Parse(textBox1.Text)).ToString();
                    app = 'y';
                }
                else
                {
                    temp = decimal.Parse(textBox1.Text);
                    app = 'y';
                }
            }
            else
            {
                app = 'y';
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
