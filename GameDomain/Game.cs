namespace GameDomain
{
    public abstract class Game
    {
        public abstract void Start();
        public abstract void Initialize(Setting settings);
        public abstract Setting GetSettings();
        public static Game Create<TGame>() where TGame : Game, new()
        {
            return new TGame();
        }
    }
}
