namespace BalanceMate.DataAccess.Models.Incomes
{
    public class Income
    {
        public Guid Id { get; private set; }

        public string Source { get; private set; }

        public double Amount { get; private set; }

        public string Type { get; private set; }

        public DateTimeOffset CreatedWhen { get; private set; }

        public DateTimeOffset LastModifiedWhen { get; private set; }

        public Income(string source, double amount, string type)
        {
            Id = Guid.NewGuid();
            Source = source;
            Amount = amount;
            Type = type;
            CreatedWhen = DateTimeOffset.UtcNow;
            LastModifiedWhen = DateTimeOffset.UtcNow;
        }
    }
}
