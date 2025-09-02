using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic.Interfaces
{
    /// <summary>
    /// This is responsible for generating sequences of input moves, to later create names using a virtual keyboard.
    /// </summary>
    public interface IRandomInputMoveGenerator
    {
        InputMove GenerateRandomInput();
    }
}
