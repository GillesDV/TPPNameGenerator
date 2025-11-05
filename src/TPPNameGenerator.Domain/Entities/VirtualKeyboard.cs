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
    /// Yes, this could be automatically generated, but this is shorter and more readable in my opinion. 
    ///</remarks>

    public static class VirtualKeyboard
    {
        public static string[,] UppercaseKeyboardDefault =
        {
            { "A", "B", "C", "D", "E", "F", " ", "." },
            { "G", "H", "I", "J", "K", "L", " ", "," },
            { "M", "N", "O", "P", "Q", "R", "S", " " },
            { "T", "U", "V", "W", "X", "Y", "Z", " " }  
        };

        public static string[,] LowercaseKeyboard =
        {
            { "a", "b", "c", "d", "e", "f", " ", "." },
            { "g", "h", "i", "j", "k", "l", " ", "," },
            { "m", "n", "o", "p", "q", "r", "s", " " },
            { "t", "u", "v", "w", "x", "y", "z", " " }
        };

        public static string[,] NumberSymbolKeyboard =
        {
            { "0", "1", "2", "3", "4", " " },
            { "5", "6", "7", "8", "9", " " },
            { "!", "?", "♂", "♀", "/", "-" },
            { "…", "“", "”", "‘", "’", " " }
        };
    }
}
