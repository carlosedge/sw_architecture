using System;

namespace NotficationService
{
    public interface INotificationService<T> 
    {
        public void Notify(T message);
    }
}
