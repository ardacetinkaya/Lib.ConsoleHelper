namespace MultipleChoiceConsoleApp
{
    using Lib.ConsoleHelper;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to a multiple choice menu demo...");
            MultipleChoiceMenu menu = new MultipleChoiceMenu();

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

            var selectedClass = menu.ReadChoice(true);

            if (selectedClass == null)
                Console.WriteLine("Cancelled");
            else
                Console.WriteLine(selectedClass.Title);
        }
    }
}
