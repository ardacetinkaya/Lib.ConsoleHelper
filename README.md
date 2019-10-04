# :computer: Lib.ConsoleHelper


| Build  | Nuget |
| ------------- | ------------- |
| [![Build status](https://miyop.visualstudio.com/Lib/_apis/build/status/Lib-ConsoleHelper)](https://miyop.visualstudio.com/Lib/_build/latest?definitionId=4) | [![NuGet version (Lib.ConsoleHelper)](https://img.shields.io/nuget/v/Lib.ConsoleHelper.svg)](https://www.nuget.org/packages/Lib.ConsoleHelper/)  |


This simple library provides an easy interaction way with a console application, with a simple menu mechanism that can be controlled with arrow keys(:arrow_down: and :arrow_up:) for .NET Core applications.

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
