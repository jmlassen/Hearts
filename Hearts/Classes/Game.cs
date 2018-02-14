using Hearts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts.Classes
{
    class Game : IGame
    {
        private bool _EndGame;

        private IEnumerable<IPlayer> _Players;

        private IHistory _History;

        public Game()
        {
            _EndGame = false;
            _Players = new List<IPlayer>();
            _History = new History();
        }

        public void Start()
        {
            // TODO: Move this somewhere else more logical.
            Console.Clear();

            while (!_EndGame)
            {
                Console.Write(">");
                string input = Console.ReadLine();

                _ProcessInput(input);
            }
        }

        private void _ProcessInput(string input)
        {
            switch (input.ToLower())
            {
                case "l":
                    _PrintPlayerHand();
                    break;
                case "h":
                    _PrintTrickHistory();
                    break;
                case "c":
                    Console.Clear();
                    break;
                case "q":
                    Console.WriteLine("Thanks for playing!");
                    _EndGame = true;
                    break;
                default:
                    _PrintCommands();
                    break;
            }
        }

        private void _PrintPlayerHand()
        {
            throw new NotImplementedException();
        }

        private void _PrintTrickHistory()
        {

            throw new NotImplementedException();
        }

        private void _PrintCommands()
        {
            Console.Write(
                $"l: look at hand\n" +
                $"h: print last trick history\n" +
                $"c: clear screen\n" +
                $"q: quit the game\n");
        }
    }
}
