﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Method_Source_Timer_Group_Project
{
	public class eventNode
	{
		#region Variables
		private eventNode prevEvent;
		private eventNode nextEvent;
		private DateTime endTime;
		private string name;
		private medNode med;
		#endregion
		#region Getters/Setters
		public eventNode getPrevEvent()
		{
			return prevEvent;
		}
		public void setPrevEvent(eventNode prevEventX)
		{
			prevEvent = prevEventX;
		}

		public eventNode getNextEvent()
		{
			return nextEvent;
		}
		public void setNextEvent(eventNode nextEventX)
		{
			nextEvent = nextEventX;
		}

		public DateTime getEndTime()
		{
			return endTime;
		}
		public void setEndTime(DateTime endTimeX)
		{
			endTime = endTimeX;
		}

		public string getName()
		{
			return name;
		}
		public void setName(string nameX)
		{
			name = nameX;
		}

		public medNode getLinkedMed()
		{
			return med;
		}
		public void setLinkMed(medNode linkedMedX)
		{
			med = linkedMedX;
		}

		#endregion
		#region Constructors
		public eventNode()
		{
			prevEvent = null;
			nextEvent = null;
			name = null;
		}

		public eventNode(string nameX, DateTime endTimeX)
		{
            name = nameX;
            endTime = endTimeX;
            this.start();
        }

        public eventNode(string nameX, DateTime endTimeX, medNode linkedMedX)
        {
            name = nameX;
            endTime = endTimeX;
            med = linkedMedX;
            this.start();

        }
		#endregion

		public void start()
		{
			while(DateTime.Now > endTime)
			{

			}

			MessageBox.Show("Event " + name + " has finished");
		}
		

		public string toString()
		{
			if(med == null)
			{
				return ("Event Name: " + name + " Event Time: " + endTime.ToString());
			}

			else
			{
				return ("Event Name: " + name + " Event Time: " + endTime.ToString() + " Medication: " + med.toString(1));
			}
		}


	}
}
