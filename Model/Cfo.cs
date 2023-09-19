namespace Firm2.Model
{
    internal class Cfo : Ceo
    {
        public Cfo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr) 
        {
            _salary = 400000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
