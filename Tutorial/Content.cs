namespace Tutorial
{
    internal class Content
    {
        public string ImagePath { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }

        public Content(string imagePath, string header, string text)
        {
            ImagePath = imagePath;
            Header = header;
            Text = text;
        }
    }
}