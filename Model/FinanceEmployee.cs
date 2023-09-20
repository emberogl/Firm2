namespace Firm2.Model
{
    internal class FinanceEmployee : FinanceLeader
    {
        public FinanceEmployee(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 58000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}