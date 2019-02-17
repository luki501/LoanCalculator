using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorWPF.Model.Loans
{
    public class HousingLoan : ALoan
    {
        #region const
        const decimal MAX_AMOUNT = 2000000;
        const int MAX_NUMBER_OF_YEARS = 40;
        const decimal INTERESTS = 0.035M;
        const string NAME = "House loan";
        #endregion

        #region properties
        public override string Name { get { return NAME; } }
        public override decimal MaxAmount { get { return MAX_AMOUNT; } }
        public override int MaxNumberOfYears { get { return MAX_NUMBER_OF_YEARS; } }
        public override decimal Interests { get { return INTERESTS; } }
        #endregion

        #region constructors  
        public HousingLoan() { }
        #endregion

        #region abstract methods
        public override APaybackPlan GetPlan(Proposal proposal)
        {
            return new LoanPayback(Name, proposal.Amount, proposal.NumberOfYears, Interests);
        }
        #endregion
    }
}
