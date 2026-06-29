using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsApp.src.DesignPatterns.Behavioral.CommandPattern.GoodExample
{

    //INVOKER
    public class RemoteControl
    {
        private ICommand _command;  

        public RemoteControl(ICommand command)
        {
            _command = command;
        }   

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }
}