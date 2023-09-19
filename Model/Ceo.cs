namespace Firm2.Model
{
    internal class Ceo : Employee
    {
        private protected int _salary = 800000/12;

        public Ceo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
