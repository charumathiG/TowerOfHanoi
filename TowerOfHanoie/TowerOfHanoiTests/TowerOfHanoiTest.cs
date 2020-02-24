using Microsoft.VisualStudio.TestTools.UnitTesting;
using TowerOfHanoie.Command;
using TowerOfHanoie.Interfaces;
using Moq;
using System.Text;
using System;

namespace TowerOfHanoiTests
{
    [TestClass]
    public class TowerOfHanoiTest
    {
        private ITowerOfHanoie towerOfHanoi;

        [TestMethod]
        public void TowerOfHanoi_Constructor_Test()
        {
            // Arrange & Act
            this.towerOfHanoi = new TowerOfHanoieCommand();

            // Assert
            Assert.IsNotNull(this.towerOfHanoi);
        }

        [TestMethod]
        public void TowerOfHanoi_Test()
        {
            //Arrange
            int expectedValue = 7;
            int Value = 3;

            // Act
            this.towerOfHanoi = new TowerOfHanoieCommand();
            this.towerOfHanoi.SolveTowerOfHanoi(Value, 'A', 'B', 'C');

            // Assert
            Assert.AreEqual(expectedValue, this.towerOfHanoi.TotalNumOfMoves);
        }
    }
}
