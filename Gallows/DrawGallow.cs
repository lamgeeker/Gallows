using System;


namespace Gallows
{
    internal class DrawGallow
    {
      public bool IsFull { get; set; }

        public void Draw(bool IsLetterRight, int count)
        {

            if (!IsLetterRight && count == 0)
            {
                Console.WriteLine("---------|");
                Console.WriteLine(" |       |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("        ___");

            }
            if (!IsLetterRight && count ==1)
            {
                Console.WriteLine("---------|");
                Console.WriteLine(" |       |");
                Console.WriteLine(" О       |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("        ___");
                
            }
            if (!IsLetterRight && count == 2)
            {
                Console.WriteLine("---------|");
                Console.WriteLine(" |       |");
                Console.WriteLine(" О       |");
                Console.WriteLine("-|-      |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("        ___");
               
            }
            if (!IsLetterRight && count == 3)
            {
                Console.WriteLine("---------|");
                Console.WriteLine(" |       |");
                Console.WriteLine(" О       |");
                Console.WriteLine("-|-      |");
                Console.WriteLine("/        |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("        ___");
                
            }
            if (!IsLetterRight && count == 4)
            {
                Console.WriteLine("---------|");
                Console.WriteLine(" |       |");
                Console.WriteLine(" О       |");
                Console.WriteLine("-|-      |");
                Console.WriteLine("/ \\      |");
                Console.WriteLine("         |");
                Console.WriteLine("         |");
                Console.WriteLine("        ___");
                IsFull = true;
            }
        }

        

    }
}
