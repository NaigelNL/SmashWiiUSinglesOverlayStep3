using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmashWiiUOverlayManager.FileManagers
{
    public class CssFileDeleter
    {
        public void DeletePlayer1CharacterFile()
        {
            var filePath = @"Files\css\player1Character.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer2CharacterFile()
        {
            var filePath = @"Files\css\player2Character.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer1NameTextFile()
        {
            var filePath = @"Files\css\player1NameText.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer2NameTextFile()
        {
            var filePath = @"Files\css\player2NameText.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer1PortFile()
        {
            var filePath = @"Files\css\player1Port.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer2PortFile()
        {
            var filePath = @"Files\css\player2Port.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer1ScoreTextFile()
        {
            var filePath = @"Files\css\player1ScoreText.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeletePlayer2ScoreTextFile()
        {
            var filePath = @"Files\css\player2ScoreText.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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

        public void DeleteRoundBoxTextFile()
        {
            var filePath = @"Files\css\roundBoxText.css";
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
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
