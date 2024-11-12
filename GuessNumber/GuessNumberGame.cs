using GameDomain;
using GameDomain.Services.Configuration;
using GuessNumber.Helpers;
using GuessNumber.Models;
using GuessNumber.Services;
using System;
using System.Diagnostics.Metrics;
using System.Runtime;
using System.Windows.Markup;

namespace GuessNumber
{
    public class GuessNumberGame : Game
    {
        private AppSettings _appSettings;
        private IGeneratorService _generator;
        private IValidator _validator;

        public override Setting GetSettings()
        {
            IConfigurationService<AppSettings> configuration = new JsonConfigurationService<AppSettings>();
            return configuration.GetSettings("appsettings.json");
        }

        public override void Initialize(Setting settings)
        {
            this._appSettings = (AppSettings)settings;

            this._generator = new NumberGeneratorService(new Random());

            ICompositeValidator validator = new CompositeValidator();
            validator.Add(new NumericInputValidator());
            validator.Add(new RangeInputValidator(this._appSettings.MinNumber, this._appSettings.MaxNumber));
            this._validator = (IValidator)validator;
        }

        public override void Start()
        {
            var targetNumber = this._generator.Generate(this._appSettings.MinNumber, this._appSettings.MaxNumber);
            var attempts = 0;
            do
            {
                Console.Write($"Try {attempts + 1} in {this._appSettings.MaxAttempts}. Enter number from {this._appSettings.MinNumber} to {this._appSettings.MaxNumber}: ");
                var input = Console.ReadLine();
                if (_validator.IsValid(input))
                {
                    if (int.TryParse(input, out var number))
                    {
                        if (IsGuess(number, targetNumber))
                            break;
                    }
                    attempts++;
                }
            } while (this._appSettings.MaxAttempts > attempts);
            TypeTextHelper.TypeText($"You didn't guess. The Hidden Number = {targetNumber} \nGame over :(", ConsoleColor.DarkRed);
        }

        private bool IsGuess(int number, int targetNumber)
        {
            bool isGuess = false;
            if (number < targetNumber)
            {
                var percent = (targetNumber - number) * 100 / targetNumber;
                TypeTextHelper.TypeText($"The number guessed is higher ({percent}%)", ConsoleColor.Yellow);
            }
            if (number == targetNumber)
            {
                isGuess = true;
                TypeTextHelper.TypeText("You guessed the number. Congratulations!", ConsoleColor.Green);
            }
            if (number > targetNumber)
            {
                var percent = (number - targetNumber) * 100 / number;
                TypeTextHelper.TypeText($"The number guessed is less ({percent}%)", ConsoleColor.Yellow);
            }
            return isGuess;
        }
    }
}
