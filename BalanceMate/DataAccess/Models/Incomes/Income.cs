namespace BalanceMate.DataAccess.Models.Incomes
{
    public class Income
    {
        public Guid Id { get; private set; }

        public string Source { get; private set; }

        public double Amount { get; private set; }

        public Income(string source, double amount)
        {
            Id = Guid.NewGuid();
            Source = source;
            Amount = amount;
        }
    }
}
