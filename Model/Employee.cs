namespace Firm2.Model
{
    internal class Employee
    {
        private protected string _firstName;
        private protected string _lastName;
        private protected uint _cpr;

        private protected uint _salary;
        private protected uint _bankStatement;

        private protected Employee(string firstName, string lastName, uint cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }

        public void PayEmployee()
        {
            _bankStatement += _salary;
        }

        public string GetBankStatement()
        {
            return $"{_firstName}'s bank statement: ${_bankStatement}";
        }
    }
}