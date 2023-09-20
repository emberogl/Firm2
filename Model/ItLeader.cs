namespace Firm2.Model
{
    internal class ItLeader : ItManager
    {
        public ItLeader(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 150000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}