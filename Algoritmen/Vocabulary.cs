using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen
{
    public class Vocabulary
    {
        List<string> _strings = new List<string>();

        public int NumberOfStrings => _strings.Count;
        public string Random => _strings[new Random().Next(_strings.Count)];

        public int LongestStringLength
        { 
            get
            {
                string s = string.Empty;

                for (int i = 0; i < NumberOfStrings; i++)
                {
                    if(_strings[i].Length > s.Length)
                        s = _strings[i];
                }

                return s.Length;
            }
        }

        public List<string> GetNUniqueRandom(int n)
        {
            Random random = new Random();
            List<string> shuffledStrings = new List<string>(_strings);
            shuffledStrings.Shuffle(random);

            return shuffledStrings.Take(n).ToList();
        }

        public string Process(string stringToBeProcessed)
        {
            if (stringToBeProcessed == "105")
                return "";

            if (stringToBeProcessed != "")
                _strings.Add(stringToBeProcessed);

            return _strings[new Random().Next(_strings.Count)];
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string s in _strings)
                {
                    writer.WriteLine(s);
                }
            }
        }

        public void ReadFromFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string s;

                while ((s = reader.ReadLine()) != null)
                {
                    _strings.Add(s);
                }
            }
        }
    }
}
