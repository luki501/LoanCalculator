using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorWPF.Model.Loans
{
    public abstract class ALoan : ILoanGateway
    {
        public abstract string Name { get; }
        public abstract decimal MaxAmount { get; }
        public abstract int MaxNumberOfYears { get; }
        public abstract decimal Interests { get; }

        public abstract APaybackPlan GetPlan(Proposal proposal);
                
    }
}
