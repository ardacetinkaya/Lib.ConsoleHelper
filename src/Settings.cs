namespace Lib.ConsoleHelper
{
    using System;

    public class Settings
    {
        public string Selection { get; set; } = "*";
        public ConsoleColor SelectionColor { get; set; } = ConsoleColor.Yellow;
        public string IntroText { get; set; }
    }
}
