using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSavingPractice
{
   
    internal class Program
    {
        // player constants
        const int playerMaxHealth = 20;

        static void Main(string[] args)
        {
            if (!System.IO.File.Exists("globals.txt"))
            {
                System.IO.File.Create(@"globals.txt").Close();
                // System.IO.File.WriteAllText(@"savegame.txt", savePage);
            }

        }
    }

}