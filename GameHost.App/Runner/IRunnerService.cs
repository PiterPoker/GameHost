using GameDomain;
using GameDomain.Services.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHost.App.Services.Runner
{
    public interface IRunnerService<TGame> where TGame : Game
    {
        TGame Game { get; set; }
        void Run();
    }
}
