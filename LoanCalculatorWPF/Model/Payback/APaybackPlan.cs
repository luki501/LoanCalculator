using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculatorWPF.Model
{
    public abstract class APaybackPlan
    {
        #region properties
        public string Name { get; set; }
        public List<Installment> Installments { get; set; }
        public decimal Interests { get; set; }
        #endregion

        #region constructors
        public APaybackPlan()
        {

        }
        #endregion

        #region abstract methods
        public abstract void CreatePaybackPlan(decimal amount, int numberOfYears);
        #endregion
    }
}
