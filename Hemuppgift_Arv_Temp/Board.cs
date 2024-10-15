namespace Game
{
    public class Board
    {
        private int sticks;

        public Board(int initialSticks)
        {
            sticks = initialSticks;
        }

        public int GetSticks()
        {
            return sticks;
        }

        public void TakeSticks(int number)
        {
            if (number >= 1 && number <= 2 && sticks >= number)
            {
                sticks -= number;
            }
        }

        public bool IsEmpty()
        {
            return sticks == 0;
        }
    }
}
