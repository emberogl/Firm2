namespace Firm2.Model
{
    internal class ItWorker : Cfo
    {
        private protected int _salary = 93000 / 12;

        public ItWorker(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
