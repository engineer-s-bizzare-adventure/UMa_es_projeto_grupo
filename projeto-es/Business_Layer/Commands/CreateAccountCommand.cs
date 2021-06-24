namespace projeto_es.Business_Layer.Commands
{
    public class CreateAccountCommand : RegisterCommand
    {
        private RegisterReceiver _registerReceiver;

        public CreateAccountCommand(RegisterReceiver registerReceiver) : base (registerReceiver) {
            _registerReceiver = registerReceiver;
        }

        public override void Execute()
        {
            //return _registerReceiver.CreateAccount(email, password);
        }

    }
}