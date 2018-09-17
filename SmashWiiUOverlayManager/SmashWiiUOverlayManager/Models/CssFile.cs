using System;
using System.IO;

namespace SmashWiiUOverlayManager.Models
{
    public class CssFile
    {
        public string Path { get; private set; }
        public string TemplatePath { get; private set; }

        private string Read()
        {
            try
            {
                return File.ReadAllText(TemplatePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Write(string content)
        {
            try
            {
                File.WriteAllText(Path, content);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Reads, replaces and writes css contents.
        /// </summary>
        /// <param name="content">The text to write</param>
        public void Update(string content)
        {
            var template = Read();
            var replacedTemplate = template.Replace("PLACEHOLDER", content);
            Write(replacedTemplate);
        }

        public CssFile(string name)
        {
            Path = string.Format(@"Files\css\{0}.css", name);
            TemplatePath = string.Format(@"Files\cssTemplates\{0}.css", name);
        }
    }
}