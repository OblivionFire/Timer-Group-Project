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

namespace EventsPage
{
    public partial class Form1 : Form
    {
        private string eventName;
        private ArrayList events = new ArrayList();
       private bool enterPressed = false;

        public Form1()
        {
            InitializeComponent();
            string eventName;

        }

 private void button1_Click(object sender, EventArgs e)
        {
            



        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //activates when enter is pressed
            if (enterPressed)
            {
                Event temp = new Event(textBox1.Text);
                textBox1.Text = "";
               Console.WriteLine( temp.getName());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string eventTime = textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            enterPressed = true;
            //eventargs is a problem
            textBox1_TextChanged(button1, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void eventList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //syntax incorrect. Intended to remove chosen object from events arraylist
            events.Remove(e);
        }
    }
}
