using GameDomain;
using Guess_Number.Services.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHost.App.Services.Runner
{
    internal interface IRunnerService<TGame> where TGame : Game
    {
        void Run(TGame game);
    }
}
