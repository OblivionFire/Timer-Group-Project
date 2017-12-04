using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source_Timer_Group_Project
{
	public class eventNodeControler
	{
		public static eventNodeControler master;
		private eventNode firstEvent;
		private eventNode ES;

		public eventNodeControler()
		{
			firstEvent = null;
			ES = null;
		}

		public static eventNodeControler Master()
		{
			if(master == null)
			{
				master = new eventNodeControler();
			}

			return master;
		}

		public void addEvent(String eventNameX, DateTime endTimeX)
		{
			/*
			 * Three Conditions
			 * First Event == null - No Events - firstEvent = New Path
			 * First Event.getNext() == null - One Event - firstEvent.getNext().setNext(New Event)
			 * First Event.getNext() != null - > Two Events - find last and assign
			 */

			if (firstEvent == null)
			{
				eventNode newEvent = new eventNode(eventNameX, endTimeX);
				firstEvent = newEvent;
				M.debug("New Event Created, assigned to firstEvent");
			}

			else if (firstEvent.getNextEvent() == null)
			{
				eventNode newEvent = new eventNode(eventNameX, endTimeX);
				firstEvent.setNextEvent(newEvent); //firstEvent.next = newPath
				newEvent.setPrevEvent(firstEvent);
				M.debug("New Event Created, registered as second Event created");
			}

			else
			{
				ES = firstEvent;
				while (ES.getNextEvent() != null)
				{
					//Find last path
					ES = ES.getNextEvent();
				}
				eventNode newPath = new eventNode(eventNameX, endTimeX);
				ES.setNextEvent(newPath); //lastPath.next = newPath
				newPath.setPrevEvent(ES); //newPath.last = lastPath

				M.debug("Event created, Unkown Event possiton, Prev/Next Event values assigned accordingly");
			}
		}

		public eventNode[] getEventArray()
		{
			int eventCount = 1;
			if(firstEvent == null)
			{
				eventNode[] temp = new eventNode[0];
				return temp;
			}

			else
			{
				ES = firstEvent;

				while(ES.getNextEvent() != null)
				{
					eventCount++;
					ES = ES.getNextEvent();
				}

				eventNode[] events = new eventNode[eventCount];
				ES = firstEvent;

				for(int i = 0; i<eventCount; i++)
				{
					events[i] = ES;
					ES = ES.getNextEvent();
				}

				return events;

			}
		}

	}
}
