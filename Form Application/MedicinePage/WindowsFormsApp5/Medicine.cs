using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

       private bool enterPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        //enter button pressed
        private void button1_Click(object sender, EventArgs textBox1_TextChanged)
        {
            enterPressed = true;
            this.textBox1_TextChanged(button1, textBox1_TextChanged);
            textBox1.Text = "";
            enterPressed = false;
        }
       
        //user types in medication
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (enterPressed&& textBox1.Text.Length!=0)
            {
                Med temp = new Med(textBox1.Text);
               
            }
            return;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int num = listBox1.SelectedIndex;
        }
    }
}
