using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source___Timer_Group_Project
{
	class medNode
	{
        #region Variables
        private medNode prevMed;
        private medNode nextMed;
        private string name;
        private string does;
        private TimeSpan treatTime;
        #endregion
        #region Getters/Setters
        public medNode getPrevMed()
        {
            return prevMed;
        }
        public void setPrevMed(medNode prevMedX)
        {
            prevMed = prevMedX;
        }

        public medNode getNextMed()
        {
            return nextMed;
        }
        public void setNextMed(medNode nextMedX)
        {
            nextMed = nextMedX;
        }

        public string getName()
        {
            return name;
        }
        public void setName(string nameX)
        {
            name = nameX;
        }

        public string getDoes()
        {
            return does;
        }
        public void setDoes(string doesX)
        {
            does = doesX;
        }

        public TimeSpan getTime()
        {
            return treatTime;
        }
        public void set(TimeSpan treatTimeX)
        {
            treatTime = treatTimeX;
        }
        #endregion
        #region Constructors
        public medNode()
		{
			name = null;
			does = null;
		}

		public medNode(String medNameX, String medDoesX, TimeSpan treatTimeX)
		{
			name = medNameX;
			does = medDoesX;
			treatTime = treatTimeX;
		}
		#endregion





		#region Misc.
		public void toString()
		{
			Console.WriteLine("Medication Name: " + name);
			Console.WriteLine("Medication Does: " + does);
			Console.WriteLine("Treatment Time (HH:MM:SS) : " + treatTime.ToString());
			M.BL();
		}

		public string toString(bool wantReturn)
		{
			return (name + does);
		}
		#endregion
	}
}
