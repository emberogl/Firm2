namespace Firm2.Model
{
    internal class Coo : Ceo
    {
        public Coo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 500000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
