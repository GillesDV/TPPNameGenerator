using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPNameGenerator.Domain.Entities
{
    public enum InputMoves
    {
        A, //Select letter
        B, // remove last letter

        Up,
        Down,
        Left,
        Right,

        Start, // go to End button
        Select //Swap keyboards
    }
}
