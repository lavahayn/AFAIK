using Additionals.Exceptions;
using Additionals.Interfaces;
using System;

namespace AFAIK.Solution
{
    internal class CommandManager
    {
        public CommandManager()
        {
            this.m_CommandoAcceptor = new SolutionManager();
        }

        private ICommands m_CommandoAcceptor = null;

        internal bool Execute(Commands newProject)
        {
            bool blnReturn = false;
            switch (newProject)
            {
                case Commands.CreateNewProject:
                    blnReturn = m_CommandoAcceptor.CreateNewSolution(); 
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
                    throw new InvalidCommandException("Command ");
            }
            return blnReturn;
        }
    }
}