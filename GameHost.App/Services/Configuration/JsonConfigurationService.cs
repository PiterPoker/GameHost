﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Guess_Number.Services.Configuration
{
    internal class JsonConfigurationService<TSettings> 
        : IConfigurationService<TSettings> where TSettings : class
    {
        public TSettings GetSettings(string fullPath)
        {
            var jsonString = File.ReadAllText(fullPath);
            return JsonSerializer.Deserialize<TSettings>(jsonString);
        }
    }
}