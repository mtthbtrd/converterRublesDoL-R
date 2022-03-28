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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1 = 0, a2 = 0;
            double rub = 0, dol = 0;
            string writePath = @"C:\Users\user\Desktop\Новая папка (2)\WindowsFormsApp2\text.txt";
            if (textBox1.Text.Length > 0)
            {
                try
                {
                    rub = Double.Parse(textBox1.Text);
                    a1 = 1;
                }
                catch (Exception ex) { }
            }

            else
            {
                try
                {
                    dol = Double.Parse(textBox2.Text);
                    a2 = 1;
                }
                catch (Exception ex) { }
            }

            if (a1 == 1)
            {
                dol = rub / 73;
                textBox2.Text = dol.ToString();
                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Пользователь перевёл " + rub + " rub в " + dol + "$");
                        sw.Close();
                    }

                }
                catch (Exception ex) { }
            }
            else
            {
                rub = dol * 73;
                textBox1.Text = rub.ToString();
                try
                {
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.WriteLine("Пользователь перевёл " + dol + "$ в " + rub + " rub");
                        sw.Close();
                    }

                }
                catch (Exception ex) { }
            }
        }
    }

            
 }

