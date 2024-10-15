namespace Game
{
    public abstract class Player
    {
        public string Name { get; protected set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public abstract int TakePins(Board board);
    }
}
