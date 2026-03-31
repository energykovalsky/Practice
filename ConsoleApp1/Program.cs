internal class Program
{
    private static void Main(string[] args)
    {
        // A 
        var source1 = new ClassWithEvent();
        source1.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");

        //// B WRONG 
        //var source2 = new ClassWithEvent();
        //source2.Announcement += Notifier.Notify;

        // C 
        var source3 = new ClassWithEvent();
        source3.Announcement += new Subscriber().Report;

        //// D WRONG
        //var source4 = new ClassWithEvent();
        //source4.Announcement = (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");

        //// E WRONG
        //var source5 = new ClassWithEvent();
        //var message = "Some message.";
        //var value = 100;
        //source5.Announcement(value, $"Announcement: {message} with value {value}.");
    }

    public sealed class ClassWithEvent
    {
        public event EventHandler<AnnouncementEventArgs>? Announcement;  
    … 
    private void OnAnnouncement(AnnouncementEventArgs eventArgs)
        => Announcement?.Invoke(this, eventArgs);
    }

    public class AnnouncementEventArgs : EventArgs
    {
        public AnnouncementEventArgs(int value, string message)
            => (this.Value, this.Message) = (value, message);

        public int Value { get; set; }

        public string Message { get; set; }
    }

    public class Notifier
    {
        public static void Notify(int value, string message)
            => Console.WriteLine($"Notification: {message} with value {value}.");
    }

    public class Subscriber
    {
        public void Report(object? sender, AnnouncementEventArgs? eventArgs)
            => Console.WriteLine($"Report: {eventArgs?.Message} with value {eventArgs?.Value}.");
    }
}