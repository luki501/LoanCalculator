namespace LoanCalculatorWPF.Model
{
    public interface ILoanGateway
    {
        string Name { get; }
        decimal MaxAmount { get; } 
        int MaxNumberOfYears { get; }
        decimal Interests { get; }

        APaybackPlan GetPlan(Proposal proposal);
        

    }
}
