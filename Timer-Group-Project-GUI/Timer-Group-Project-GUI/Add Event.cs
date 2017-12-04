using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Group_Project_GUI
{
	public partial class Add_Event : Form
	{
		public Add_Event()
		{
			InitializeComponent();
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

        private void eventNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
