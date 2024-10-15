using System;

namespace Game
{
    public class ComputerPlayer : Player
    {
        private Random random;

        public ComputerPlayer(string name) : base(name)
        {
            random = new Random();
        }

        public override int TakePins(Board board)
        {
            int sticksToTake = random.Next(1, 3); // Väljer 1 eller 2
            Console.WriteLine($"{Name} tar {sticksToTake} stickor.");
            board.TakeSticks(sticksToTake);
            return sticksToTake;
        }
    }
}
