using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Source___Timer_Group_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			pathNodeControl paths = pathNodeControl.Master();
			paths.addPath("Path One");
			paths.addPath("Path Two");
			paths.addPath("Path Three");
			paths.removePath("Path One");
		}
	}
}
