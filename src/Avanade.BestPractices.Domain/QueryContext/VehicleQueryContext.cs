namespace Avanade.BestPractices.Domain.QueryContext
{
    public abstract class VehicleQueryContext
    {
        public enum GetById
        {
            StartRideValidation = 1,
            SetIsAvailable
        }

        public enum GetAll
        {

        }
    }
}
