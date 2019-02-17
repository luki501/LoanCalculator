using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LoanCalculatorWPF.Model;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoanCalculatorWPF.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region fields
        private ILoanGateway gateway = null;
        private APaybackPlan plan;
        private decimal amount;
        private LoanType typeOfLoan;
        private int numberOfYears;
        private int maxNumbersOfYears;
        private decimal maxAmount;
        private DateTime dateStart;
        private LoanType selectedLoanType;
        private ILog log;
        #endregion

        #region properties
        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value > MaxAmount ? MaxAmount : value;
                if (amount < 0)
                    amount = 0;
                RaisePropertyChanged(() => Amount);
            }
        }
        public LoanType TypeOfLoan
        {
            get { return typeOfLoan; }
            set { typeOfLoan = value; }
        }
        public int NumberOfYears
        {
            get { return numberOfYears; }
            set
            {
                numberOfYears = value > MaxNumberOfYears ? MaxNumberOfYears : value;
                if (numberOfYears < 1)
                    numberOfYears = 1;
                RaisePropertyChanged(() => NumberOfYears);
            }
        }
        public int MaxNumberOfYears
        {
            get { return maxNumbersOfYears; }
            set { maxNumbersOfYears = value; RaisePropertyChanged(() => MaxNumberOfYears); }
        }
        public decimal MaxAmount
        {
            get { return maxAmount; }
            set { maxAmount = value; RaisePropertyChanged(() => MaxAmount); }
        }
        public LoanType SelectedLoanTypes
        {
            get { return selectedLoanType; }
            set { selectedLoanType = value; SetProperties(); }
        }
        public APaybackPlan Plan
        {
            get { return plan; }
            set { plan = value; RefreshDataPlan(); }
        }

        public DateTime DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        public List<LoanType> ListOfTypesOfLoan
        {
            get { return Enum.GetValues(typeof(LoanType)).Cast<LoanType>().ToList(); }
        }
        public bool IsPlanVisible
        {
            get { return plan != null; }
        }
        public string InterestsPercentage
        {
            get { return Plan != null ? string.Format("{0}%", Plan.Interests * 100) : null; }

        }
        public decimal SumOfInterests
        {
            get { return Plan != null ? Plan.Installments.Sum(i => i.AmountOfInterest) : 0; }
        }
        #endregion

        #region constructors
        public MainViewModel()
        {
            log = LogManager.GetLogger("LogFileAppender");
            SelectedLoanTypes = ListOfTypesOfLoan.FirstOrDefault();
            NumberOfYears = MaxNumberOfYears;
            Amount = 100000;
        }
        #endregion

        #region commands
        private RelayCommand applyCommand;

        public RelayCommand ApplyCommand
        {
            get
            {
                if (applyCommand == null)
                    applyCommand = new RelayCommand(ApplyProposal, () => { return Amount > 0; });
                return applyCommand;
            }
        }
        #endregion

        #region methods
        private void ApplyProposal()
        {
            try
            {
                if (Amount <= 0)
                {
                    Plan = null;
                    return;
                }
                Proposal proposal = new Proposal()
                {
                    Amount = this.Amount,
                    NumberOfYears = this.NumberOfYears,
                    TypeOfLoan = SelectedLoanTypes
                };
                LoanGatewayFactory factory = new LoanGatewayFactory();
                gateway = factory.CreateLoanGateway(proposal.TypeOfLoan);
                Plan = gateway.GetPlan(proposal);                
            }
            catch (Exception ex) { log.Error(ex); throw ex; }
        }

        private void SetProperties()
        {
            try
            {                
                LoanGatewayFactory factory = new LoanGatewayFactory();
                gateway = factory.CreateLoanGateway(SelectedLoanTypes);
                MaxAmount = gateway.MaxAmount;
                MaxNumberOfYears = gateway.MaxNumberOfYears;
                if (NumberOfYears > MaxNumberOfYears)
                    NumberOfYears = MaxNumberOfYears;
            }
            catch (Exception ex) { log.Error(ex); throw ex; }
        }
        private void RefreshDataPlan()
        {
            RaisePropertyChanged(() => Plan);
            RaisePropertyChanged(() => IsPlanVisible);
            RaisePropertyChanged(() => InterestsPercentage);
            RaisePropertyChanged(() => SumOfInterests);
        }
        #endregion
    }
}