using System;

namespace AFAIK.Solution
{
    internal class CommandManager
    {
        internal bool Execute(Commands newProject)
        {
            switch (newProject)
            {
                case Commands.CreateNewProject:
                    break;
                case Commands.OpenProject:
                    break;
                case Commands.CloseProject:
                    break;
                case Commands.SaveProject:
                    break;
                case Commands.CloseApplication:
                    break;
                default:
                    break;
            }
            return true;
        }
    }
}