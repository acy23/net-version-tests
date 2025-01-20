namespace net8minimal.Models
{
    public class Province
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public List<District> Districts { get; set; }
    }

    public class District
    {
        public int Value { get; set; }
        public string Text { get; set; }
    }
}
