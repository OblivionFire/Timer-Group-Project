using System.Windows.Forms;

namespace WindowsFormsApp5
{
    internal class Med
    {
        private string name;
        private string time;

        public Med(object e)
        {
            string temp = (string)e;
            int i = temp.IndexOf(',');
            name = temp.Substring(0, i);
            time = temp.Substring(i + 1);
            return;
        }
        public string getName()
        {
            return name;
        }

        public string getTime()
        {
            return time;
        }
    }
}