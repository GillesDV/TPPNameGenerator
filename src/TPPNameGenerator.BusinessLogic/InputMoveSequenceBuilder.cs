using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.BusinessLogic.Interfaces;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic
{
    public class InputMoveSequenceBuilder //TODO add interface
    {
        private readonly IRandomInputMoveGenerator _inputMoveGenerator;

        public InputMoveSequenceBuilder(IRandomInputMoveGenerator inputMoveGenerator)
        {
            _inputMoveGenerator = inputMoveGenerator;
        }

        public List<InputMove> BuildInputMoveList()
        {
            List<InputMove> inputMoves = new();

            do
            {
                InputMove newInput = _inputMoveGenerator.GenerateRandomInput();
                inputMoves.Add(newInput);
            } while (inputMoves.Last() != InputMove.Start);

            return inputMoves;
        }

    }
}
