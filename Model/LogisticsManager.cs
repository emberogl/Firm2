namespace Firm2.Model
{
    internal class LogisticsManager : Coo
    {
        public LogisticsManager(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 248000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}