namespace MultipleChoiceConsoleApp
{
    using Lib.ConsoleHelper;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ChoiceMenu menu = new ChoiceMenu(new Settings
            {
                IntroText="Welcome to a multiple choice menu demo..."
            });
            menu.Options.Add(new MenuItem
            {
                Title = "C#",
                Value = "1"
            });
            menu.Options.Add(new MenuItem
            {
                Title = "javascript",
                Value = "2"
            });
            menu.Options.Add(new MenuItem
            {
                Title = "typescript",
                Value = "3"
            });
            menu.Options.Add(new MenuItem
            {
                Title = "python",
                Value = "4"
            });
            menu.Options.Add(new MenuItem
            {
                Title = "swift",
                Value = "5"
            });

            var selectedLanguage = menu.ReadChoice(true);

            if (selectedLanguage == null)
                Console.WriteLine("Cancelled");
            else
                Console.WriteLine(selectedLanguage.Title);
        }
    }
}
