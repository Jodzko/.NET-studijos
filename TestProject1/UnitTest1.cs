using _13_Paskaita_Foreach_Ir_Dvimaciai_Masyvai;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Reflection;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PatikraSuNeigiamaisSkaiciais()
        {
            int[] skaiciai = { -2, -3, -4, -5 };
            int expected = -3;
            double actual = Methods.VidurkioSkaiciavimas(skaiciai);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PatikraSuTeigiamaisSkaiciais()
        {
            int[] skaiciai = { 2, 3, 4, 5 };
            int expected = 3;
            double actual = Methods.VidurkioSkaiciavimas(skaiciai);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PatikraSkirtingaisSKaiciais()
        {
            int[] skaiciai = { -3, 2, 4, 8, -5 };
            int[] expected = { 2, 4, 8 };
            int[] actual = Methods.TeigiamuSkaiciuGrazinimas(skaiciai);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PatikraTikTeigiamaisSKaiciais()
        {
            int[] skaiciai = { 3, 2, 4, 8, 5 };
            int[] expected = { 3, 2, 4, 8, 5 };
            int[] actual = Methods.TeigiamuSkaiciuGrazinimas(skaiciai);
            Assert.AreEqual(expected, actual);
        }
    }

}