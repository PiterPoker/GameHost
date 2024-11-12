using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDomain.Services.Configuration
{
    public interface IConfigurationService<TSettings> where TSettings : class
    {
        TSettings GetSettings(string fullPath);
    }
}
