namespace STP.Data
{
    public class DbInitializer
    {
        public static void Initialize(STPContext context)
        {
            context.Database.EnsureCreated();
            context.SaveChanges();
        }
    }
}
