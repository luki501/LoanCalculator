namespace LoanCalculatorWPF.Model
{
    public class Proposal
    {        
        #region properties
        private decimal amount;
        private int numberOfYears;
        private LoanType typeOfLoan;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public int NumberOfYears
        {
            get { return numberOfYears; }
            set { numberOfYears = value; }
        }
        public LoanType TypeOfLoan
        {
            get { return typeOfLoan; }
            set { typeOfLoan = value; }
        }
        #endregion
    }
}
