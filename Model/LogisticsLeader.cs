namespace Firm2.Model
{
    internal class LogisticsLeader : LogisticsManager
    {
        public LogisticsLeader(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 110000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}