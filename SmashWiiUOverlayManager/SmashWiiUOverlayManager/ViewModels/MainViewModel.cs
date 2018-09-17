using SmashWiiUOverlayManager.Models;
using System.Collections.ObjectModel;

namespace SmashWiiUOverlayManager.ViewModels
{
    public class MainViewModel
    {
        public Player[] players = new Player[2];

        public ObservableCollection<Character> CharacterList { get; private set; }
        public ObservableCollection<Port> PortList { get; private set; }
        public int currentRound;
        public int bestOf;
        private CssFile RoundBoxCss { get; set; }

        public MainViewModel()
        {
            for (int i = 0; i < players.Length; i++) { players[i] = new Player(); }
            CharacterList = Character.InitiateCharacterList();
            PortList = Port.InitiatePortList(8);
            RoundBoxCss = new CssFile("roundBoxText");
        }

        public void UpdateInformation()
        {
            for (int i = 0; i < players.Length; i++)
            {
                Player p = players[i];
                p.characterFile.Update(p.selectedCharacter.Path);
                p.nameFile.Update((string.IsNullOrEmpty(p.sponsor) ? "" : p.sponsor + " | ") + p.name);// ternary, only add pipe if sponsor is filled in
                p.portFile.Update(p.selectedPort.Path);
                p.scoreFile.Update(p.score.ToString());
            }

            RoundBoxCss.Update(currentRound + "/" + bestOf);
        }
    }
}
