namespace Firm2.Model
{
    internal class FinanceManager : Cfo
    {
        public FinanceManager(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 228000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}