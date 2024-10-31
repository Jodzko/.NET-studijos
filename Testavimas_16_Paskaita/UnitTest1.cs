

using static _16_Paskaita_Dictionaries.Program;


namespace Testavimas_16_Paskaita
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PatikrinimasSostiniu()
        {
            var expected = "Vilnius";
            var actual = Methods.CountryCapital("Lithuania");
            Assert.AreEqual(expected, actual);
        }
    }
}