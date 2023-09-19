namespace Firm2.Model
{
    internal class Ceo : Employee
    {
        public Ceo(string firstName, string lastName, uint cpr) : base(firstName, lastName, cpr)
        {
            _salary = 800000 / 12;
            _firstName = firstName;
            _lastName = lastName;
            _cpr = cpr;
        }

        /// These methods are being inherited by the next classes derived by CEO, which could be prevented with an interface
        #region HR Functionalities
        public string HireEmployee(string employeeName)
        {
            return $"{employeeName} has been hired.";
        }
        public string FireEmployee(string employeeName)
        {
            return $"{employeeName} has been fired.";
        }
        #endregion

        #region ADM Functionalities
        public string ApproveBudget(int amount)
        {
            return $"Budget of ${amount} has been approved.";
        }
        public string OrganizeMeeting(string details)
        {
            return $"Meeting organized: {details}";
        }
        #endregion
    }
}