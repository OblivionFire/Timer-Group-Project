using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Method_Source_Timer_Group_Project;

namespace Timer_Group_Project_GUI
{
	public partial class Main_Screen : Form
	{
		private eventNodeControler events = eventNodeControler.Master();
		public Main_Screen()
		{
			InitializeComponent();backgroundWorker1.RunWorkerAsync();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//This is called when menu path File-> Exit is called
			//It should close the program, I'm not 100% that it will actually work though
			Environment.Exit(1);
		}

		private void addMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Medication addMed = new Add_Medication();
			addMed.ShowDialog();
		}

		private void editMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Edit_Medication editMed = new Edit_Medication();
			editMed.ShowDialog();
		}

		private void removeMedicationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Hide();
			Remove_Medication revMed = new Remove_Medication();
			revMed.ShowDialog();
		}

		private void addMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Add_Event addEvent = new Add_Event();
			addEvent.ShowDialog();
		}

        private void editMedicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit_Event editEvent = new Edit_Event();
            editEvent.ShowDialog();
        }

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			events.manageEvents();
		}
	}
}
