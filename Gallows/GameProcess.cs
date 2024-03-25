using System.Linq;


namespace Gallows
{
    internal class GameProcess
    {
        public int PersonalRecord { get;  set; }
       
       
        public bool IsWin(char[] mas)
        {
            if (!mas.Contains('_'))
            {
                PersonalRecord++;
                return true;
            }
            return false;
        }

       
    }
}