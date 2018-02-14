using Hearts.Classes;
using Hearts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = SetupGame();
            game.Start();
        }

        private static IGame SetupGame()
        {
            return new Game();
        }
    }
}
