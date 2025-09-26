using SzyfrCezara;


namespace TestSzyfrCezara
{
    public class UnitTest1
    {
        [Fact]
        public void TestDanePodstawowe()
        {
            // Arrange
            string tekst = "abc";
            int przesuniecie = 3;

            string oczekiwanyWynik = "def";

            // Act
            string wynik = Program.SzyfrCezara(tekst, przesuniecie);

            // Assert
            Assert.Equal(oczekiwanyWynik, wynik);
        }
    }
}