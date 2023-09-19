namespace Firm2.Model
{
    internal class FinanceWorker : FinanceManager
    {
        private protected int _salary = 89000 / 12;
        
        public FinanceWorker(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
