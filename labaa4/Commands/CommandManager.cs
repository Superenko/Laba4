using System;
using System.Collections.Generic;
using labaa4.Commands.Base;

namespace labaa4.Commands
{
    internal class CommandManager
    {
        public void AddCommand(BaseCommand command)
        {
            Commands.Add(command);
        }

        public void DisplayCommands()
        {
            for (var i = 0; i < Commands.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Commands[i].GetCommandInfo()}");
            }
        }

        public void ExecuteCommand(int index)
        {
            if (index >= 0 && index < Commands.Count)
            {
                Commands[index].Execute();
            }
            else
            {
                Console.WriteLine("Wrong command");
            }
        }

        public List<BaseCommand> Commands { get; } = new List<BaseCommand>();
    }
}
