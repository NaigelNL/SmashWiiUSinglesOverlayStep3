using System.Collections.ObjectModel;

namespace SmashWiiUOverlayManager.Models
{
    public class Character
    {
        public string Name { get; private set; }
        public string Path { get; private set; }

        public Character(string name, string fileName)
        {
            Name = name;
            Path = string.Format(@"..\\characterIcons\\{0}.png", fileName);
        }

        public static ObservableCollection<Character> InitiateCharacterList()
        {
            return new ObservableCollection<Character>
            {
                new Character("Bayonetta", "bayonetta"),
                new Character("Bowser", "bowser"),
                new Character("Bowser. Jr", "bowserjr"),
                new Character("Captain Falcon", "captainfalcon"),
                new Character("Charizard", "charizard"),
                new Character("Cloud", "cloud"),
                new Character("Corrin", "corrin"),
                new Character("Dark Pit", "darkpit"),
                new Character("Diddy Kong", "diddykong"),
                new Character("Donkey Kong", "donkeykong"),
                new Character("Dr. Mario", "drmario"),
                new Character("Duck Hunt", "duckhunt"),
                new Character("Falco", "falco"),
                new Character("Fox", "fox"),
                new Character("Ganondorf", "ganondorf"),
                new Character("Greninja", "greninja"),
                new Character("Ike", "ike"),
                new Character("Jigglypuff", "jigglypuff"),
                new Character("King Dedede", "kingdedede"),
                new Character("Kirby", "kirby"),
                new Character("Link", "link"),
                new Character("Little Mac", "littlemac"),
                new Character("Lucario", "lucario"),
                new Character("Lucas", "lucas"),
                new Character("Lucina", "lucina"),
                new Character("Luigi", "luigi"),
                new Character("Mario", "mario"),
                new Character("Marth", "marth"),
                new Character("Mega Man", "megaman"),
                new Character("Meta Knight", "metaknight"),
                new Character("Mewtwo", "mewtwo"),
                new Character("Mii Brawler", "miigunner"),
                new Character("Mii Swordfighter", "miiswordfighter"),
                new Character("Mr. Game & Watch", "mrgamewatch"),
                new Character("Ness", "ness"),
                new Character("Olimar", "olimar"),
                new Character("Pac-Man", "pacman"),
                new Character("Palutena", "palutena"),
                new Character("Peach", "peach"),
                new Character("Pikachu", "pikachu"),
                new Character("Pit", "pit"),
                new Character("Random", "random"),
                new Character("R.O.B", "rob"),
                new Character("Robin", "robin"),
                new Character("Rosalina & Luma", "rosalina"),
                new Character("Roy", "roy"),
                new Character("Ryu", "ryu"),
                new Character("Samus", "samus"),
                new Character("Sheik", "sheik"),
                new Character("Shulk", "shulk"),
                new Character("Sonic", "sonic"),
                new Character("Toon Link", "toonlink"),
                new Character("Villager", "villager"),
                new Character("Wario", "wario"),
                new Character("Wii Fit Trainer", "wiifittrainer"),
                new Character("Yoshi", "yoshi"),
                new Character("Zelda", "zelda"),
                new Character("Zero Suit Samus", "zerosuitsamus")
            };
        }
    }
}