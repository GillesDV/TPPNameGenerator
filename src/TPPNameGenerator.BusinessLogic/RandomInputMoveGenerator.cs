using TPPNameGenerator.BusinessLogic.Interfaces;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic
{
    public class RandomInputMoveGenerator : IRandomInputMoveGenerator
    {

        public RandomInputMoveGenerator()
        {
        }

        public InputMove GenerateRandomInput()
        {
            var values = (InputMove[]) Enum.GetValues(typeof(InputMove));

            return values[Random.Shared.Next(values.Length)];
        }
    }
}
