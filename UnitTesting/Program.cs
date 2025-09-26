namespace SzyfrCezara
{
    public class Program
    {
        public static string SzyfrCezara(string tekst, int przesuniecie)
        {
            char[] litery = tekst.ToCharArray();

            for(int i = 0; i < litery.Length; i++)
            {
                char znak = litery[i];

                if (char.IsLetter(znak))
                {
                    char offset = char.IsLower(znak) ? 'a' : 'A';
                    // znak = (char)(((znak + przesuniecie - offset) % 26 + 26) % 26 + offset);

                    // Pobieranie pozycji znaku z naszego alfabetu
                    znak = (char)(znak + przesuniecie - offset);

                    // Zabezpieczenie czy litera nie wykracza poza zakres naszego alfabetu (mamy 26 liter)
                    znak = (char)(znak % 26 + 26);

                    // Przypisywanie odpowiedniego znaku do wyświetlenia
                    znak = (char)(znak % 26 + offset);
                }
                litery[i] = znak;
            }

            return new string(litery);
        }

        static void Main(string[] args)
        {

        }
    }
}