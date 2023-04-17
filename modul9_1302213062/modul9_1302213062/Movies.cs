namespace modul9_1302213062
{
    public class Movies
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movies() { Stars = new List<string>(); }
    }
}
