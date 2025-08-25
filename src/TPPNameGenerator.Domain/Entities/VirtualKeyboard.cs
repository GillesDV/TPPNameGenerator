using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPNameGenerator.Domain.Entities
{
    /// <summary>
    /// A clear, consise representation of the virtual keyboard layouts used in the naming screen.
    /// </summary>
    /// <remarks
    /// Yes, this could be automatically generated, but this shorter and more readable in my opinion. 
    ///</remarks>

    public static class VirtualKeyboard
    {
        public static string[,] UppercaseKeyboardDefault =
        {
            { "A", "B", "C", "D", "E", "F", " ", ".", "SWAP" },
            { "G", "H", "I", "J", "K", "L", " ", ",", "BACK" },
            { "M", "N", "O", "P", "Q", "R", "S", " ", "BACK" },
            { "T", "U", "V", "W", "X", "Y", "Z", " ", "OK"  }  
        };

        public static string[,] LowercaseKeyboard =
        {
            { "a", "b", "c", "d", "e", "f", " ", "." , "SWAP" },
            { "g", "h", "i", "j", "k", "l", " ", "," , "BACK" },
            { "m", "n", "o", "p", "q", "r", "s", " " , "BACK" },
            { "t", "u", "v", "w", "x", "y", "z", " ", "OK" }
        };

        public static string[,] NumberSymbolKeyboard =
        {
            { "0", "1", "2", "3", "4", " " , "SWAP" },
            { "5", "6", "7", "8", "9", " " , "BACK" },
            { "!", "?", "♂", "♀", "/", "-" , "BACK" },
            { "…", "“", "”", "‘", "’", " ", "OK" }
        };
    }
}
