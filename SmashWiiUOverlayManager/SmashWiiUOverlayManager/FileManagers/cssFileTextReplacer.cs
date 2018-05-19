using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashWiiUOverlayManager.FileManagers
{
    public class CssFileTextReplacer
    {
        public string ReplacePlayer1CharacterTemplateFileText(string player1CharacterTemplateCss, string player1SelectedCharacterPath)
        {
            try
            {
                return player1CharacterTemplateCss.Replace("PLACEHOLDER", player1SelectedCharacterPath);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer2CharacterTemplateFileText(string player2CharacterTemplateCss, string player2SelectedCharacterPath)
        {
            try
            {
                return player2CharacterTemplateCss.Replace("PLACEHOLDER", player2SelectedCharacterPath);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer1NameTextTemplateFileText(string player1NameTextCss, string player1Sponsor, string player1Name)
        {
            try
            {
                if (string.IsNullOrEmpty(player1Sponsor))
                {
                    return player1NameTextCss = player1NameTextCss.Replace("PLACEHOLDER", player1Name);
                }
                else
                {
                    return player1NameTextCss = player1NameTextCss.Replace("PLACEHOLDER", player1Sponsor + " | " + player1Name);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer2NameTextTemplateFileText(string player1NameTextCss, string player2Sponsor, string player2Name)
        {
            try
            {
                if (string.IsNullOrEmpty(player2Sponsor))
                {
                    return player1NameTextCss = player1NameTextCss.Replace("PLACEHOLDER", player2Name);
                }
                else
                {
                    return player1NameTextCss = player1NameTextCss.Replace("PLACEHOLDER", player2Sponsor + " | " + player2Name);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer1PortTemplateFileText(string player1PortTemplateCssText, string player1SelectedPortPath)
        {
            try
            {
                return player1PortTemplateCssText.Replace("PLACEHOLDER", player1SelectedPortPath);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer2PortTemplateFileText(string player2PortTemplateCssText, string player2SelectedPortPath)
        {
            try
            {
                return player2PortTemplateCssText.Replace("PLACEHOLDER", player2SelectedPortPath);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer1ScoreTextTemplateFileText(string player1ScoreTextTemplateCss, string player1Score)
        {
            try
            {
                return player1ScoreTextTemplateCss.Replace("PLACEHOLDER", player1Score);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplacePlayer2ScoreTextTemplateFileText(string player2ScoreTextTemplateCss, string player2Score)
        {
            try
            {
                return player2ScoreTextTemplateCss.Replace("PLACEHOLDER", player2Score);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplaceRoundBoxTextTemplateFileText(string roundBoxTextTemplateCss, string round)
        {
            try
            {
                return roundBoxTextTemplateCss.Replace("PLACEHOLDER", round);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
