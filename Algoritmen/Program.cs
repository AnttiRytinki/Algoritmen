namespace Algoritmen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vocabulary _vocabulary = new Vocabulary();
            string _readString = "";
            string _filePath = "stringList.txt";
            bool _fileEmpty = false;

            if (File.Exists(_filePath) == false)
            {
                using (File.Create(_filePath))
                {
                    _fileEmpty = true;
                }
            }

            if (_fileEmpty == true)
            {
                using (StreamWriter writer = File.AppendText(_filePath))
                {
                    writer.WriteLine("röv");
                    writer.WriteLine("bajs");
                    writer.WriteLine("kiss");
                    writer.WriteLine("avföring");
                }
            }

            _vocabulary.ReadFromFile(_filePath);

            Console.WriteLine("Skriv nåt och tryck enter, eller bara tryck enter.\n" +
                "Upprepa så många gånger du vill.\n" +
                "Skriv 105 och tryck enter när du vill spara och avsluta.");

            while (_readString != "105")
            {
                _readString = Console.ReadLine();
                Console.WriteLine(_vocabulary.Process(_readString));
                _vocabulary.SaveToFile(_filePath);
            }
        }
    }
}
