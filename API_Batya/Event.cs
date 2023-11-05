namespace API_Batya
{
    public class Event
    {
        private static int id { get; set; } = 0;
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime End { get; set; } = DateTime.Now;
        public Event(string title, DateTime start, DateTime end)
        {
            Id = ++id;
            Title = title;
            Start = start;
            End = end;
        }
    }
}
