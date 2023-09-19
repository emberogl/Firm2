namespace Firm2.Model
{
    internal class ItManager : Cfo
    {
        public ItManager(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 160000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}