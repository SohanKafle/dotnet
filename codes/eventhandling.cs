using System;
public class EventPublisher
{
    public event EventHandler<string> MyEvent;

    public void TriggerEvent(string message) => OnMyEvent(message);

    protected virtual void OnMyEvent(string message) => MyEvent?.Invoke(this, message);
}
public class EventSubscriber
{
    public void HandleEvent(object sender, string message) => Console.WriteLine($"Event received: {message}");
}
public class Program
{
    public static void Main()
    {
        EventPublisher publisher = new EventPublisher();
        EventSubscriber subscriber = new EventSubscriber();

        publisher.MyEvent += subscriber.HandleEvent;
        publisher.TriggerEvent("Hello, Sohan!");
        publisher.MyEvent -= subscriber.HandleEvent; // Unsubscribe
        publisher.TriggerEvent("Event without subscriber");
    }
}
