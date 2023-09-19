namespace Firm2.Model
{
    internal class Coo : Ceo
    {
        private protected int _salary = 500000 / 12;

        public Coo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
