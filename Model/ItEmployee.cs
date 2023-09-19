namespace Firm2.Model
{
    internal class ItEmployee : ItLeader
    {
        public ItEmployee(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 88000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}