namespace Firm2.Model
{
    internal class FinanceManager : Cfo
    {
        private protected int _salary = 228000 / 12;

        public FinanceManager(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
