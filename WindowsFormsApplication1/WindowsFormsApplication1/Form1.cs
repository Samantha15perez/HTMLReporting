using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DLLTEST.Class1 C1 = new DLLTEST.Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            textBox4.Text = C1.htmlheader(textBox1.Text, 6) + "<body>" + C1.htmlparagraph(textBox2.Text) + "</body>" + C1.htmlimagelink(textBox3.Text);
        }
    }
}
