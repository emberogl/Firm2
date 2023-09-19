namespace Firm2.Model
{
    internal class Employee
    {
        private protected string _firstName;
        private protected string _lastName;
        private protected uint _cpr;

        private protected Employee(string firstName, string lastName, uint cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
