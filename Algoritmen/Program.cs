namespace Algoritmen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vocabulary _vocabulary = new Vocabulary();
            string _readString = "";
            string filePath = "stringList.txt";

            if (File.Exists(filePath) == false)
                using (File.Create(filePath)) 
                {
                }

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("röv");
                writer.WriteLine("bajs");
                writer.WriteLine("kiss");
                writer.WriteLine("avföring");
            }

            _vocabulary.ReadFromFile(filePath);

            Console.WriteLine("Skriv nåt och tryck enter, eller bara tryck enter.\n" +
                "Upprepa så många gånger du vill.\n" +
                "Skriv 105 och tryck enter när du vill spara och avsluta.");

            while (_readString != "105")
            {
                _readString = Console.ReadLine();
                Console.WriteLine(_vocabulary.Process(_readString));
                _vocabulary.SaveToFile(filePath);
            }
        }
    }
}
