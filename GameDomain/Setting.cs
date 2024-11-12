using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDomain
{
    public record Setting(string Name)
    {
        public string Name { get; init; } = Name;
    }
}
