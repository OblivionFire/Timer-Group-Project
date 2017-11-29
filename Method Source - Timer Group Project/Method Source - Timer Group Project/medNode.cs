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

		}
		#endregion
	}
}
