namespace projeto_es.Business_Layer.Commands
{
    public class CreateAccountCommand : RegisterCommand
    {
        private RegisterReceiver _registerReceiver;
        private string _email, _password;

        public CreateAccountCommand(RegisterReceiver registerReceiver, string email, string password) : base (registerReceiver) {
            _registerReceiver = registerReceiver;
            _email = email;
            _password = password;
        }

        public override void ExecuteCommand() {
            _registerReceiver.CreateAccount(_email, _password);
        }

    }
}