using System;
using Xunit;
using Application253E05;

namespace Application253E05.IntegrationTest
{
    public class IntegrationTestApplication
    {
        [Theory]
        [InlineData(4, 5, 7, 2, 48.0)]
        [InlineData(3, 6, 8, 3, 63.0)]
        [InlineData(2, 3, 5, 4, 32.0)]
        [InlineData(5, 4, 6, 2, 50.0)]
        [InlineData(1, 2, 3, 5, 12.5)]
        [InlineData(6, 5, 7, 3, 108.0)]
        [InlineData(3, 3, 3, 2, 18.0)]
        [InlineData(2, 4, 6, 4, 40.0)]
        [InlineData(5, 5, 5, 3, 75.0)]
        [InlineData(4, 6, 8, 2, 56.0)]
        public void TestVolumen(double angulod, double ladob, double ladoc, double altura, double volumenEsperado)
        {
            // Arrange & Act
            double resultadoarea = Trapecio.Area(angulod, ladob, ladoc);
            double resultado = Trapecio.Volumen(resultadoarea, altura);

            // Assert con tolerancia
            double tolerancia = 0.0001;
            Assert.InRange(resultado, volumenEsperado - tolerancia, volumenEsperado + tolerancia);
        }
    }
}