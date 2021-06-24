namespace projeto_es.Business_Layer.Commands
{
    public class RegisterInvoker 
    {
        private RegisterCommand _command;

        public void SetCommand(RegisterCommand command) 
        {
            _command = command;
        }

        public void ExecuteCommand() 
        {
            _command.ExecuteCommand();
        }

    }
}