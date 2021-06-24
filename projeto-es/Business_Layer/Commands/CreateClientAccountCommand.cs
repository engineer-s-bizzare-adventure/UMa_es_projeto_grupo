namespace projeto_es.Business_Layer.Commands



{
    public class CreateClientAccountCommand : RegisterCommand 
    {
        private RegisterReceiver _registerReceiver;

        public CreateClientAccountCommand(RegisterReceiver registerReceiver) : base (registerReceiver) {
            _registerReceiver = registerReceiver;
        }

        public override void Execute() {
            return _registerReceiver.CreateClientAccount();
        }

    }
}