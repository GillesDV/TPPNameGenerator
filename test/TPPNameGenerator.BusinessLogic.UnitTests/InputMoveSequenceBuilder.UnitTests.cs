using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPPNameGenerator.BusinessLogic.Interfaces;
using TPPNameGenerator.Domain.Entities;

namespace TPPNameGenerator.BusinessLogic.UnitTests
{
    public class InputMoveSequenceBuilderUnitTests
    {
        private readonly InputMoveSequenceBuilder _builder;

        private readonly Mock<IRandomInputMoveGenerator> _mockRandomInputMoveGenerator;

        [Fact]
        public void Given_FirstArgumentIsStart_When_BuildInputMoveList_Then_ReturnListWith1Entry()
        {
            // Arrange
            var expectedMoves = new List<InputMove> { InputMove.Start };
            _mockRandomInputMoveGenerator.SetupSequence(m => m.GenerateRandomInput())
                .Returns(InputMove.Start);

            // Act
            var result = _builder.BuildInputMoveList();

            // Assert
            Assert.Equal(expectedMoves, result);
            _mockRandomInputMoveGenerator.Verify(m => m.GenerateRandomInput(), Times.Once);
            Assert.Single(result);
        }

        [Fact]
        public void Given_ListEndsWithStart_When_BuildInputMoveList_ReturnsListWithStart()
        {
            // Arrange
            var expectedMoves = new List<InputMove> { InputMove.Right, InputMove.Down, InputMove.A, InputMove.Start };
            _mockRandomInputMoveGenerator.SetupSequence(m => m.GenerateRandomInput())
                .Returns(InputMove.Right)
                .Returns(InputMove.Down)
                .Returns(InputMove.A)
                .Returns(InputMove.Start);

            // Act
            var result = _builder.BuildInputMoveList();

            // Assert
            Assert.Equal(expectedMoves, result);
            _mockRandomInputMoveGenerator.Verify(m => m.GenerateRandomInput(), Times.Exactly(4));
            Assert.True(result.Last() == InputMove.Start);
        }


        public InputMoveSequenceBuilderUnitTests()
        {
            _mockRandomInputMoveGenerator = new Mock<IRandomInputMoveGenerator>(MockBehavior.Strict);

            _builder = new InputMoveSequenceBuilder(_mockRandomInputMoveGenerator.Object);
        }
    }
}
