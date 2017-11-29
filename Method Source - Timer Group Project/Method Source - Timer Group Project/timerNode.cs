using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source___Timer_Group_Project
{
	class timerNode
	{
		#region Variables
		private timerNode prevTimer;
		private timerNode nextTimer;
		private medNode med;
        private string name;
		#endregion
		#region Getters/Setters
		public timerNode getPrevTimer()
		{
			return prevTimer;
		}
		public void setPrevTimer(timerNode prevTimerX)
		{
			prevTimer = prevTimerX;
		}

		public timerNode getNextTimer()
		{
			return nextTimer;
		}
		public void setNextTimer(timerNode nextTimerX)
		{
			nextTimer = nextTimerX;
		}

        public string getTimerName()
        {
            return name;
        }
        public void setTimerName(String nameX)
        {
            name = nameX;
        }

        public medNode getMed()
        {
            return med;
        }
        public void setMed(medNode medX)
        {
            med = medX;
        }
		#endregion
		#region Constructor
		public timerNode()
		{
			//Defult constructor
			prevTimer = null;
			nextTimer = null;
			med = new medNode();
		}

		public timerNode(String timerNameX)
		{
			//Constructor used for the first path created
			prevTimer = null;
			nextTimer = null;
			name = timerNameX;
			med = new medNode();
		}

		public timerNode(String timerNameX, timerNode prevTimerX)
		{
			//Constructor for when only the prev path is know (The second path created)
			name = timerNameX;
			prevTimer = prevTimerX;
			prevTimer = null;
			med = new medNode();
		}

		public timerNode(String timerNameX, timerNode prevTimerX, timerNode nextTimerX)
		{
			//Constructor that is going to be used the most often. Used when > 2 paths created
			name = timerNameX;
			prevTimer = prevTimerX;
			nextTimer = nextTimerX;
			med = new medNode();
		}
		#endregion

	}
}
