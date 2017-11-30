using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source___Timer_Group_Project
{
	class eventNode
	{
		#region Variables
		private eventNode prevEvent;
		private eventNode nextEvent;
		private DateTime endTime;
		private string name;
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
		}
		#endregion

		public void start()
		{
			while(endTime > DateTime.Now)
			{

			}

			Console.WriteLine("Event " + name + "has completed");
		}

	}
}
