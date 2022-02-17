using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseRSAAlgorithms
{
    public class morseConverter
    {
        public static string textToMorse(string text)
        {
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            string[] morseLetters = { "/", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...",
                "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };

            string textToChange = text;
            string newText = "";

            textToChange = textToChange.ToLower();

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
    }
}
