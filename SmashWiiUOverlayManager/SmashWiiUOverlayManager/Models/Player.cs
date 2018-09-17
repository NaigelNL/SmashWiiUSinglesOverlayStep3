namespace SmashWiiUOverlayManager.Models
{
    public class Player
    {
        private static int currentId = 1;
        public int id { get; private set; }

        public string name = "";
        public string sponsor = "";
        public string twitter = "";
        public int score;

        public Character selectedCharacter;
        public Port selectedPort;
        public CssFile characterFile { get; private set; }
        public CssFile nameFile { get; private set; }
        public CssFile portFile { get; private set; }
        public CssFile scoreFile { get; private set; }

        public Player()
        {
            this.id = currentId;
            currentId++;
            string idString = id.ToString();

            characterFile = new CssFile(string.Format("player{0}Character", idString));
            nameFile = new CssFile(string.Format("player{0}NameText", idString));
            portFile = new CssFile(string.Format("player{0}Port", idString));
            scoreFile = new CssFile(string.Format("player{0}ScoreText", idString));
        }
    }
}