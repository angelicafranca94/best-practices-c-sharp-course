namespace Avanade.BestPractices.Domain.QueryContext
{
    public abstract class AccountQueryContext
    {
        public enum GetById
        {
            StartRideValidation = 1,
            Details
        }

        public enum GetAll
        {
            // não foi utilizado
        }
    }
}
