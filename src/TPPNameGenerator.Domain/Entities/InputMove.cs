using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPPNameGenerator.Domain.Entities
{
    public enum InputMove
    {
        A, // Select letter
        B, // remove last letter

        Up,
        Down,
        Left,
        Right,

        Start, // End naming-process & finalize current selection
        Select // Swap keyboards
    }
}
