namespace medilog.API.Modals
{
    public class Class
    {
        [Key]
        public Guid id { get; set; }

        public string name { get; set; }

        public string role { get; set; }

        public string access { get; set; }
    }
}
