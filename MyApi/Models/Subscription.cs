namespace MyApi.Models
{
    public class Subscription
    {
        public Guid SubID { get; set; }
        public string SubName { get; set; } = string.Empty;
        public string? SubURL { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public DateOnly RecurringDate { get; set; }
        public double Price { get; set; }
        public string? Notes { get; set; }


        public Subscription()
        {
            DateAdded = DateTime.Now;
        }

    }

    class SubscriptionDB : DbContext
    {
        public SubscriptionDB(DbContextOptions<SubscriptionDB> options) : base(options) { }

        public DbSet<Subscription> Subscriptions => Set<Subscription>();
    }
}
