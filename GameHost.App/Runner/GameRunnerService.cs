using GameDomain;
using GameDomain.Services.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHost.App.Services.Runner
{
    public class GameRunnerService<TGame>
        : IRunnerService<TGame> where TGame : Game
    {

        public TGame Game { get; set; }

        public GameRunnerService(TGame game)
        {
            Game = game;
        }

        public void Run()
        {
            Console.WriteLine($"Load settings...");
            var settings = Game.GetSettings();
            Console.WriteLine($"Load game {settings.Name}...");
            Game.Initialize(settings);
            if (settings is not null)
            {
                Console.WriteLine($"Game {settings.Name} is running...");
                Game.Start(); 
            }
        }
    }
}
