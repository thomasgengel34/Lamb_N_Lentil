using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lamb_N_Lentil.Tests.Views
{
    public class BaseViewTests
    {
        protected string fileContents;
        protected string[] lines;
        protected string[] linesCompressed;
        protected string applicationName = "Lamb 'N' Lentil";

        internal void HaveCorrectText(string text)
        {
            HaveCorrectText(  text, text);
        }

        internal void HaveCorrectText(string lineBeginning, string textOfInterest, int lineNumber = -1)
        {
            lineBeginning = CompressString(lineBeginning);
            bool titleHasName = false;
            int i = 0;
            foreach (string line in linesCompressed)
            {
                if (line.Contains(lineBeginning))
                {
                 //    textOfInterest = "Look up ingredients on :<a href=\"https://ndb.nal.usda.gov/ndb\" target=\"_blank\">the USDA nutritional site</a>";
                    if (lines[i].Contains(textOfInterest))
                    {
                        titleHasName = true;
                    }
                }
                i++;
            }
            Assert.IsTrue(titleHasName);
        }

        internal void ObtainFileAsString(string path)
        {
            StreamReader reader = File.OpenText(path);
            fileContents = reader.ReadToEnd();
            reader.Close();
            lines = fileContents.Split('\r');
            string fileContentsCompressed = CompressString(fileContents);
            linesCompressed = fileContentsCompressed.Split('\r');
        }

        internal string CompressString(string toBeCompressed) => Regex.Replace(toBeCompressed, " ", "");
    }
}
