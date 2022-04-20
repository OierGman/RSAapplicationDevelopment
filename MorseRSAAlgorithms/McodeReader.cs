using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseRSAAlgorithms
{
    public class morseConverter
    {
        public static string textToMorse(string text, char[] letters, string[]morseLetters)
        {
            string newText = "";

            string textToChange = text.ToLower();

            for (int i = 0; i < textToChange.Length; i++)
            {
                for (short j = 0; j < 37; j++)
                {
                    if (textToChange[i] == letters[j])
                    {
                        newText += morseLetters[j];
                        newText += " ";

                        break;
                    }
                }
            }
            return newText;
        }

        public static string morseToText(string text, char[] letters, string[] morseLetters)
        {
            string textToChange = text;
            string newText = "";

            string[] morseArray = textToChange.Split(' ');

            for (int i = 0; i < morseArray.Length; i++)
            {
                for (short j = 0; j < 37; j++)
                {
                    if (morseArray[i] == morseLetters[j])
                    {
                        newText += letters[j];
                        break;
                    }
                }
            }
            return newText;
        }
    }
}
