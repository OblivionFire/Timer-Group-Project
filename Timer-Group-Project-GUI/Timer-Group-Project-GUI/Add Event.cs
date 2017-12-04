using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Method_Source_Timer_Group_Project;

namespace Timer_Group_Project_GUI
{
	public partial class Add_Event : Form
	{
		private eventNodeControler events = eventNodeControler.Master();
		public Add_Event()
		{
			InitializeComponent();
			eventNode[] eventList = events.getEventArray();

			foreach (eventNode x in eventList)
			{
				currentEvents.AppendText(x.ToString() +"/r/n");
			}

			currentEvents.Enabled = false;
			currentEventsTitle.Enabled = false;
			currentMedsTitle.Enabled = false;
			currentTimers.Enabled = false;
			eventNameLable.Enabled = false;
			eventTimeLable.Enabled = false;
			linkedMedLable.Enabled = false;
			addEventTitle.Enabled = false;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			this.Hide();
			Main_Screen main = new Main_Screen();
			main.ShowDialog();
		}

		private void addEvent_Click(object sender, EventArgs e)
		{

		}
	}
}
