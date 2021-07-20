namespace rpg{
    public class Local
    {
        public string Title = "";
        public string Description = "";
        public bool Visited = false;
        public Local North = null;
        public Local East = null;
        public Local West = null;
        public Local South = null;

        public Local(string fromTitle)
        {
            Title = fromTitle;
        }
    }
}