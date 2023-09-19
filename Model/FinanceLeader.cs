namespace Firm2.Model
{
    internal class FinanceLeader : FinanceManager
    {
        public FinanceLeader(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 120000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}