using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            text= textBox1.Text;
            label2.Text = text.ToString();

            if (label1.Text == label2.Text)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You entered an incorrect value. Try again", "Error");
                Random rnd = new Random();
                s1 = rnd.Next(0, harfler.Length);
                s2 = rnd.Next(0, semboller.Length);
                s3 = rnd.Next(0, bharfler.Length);
                s4 = rnd.Next(0, 10);
                s5 = rnd.Next(0, 10);

                label1.Text = s4.ToString() + harfler[s1].ToString() + semboller[s2].ToString() + s5.ToString() + bharfler[s3].ToString();

                textBox1.Text = "" ;
            }
        }
        string[] harfler = { "a", "b", "c", "d", "e", "f", "g", "h", "ı" };
        string[] semboller = { "!", "^#", "+", "%", "&", "/", "=", "*", "-" };
        string[] bharfler = { "A", "B", "C", "D", "E", "F", "G", "H", "I" };

        int s1, s2, s3, s4, s5;



        private void Form1_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            s1 = rnd.Next(0, harfler.Length);
            s2 = rnd.Next(0, semboller.Length);
            s3 = rnd.Next(0, bharfler.Length);
            s4 = rnd.Next(0, 10);
            s5 = rnd.Next(0, 10);

            label1.Text = s4.ToString() + harfler[s1].ToString() + semboller[s2].ToString() + s5.ToString() + bharfler[s3].ToString();
        }
    }
}
