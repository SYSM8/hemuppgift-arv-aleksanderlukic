using System;

namespace Game
{
    public class HumanPlayer : Player
    {
        // Konstruktor som tar emot ett namn och skickar det vidare till Player-konstruktorn
        public HumanPlayer(string name) : base(name)
        {
        }

        public override int TakePins(Board board)
        {
            Console.WriteLine($"{Name}, det finns {board.GetSticks()} stickor kvar.");
            Console.Write("Hur många stickor vill du ta (1 eller 2)? ");
            int sticksToTake = int.Parse(Console.ReadLine());
            board.TakeSticks(sticksToTake);
            return sticksToTake;
        }
    }
}
