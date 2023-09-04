namespace modDisplay
{
    public class FileTemplate
    {
        public bool Exists { get; set; }
        public int Id { get; set; }
        public string Release { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string[] Group { get; set; }
        public string Note { get; set; }
        public Dictionary<string, ISheet> Tabs { get; set; }
    }
}
