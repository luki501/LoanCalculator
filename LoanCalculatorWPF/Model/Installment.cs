using System;

namespace LoanCalculatorWPF.Model
{
    public class Installment
    {
        #region properties
        private int number;
        private DateTime paymentDeadline;
        private decimal baseAmount;
        private decimal amountOfInterest;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public DateTime PaymentDeadline
        {
            get { return paymentDeadline; }
            set { paymentDeadline = value; }
        }
        public decimal BaseAmount
        {
            get { return baseAmount; }
            set { baseAmount = value; }
        }
        public decimal AmountOfInterest
        {
            get { return amountOfInterest; }
            set { amountOfInterest = value; }
        }
        public decimal Amount
        {
            get { return BaseAmount + AmountOfInterest; }
        }
        public int PercentageBaseAmount
        {
            get { if (Amount > 0) return (int)(BaseAmount / Amount * 100); else return 0; }            
        }        
        #endregion


    }
}
