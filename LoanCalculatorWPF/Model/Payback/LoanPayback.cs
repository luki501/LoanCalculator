using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoanCalculatorWPF.Model
{
    public class LoanPayback : APaybackPlan
    {
        #region properties
        ILog log = LogManager.GetLogger("LogFileAppender");
        #endregion

        #region constructors
        public LoanPayback(string name, decimal amount, int numberOfYears, decimal interests)
        {
            Name = name;
            Interests = interests;
            CreatePaybackPlan(amount, numberOfYears);
        }
        #endregion

        #region methods
        public override void CreatePaybackPlan(decimal amount, int numberOfYears)
        {
            try
            {
                Installments = new List<Installment>();
                int numberOfMonths = numberOfYears * 12;
                decimal monthlyAmount = Math.Round(amount / numberOfMonths, 2);
                decimal difference = amount - (monthlyAmount * numberOfMonths);
                DateTime startDate = DateTime.Now.Date;                
                for (int i = 0; i < numberOfMonths; i++)
                {
                    Installment ins = new Installment()
                    {
                        Number = i + 1,
                        PaymentDeadline = startDate.AddMonths(i + 1),
                        BaseAmount = monthlyAmount,
                        AmountOfInterest = CalculateInterests(amount, startDate.AddMonths(i))
                    };
                    amount -= monthlyAmount;
                    Installments.Add(ins);
                }
                // Do ostatniej raty dodajemy kwotę różnicy wynikającą z zaokrągleń
                Installments.Last().BaseAmount += difference;
            }
            catch(Exception ex) { log.Error(ex); throw ex; }
        }

        private decimal CalculateInterests(decimal amount, DateTime startDate)
        {
            try
            {
                //decimal monthlyInterests = Interests * ((decimal)(startDate.AddMonths(1) - startDate).TotalDays / 365M); // liczone z dokładnością co do dnia
                decimal monthlyInterests = Interests * (1M / 12M); // liczone z dokładnością do miesiąca
                return Math.Round(amount * monthlyInterests, 2);
            }
            catch (Exception ex) { log.Error(ex); throw ex; }
        }
        #endregion
    }
}
