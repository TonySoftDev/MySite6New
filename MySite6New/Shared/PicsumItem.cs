namespace MySite6New.Shared
{
    public class PicsumItem
    {
        public int Id { get; set; }
        public string Author { get; set; } = string.Empty;
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Download_url { get; set; } = string.Empty;
    }
}
