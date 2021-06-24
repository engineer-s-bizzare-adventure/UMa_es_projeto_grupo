namespace projeto_es.Business_Layer.Commands
{
    public class RegisterPersonCommand : RegisterCommand
    {
        private RegisterReceiver _registerReceiver;

        public RegisterPersonCommand(RegisterReceiver registerReceiver) : base (registerReceiver) {
            _registerReceiver = registerReceiver;
        }

        public override void Execute() {
            return _registerReceiver.RegisterPerson();
        }

    }
}