using System;
using Xunit;
using Application253E05;

namespace Application.UnitTest
   {
    public class UnitTestTrapecio
    {
        [Theory]
        [InlineData(3, 4, 5, 15)]
        [InlineData(5, 6, 7, 23)]
        [InlineData(2, 3, 4, 11)]
        [InlineData(4, 5, 6, 19)]
        [InlineData(1, 2, 3, 7)]
        [InlineData(6, 7, 8, 27)]
        [InlineData(3, 3, 3, 12)]
        [InlineData(2, 4, 6, 14)]
        [InlineData(5, 5, 5, 20)]
        [InlineData(4, 6, 8, 22)]
        public void TestPerimetro(double ladoa, double ladob, double ladoc, double perimetroEsperado)
        {
            // Arrange
            // Act
            double resultado =Trapecio.Perimetro(ladoa, ladob, ladoc);

            // Assert
            Assert.Equal(perimetroEsperado, resultado);
        }

        [Theory]
        [InlineData(4, 5, 7, 24.0)]
        [InlineData(3, 6, 8, 21.0)]
        [InlineData(2, 3, 5, 8.0)]
        [InlineData(5, 4, 6, 25.0)]
        [InlineData(1, 2, 3, 2.5)] 
        [InlineData(6, 5, 7, 36.0)]
        [InlineData(3, 3, 3, 9.0)]
        [InlineData(2, 4, 6, 10.0)]
        [InlineData(5, 5, 5, 25.0)]
        [InlineData(4, 6, 8, 28.0)]

        
          
               public void TestArea(double angulod, double ladob, double ladoc, double areaEsperada)
        {
            // Arrange - Set up
            // Act - Perfom 
            double resultado = Trapecio.Area(angulod, ladob, ladoc);

            // Assert
            Assert.Equal(areaEsperada, resultado);
        }

        [Theory]
        [InlineData(24, 2, 48)]
        [InlineData(21, 3, 63)]
        [InlineData(8, 4, 32)]
        [InlineData(25, 2, 50)]
        [InlineData(2.5, 5, 12.5)]
        [InlineData(36, 3, 108)]
        [InlineData(9, 2, 18)]
        [InlineData(10, 4, 40)]
        [InlineData(25, 3, 75)]
        [InlineData(28, 2, 56)]
        public void TestVolumen(double area, double altura, double volumenEsperado)
        {
            // Arrange
            // Act
            double resultado = Trapecio.Volumen(area, altura);

            // Assert
            Assert.Equal(volumenEsperado, resultado);
        }
    }
}