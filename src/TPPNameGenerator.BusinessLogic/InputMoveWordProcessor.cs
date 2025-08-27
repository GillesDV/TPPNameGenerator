using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic
{
    public class InputMoveWordProcessor //TODO add interface
    {

        /// <summary>
        /// Writes out the word that was created via <see cref="VirtualKeyboard"/> based on the input moves provided.
        /// </summary>
        /// <param name="inputMoves">The list of input that was performed (eg: A, Right, Down, ... ) </param>
        /// <returns>The fully formed word that was created via <see cref="VirtualKeyboard"/> </returns>
        public string GenerateWord(List<InputMove> inputMoves)
        {

            throw new NotImplementedException();
        }
    }
}
    