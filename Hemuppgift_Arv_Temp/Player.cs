namespace Game
{
    public abstract class Player
    {
        protected string name;

        public Player(string name)
        {
            this.name = name;
        }

        public abstract int TakePins(Board board);
    }
}
