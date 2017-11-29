using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Method_Source___Timer_Group_Project
{
	class pathNodeControl
	{ 
		#region Variables
		private pathNode firstPath; //The first path of the pathController
		private pathNode PS; //A scanner used to navigate through the stored paths in a non-discrutive way
		private static pathNodeControl master; //Singleton referance
		#endregion
		#region Getters/Setters
		public pathNode getFirstPath()
		{
			return firstPath;
		}
		public void setFirstPath(pathNode firstPathX)
		{
			firstPath = firstPathX;
		}

		public pathNode getPS()
		{
			return PS;
		}
		public void setPS(pathNode PSX)
		{
			PS = PSX;
		}


		#endregion
		#region Constructors
		public pathNodeControl()
		{
			firstPath = null;
			PS = null;
		}
		#endregion
		#region Singleton
		public static pathNodeControl Master()
		{
			if(master == null)
			{
				master = new pathNodeControl();
			}

			return master;
		}
		#endregion

		public void addPath(String pathNameX)
		{
			/*
			 * Three Conditions
			 * First Path == null - No Paths - FirstPath = New Path
			 * First Path.getNext() == null - One Path - FirstPath.getNext().setNext(New Path)
			 * First path.getNext() != null - > Two Path - find last and assign
			 */

			if (firstPath == null)
			{
				pathNode newPath = new pathNode(pathNameX);
				firstPath = newPath;
				Console.ForegroundColor = ConsoleColor.DarkGray;
				M.debug("New Path Created, assigned to firstPath");
			}

			else if(firstPath.getNextPath() == null)
			{
				pathNode newPath = new pathNode(pathNameX, firstPath);
				firstPath.setNextpath(newPath); //firstPath.next = newPath
                newPath.setPrevpath(firstPath);
				M.debug("New path Created, registered as second path created");
			}

			else
			{
				PS = firstPath;
				while(PS.getNextPath() != null)
				{
					//Find last path
					PS = PS.getNextPath();
				}
				pathNode newPath = new pathNode(pathNameX);
				PS.setNextpath(newPath); //lastPath.next = newPath
				newPath.setPrevpath(PS); //newPath.last = lastPath

				M.debug("Path created, Unkown path possiton, Prev/Next Path values assigned accordingly");
			}

		}

		#region removePath
		public void removePath(String pathNameToRemove)
		{
			pathNode toRemove = null;
			if(firstPath != null) //if FP == null then there are no paths
			{
				PS = firstPath;

				while(PS.getNextPath() != null)
				{
					if(PS.getPathName().Equals(pathNameToRemove))
					{
						toRemove = PS; //finding the first path with this name and exiting loop
						break;
					}
					PS = PS.getNextPath(); //incriment loop
				}

				if(toRemove == null)
				{
					Console.WriteLine("There was no Path With that Name. Pleaes make sure it was spelled correctly, this is Case sensative"); //No path found with proper nam
				}

				else
				{
					M.BL();
					Console.WriteLine("Are you Sure you want to remove path " + pathNameToRemove + "?"); //Double checking can't hurt
					Console.WriteLine("This CANNOT be undone");
					Console.WriteLine("Y/N");
					M.BL();
					ConsoleKeyInfo answer = Console.ReadKey(); //Reading answer
					M.BL();


					switch (answer.KeyChar)
					{

						case 'y': //making sure this works for either case
							{
								Console.WriteLine("Removing path " + pathNameToRemove + ".");
								removePath(toRemove);
								break;
							}

						case 'Y': //making sure this works for either case
							{
								Console.WriteLine("Removing path " + pathNameToRemove + ".");
								removePath(toRemove);
								break;
							}
						default:
							{
								Console.WriteLine("Cancling remove operation, returning to menu");
								break;
							}
					}
				}
			}

			else
			{
				Console.WriteLine("There are no paths to remove, please add some, so I can remove them");
			}
		}

		public void removePath(pathNode remove)
		{

			/*
			 * The getters for pathNodes are not build to not return null, meaning if you try and call a method like
			 * remove.getNext().setNext(null) but remove.getNext() is null it will hard error
			 */
			if(remove == firstPath) //If the path to remove is the first path, you simple need to re-assign first path.
			{
				if (remove.getNextPath() == null) //Program will error out w/o these error checks
				{
					firstPath = null;
				}

				else
				{
					firstPath = remove.getNextPath();
					firstPath.setPrevpath(null);
				}
			}

			else if(remove == firstPath.getNextPath()) 
				/*
				 * This is a simi-redundent case
				 * This could be handled with the else statment
				 * however I like handling this case seperatly I don't know why
				 * Anyt thing I mess with anything to do with firstPath, I like to call it Directly
				 */
			{
				if(remove.getNextPath() == null)
				{
					firstPath.setNextpath(null);
					remove.setPrevpath(null); //This is a redudent clean up that I like to do, it is not necissary
				}

				else
				{
					firstPath.setNextpath(remove.getNextPath());
					remove.getNextPath().setPrevpath(firstPath);
					remove.setNextpath(null);
					remove.setPrevpath(null);
				}
			}

			else
			{
				if(remove.getNextPath() == null)
				{
					remove.getPrevPath().setNextpath(null);
					remove.setNextpath(null);
				}

				else
				{
					remove.getPrevPath().setNextpath(remove.getNextPath());
					remove.getNextPath().setPrevpath(remove.getPrevPath());
					remove.setNextpath(null);
					remove.setPrevpath(null);
				}
			}
		}
		#endregion

		public void editPath(String pathName)
		{
			if(firstPath != null)
			{
				//If firstPath == null there are no paths
				PS = firstPath;
				pathNode toEdit = null;
				while(PS.getNextPath() != null)
				{
					if(PS.getPathName().Equals(pathName))
					{
						//Finding the first path with that name, storing it, and breaking out of the loop
						toEdit = PS;
						break;
					}

					PS = PS.getNextPath();
				}

				if(toEdit == null)
				{
					//No path by that name
					Console.WriteLine("There is no path by that name. Please make sure it was spelt correctly, this is Case Sensative");
				}

				else
				{
					//The path was found
					Console.WriteLine("What would you like to do in path " + pathName + "?");
					M.BL();
					Console.WriteLine("1) Edit the Path's name");
					Console.WriteLine("2) Edit the timer set in Path " + pathName);

					ConsoleKeyInfo answer = Console.ReadKey();

					switch(answer.KeyChar)
					{
						case '1':
							{
								PS.changePathName(pathName);
								break;
							}

						case '2':
							{

								break;
							}
						default:
							{
								break;
							}
					}

				}
			}

			else
			{
				Console.WriteLine("There are no paths to Edit. Please Create some First");
			}
		}
	}

}
