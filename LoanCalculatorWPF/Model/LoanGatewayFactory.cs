using LoanCalculatorWPF.Model.Loans;

namespace LoanCalculatorWPF.Model
{
    public class LoanGatewayFactory
    {

        public virtual ILoanGateway CreateLoanGateway(LoanType type)
        {
            ILoanGateway gateway = null;
            switch (type)
            {
                case LoanType.Car:
                    gateway = new CarLoan();
                    break;
                case LoanType.House:
                    gateway = new HousingLoan();
                    break;
                default: break;
            }
            return gateway;
        }
    }
}
