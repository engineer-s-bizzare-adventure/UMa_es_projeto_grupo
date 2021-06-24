namespace projeto_es.Business_Layer.Commands
{
    public class RegisterPersonCommand : RegisterCommand
    {
        private RegisterReceiver _registerReceiver;
        private string _name, _address;
        private int _age;

        public RegisterPersonCommand(RegisterReceiver registerReceiver, 
            string name, int age, string address) : base (registerReceiver) {
            _registerReceiver = registerReceiver;
            _name = name;
            _address = address;
            _age = age;

        }

        public override void ExecuteCommand() {
            _registerReceiver.RegisterPerson(_name, _age, _address);
        }

    }
}