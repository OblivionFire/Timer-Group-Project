using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source___Timer_Group_Project
{
	class timerNodeControl
	{
		#region Variables
		private timerNode firstTimer; //referance to first node stored
		private timerNode TS; //A scanner used to accsess data in a non-discructive fassion
		#endregion
		#region Getters/Setters
		public timerNode getFirstNode()
		{
			return firstTimer;
		}
		public void setFristNode(timerNode firstNodeX)
		{
			firstTimer = firstNodeX;
		}

		/*
		 * No getter and setter for TS, it will never be called out side this method
		 */
		#endregion
		#region Constructors

		public timerNodeControl()
		{
			firstTimer = null;
			TS = null;
		}

		#endregion




		public void addTimer(String timerNodeX)
		{
			/*
			 * Three Conditions
			 * First Path == null - No Paths - firstTimer = New Path
			 * First Path.getNext() == null - One Path - firstTimer.getNext().setNext(New Path)
			 * First path.getNext() != null - > Two Path - find last and assign
			 */

			if (firstTimer == null)
			{
				timerNode newPath = new timerNode(timerNodeX);
				firstTimer = newPath;
				Console.ForegroundColor = ConsoleColor.DarkGray;
				M.debug("New Path Created, assigned to firstTimer");
			}

			else if (firstTimer.getNextTimer() == null)
			{
				timerNode newPath = new timerNode(timerNodeX, firstTimer);
				firstTimer.setNextTimer(newPath); //firstTimer.next = newPath
				M.debug("New path Created, registered as second path created");
			}

			else
			{
				TS = firstTimer;
				while (TS.getNextTimer() != null)
				{
					//Find last path
					TS = TS.getNextTimer();
				}
				timerNode newPath = new timerNode(timerNodeX);
				TS.setNextTimer(newPath); //lastPath.next = newPath
				newPath.setPrevTimer(TS); //newPath.last = lastPath

				M.debug("Path created, Unkown path possiton, Prev/Next Path values assigned accordingly");
			}

		}


	}
}
