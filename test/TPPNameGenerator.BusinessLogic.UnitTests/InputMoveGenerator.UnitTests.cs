using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic.UnitTests
{
    public class InputMoveGeneratorUnitTests
    {
        private readonly InputMoveGenerator _inputmoveGenerator;

        [Fact]
        public void Given_1RandomMove_When_GenerateRandomInput_ReturnsValidEnum()
        {
            // Act
            var result = _inputmoveGenerator.GenerateRandomInput();

            // Assert
            Assert.True(Enum.IsDefined(typeof(InputMove), result));
        }

        [Fact]
        public void Given_10RandomMoves_When_GenerateRandomInput_ReturnsRandomMoves()
        {
            // Arrange
            var listOfMoves = new List<InputMove>();

            // Act
            for (int i = 0; i < 10; i++)
            {
                listOfMoves.Add(_inputmoveGenerator.GenerateRandomInput());
            }

            // Assert
            Assert.True(listOfMoves.Distinct().Count() > 3);
        }

        public InputMoveGeneratorUnitTests()
        {
            _inputmoveGenerator = new InputMoveGenerator();
        }
    }
}
