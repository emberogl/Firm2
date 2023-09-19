namespace Firm2.Model
{
    internal class Cfo : Ceo
    {
        private protected int _salary = 400000 / 12;

        public Cfo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }
    }
}
