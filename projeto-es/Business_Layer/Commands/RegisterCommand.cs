namespace projeto_es.Business_Layer.Commands
{
    public abstract class RegisterCommand
    {
        protected RegisterReceiver receiver;

        public RegisterCommand(RegisterReceiver receiver) 
        {
            this.receiver = receiver;
        }

        public abstract void Execute();
    }
}