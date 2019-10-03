# :computer: Lib.ConsoleHelper

Interaction with an application on CLI can make the application powerful. This simple library provides easy interaction with a console application, with a simple menu mechanisim that can be controlled with arrow keys(:arrow_down: and :arrow_up:) for .NET Core applications.

![Menu](https://github.com/ardacetinkaya/Lib.ConsoleHelper/blob/master/images/menu.gif)


## Usage ##

```csharp
            ChoiceMenu menu = new ChoiceMenu();

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
```

## Settings ##

When initializing ```ChoiceMenu```, it is possible to modify some menu features.

```csharp
            Settings settings = new Settings
            {
                IntroText = "Please choice:",
                Selection = "*",
                SelectionColor = ConsoleColor.Yellow
            };

            ChoiceMenu menu = new ChoiceMenu(settings);
```