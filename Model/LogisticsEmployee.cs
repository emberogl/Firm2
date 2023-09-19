namespace Firm2.Model
{
    internal class LogisticsEmployee : LogisticsLeader
    {
        public LogisticsEmployee(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 82000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}