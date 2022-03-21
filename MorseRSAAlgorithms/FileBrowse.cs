using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MorseRSAAlgorithms
{
    public class FileBrowse
    {
        public static string fileImport()
        {
            string filePath;
            string fileExtention;
            OpenFileDialog openFile = new OpenFileDialog();
            string errorMessage = "!! NOT SUPPORTED FILE FORMAT !!";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                filePath = openFile.FileName;
                fileExtention = Path.GetExtension(filePath);
                if (fileExtention.CompareTo(".txt") == 0)
                {
                    try
                    {
                        StreamReader reader = new StreamReader(filePath);
                        StringBuilder builder = new StringBuilder();
                        string line = "";

                        while ((line = reader.ReadLine()) != null)
                        {
                            builder.AppendLine(line);
                        }
                        reader.Close();
                        return builder.ToString();
                    }
                    catch { }
                }
            }
            return errorMessage;
        }
    }
}
