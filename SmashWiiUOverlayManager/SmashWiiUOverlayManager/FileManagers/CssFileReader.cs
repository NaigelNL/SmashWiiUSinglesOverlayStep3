using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashWiiUOverlayManager.FileManagers
{
    public class CssFileReader
    {
        public string ReadPlayer1CharacterTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player1Character.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer2CharacterTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player2Character.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer1NameTextTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player1NameText.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer2NameTextTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player2NameText.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer1PortTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player1Port.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer2PortTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player2Port.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer1ScoreTextTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player1ScoreText.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadPlayer2ScoreTextTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\player2ScoreText.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReadRoundBoxTextTemplateFile()
        {
            try
            {
                var filePath = @"Files\cssTemplates\roundBoxText.css";
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException("File with path not found: " + filePath);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
