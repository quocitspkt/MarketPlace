namespace MarketPlace.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        //True if domain Entity has an identity
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}