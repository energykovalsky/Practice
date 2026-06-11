internal class Program
{
    private static void Main(string[] args)
    {
        // A 
        var source1 = new ClassWithEvent();
        source1.Announcement += (v, m) => Console.WriteLine($"Announcement: {m} with value {v}.");

        // B 
        var source2 = new ClassWithEvent();
        source2.Announcement += Notifier.Notify;

        // C 
        var source3 = new ClassWithEvent();
        source3.Announcement += new Subscriber().Report;

        //// D WRONG
        //var source4 = new ClassWithEvent();
        //source4.Announcement = (v, m) => Console.WriteLine($"Announcement: {m} with value {v}.");

        //// E WRONG
        //var source5 = new ClassWithEvent();
        //var message = "Some message.";
        //var value = 100;
        //source5.Announcement(value, $"Announcement: {message} with value {value}.");
    }

    public class ClassWithEvent
    {
        public event Action<int, string>? Announcement;
    }
    //private void OnAnnouncement(int value, string message)
    //    => Announcement?.Invoke(value, message);
    //}

    public class Notifier
    {
        public static void Notify(int value, string message)
            => Console.WriteLine($"Notification: {message} with value {value}.");
    }

    public class Subscriber
    {
        public void Report(int value, string message)
            => Console.WriteLine($"Report: {message} with value {value}.");
    }
}

