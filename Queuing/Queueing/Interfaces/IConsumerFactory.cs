namespace Queueing.Interfaces
{
    /// <summary>
    /// Provides method for creating a consumer
    /// </summary>
    public interface IConsumerFactory
    {
        IConsumer Create(string consumerCode);
    }
}
