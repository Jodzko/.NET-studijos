using System.Reflection;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetTextLength_WithLeadWhiteSpacedText_ReturnsLength()
        {
            //Arrange
            string input = "  Hello  ";
            int expected = 5;

            //Act
            int actual = Methods.GetTextLength(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        public void SumaPatikrinimas()
        {
            int skaicius1 = 5;
            int skaicius2 = 10;
            int expected = 15;
            double actual = Methods.Suma(skaicius1, skaicius2);
            Assert.AreEqual(expected, actual);
        }
        public void AtimtisPatikrinimas()
        {
            int skaicius1 = 15;
            int skaicius2 = 5;
            int expected = 10;
            double actual = Methods.Atimtis(skaicius1, skaicius2);
            Assert.AreEqual(expected, actual);
        }
        public void DaugybaPatikrinimas()
        {
            int skaicius1 = 5;
            int skaicius2 = 10;
            int expected = 50;
            double actual = Methods.Daugyba(skaicius1, skaicius2);
            Assert.AreEqual(expected, actual);
        }
        public void DalybaPatikrinimas()
        {
            int skaicius1 = 10;
            int skaicius2 = 2;
            int expected = 5;
            double actual = Methods.Dalyba(skaicius1, skaicius2);
            Assert.AreEqual(expected, actual);
        }
        public void KelimasLaipsniuPatikrinimas()
        {
            int skaicius1 = 5;
            int skaicius2 = 3;
            int expected = 125;
            double actual = Methods.KelimasLaipsniu(skaicius1, skaicius2);
            Assert.AreEqual(expected, actual);
        }
        public void SaknisPatikrinimas()
        {
            int skaicius = 16;
            int expected = 4;
            double actual = Methods.Saknis(skaicius);
            Assert.AreEqual(expected, actual);
        }
    }

}