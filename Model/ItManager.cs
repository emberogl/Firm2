namespace Firm2.Model
{
    internal class ItManager : Cfo
    {
        private protected int _salary = 160000 / 12;

        public ItManager(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
