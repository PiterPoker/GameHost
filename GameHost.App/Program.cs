using GameDomain;
using GameHost.App.Services.Runner;
using GameDomain.Services.Configuration;
using GuessNumber;

namespace GameHost.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = Game.Create<GuessNumber.GuessNumberGame>();
            IRunnerService<Game> runner = new GameRunnerService<Game>(game);
            runner.Run();
        }
    }
}
