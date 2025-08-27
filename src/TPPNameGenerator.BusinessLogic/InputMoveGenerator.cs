using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic
{
    /// <summary>
    /// This class is responsible for generating sequences of input moves to create names using a virtual keyboard.
    /// </summary>
    public class InputMoveGenerator
    {

        public InputMoveGenerator()
        {
        }

        //TODO might have to revisit this signature when we need to mock this for testing other classes that consume this? 
        public InputMove GenerateRandomInput()
        {
            var values = (InputMove[]) Enum.GetValues(typeof(InputMove));

            return values[Random.Shared.Next(values.Length)];
        }
    }
}
