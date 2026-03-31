internal class Program
{
    private static void Main(string[] args)
    {
        //A 
        Console.WriteLine("A");
        var source1 = new ClassWithEvent();
        var reporter1 = new Reporter();
        source1.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
        source1.Announcement += reporter1.Report;
        source1.EventEmulation(10, "Count");
        source1.Announcement -= reporter1.Report;
        source1.EventEmulation(5, "Sum");

        //B 
        Console.WriteLine("B");
        var source2 = new ClassWithEvent();
        var reporter2 = new Reporter();
        source2.EventEmulation(10, "Count");
        source2.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
        source2.Announcement += reporter2.Report;
        source2.Announcement -= reporter2.Report;
        source2.EventEmulation(5, "Sum");

        //C 
        Console.WriteLine("C");
        var source3 = new ClassWithEvent();
        var reporter3 = new Reporter();
        source3.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
        source3.Announcement += reporter3.Report;
        source3.EventEmulation(10, "Count");
        source3.Announcement -= reporter3.Report;
        source3.Announcement -= (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
        source3.EventEmulation(5, "Sum");

        //D 
        Console.WriteLine("D");
        var source4 = new ClassWithEvent();
        var reporter4 = new Reporter();
        source4.Announcement += reporter4.Report;
        source4.Announcement += (o, e) => Console.WriteLine($"Announcement: {e.Message} with value {e.Value}.");
        source4.Announcement -= reporter4.Report;
        source4.EventEmulation(10, "Count");
        source4.EventEmulation(5, "Sum");
    }

    public sealed class ClassWithEvent
    {
        public EventHandler<AnnouncementEventArgs>? Announcement;

        public void EventEmulation(int value, string message)
        {
            OnAnnouncement(new AnnouncementEventArgs(value, message));
        }

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

    public class Reporter
    {
        public void Report(object? sender, AnnouncementEventArgs? eventArgs)
            => Console.WriteLine($"Report: {eventArgs?.Message} with value {eventArgs?.Value}.");
    }
}