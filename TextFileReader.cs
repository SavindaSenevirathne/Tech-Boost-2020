using System.IO;

namespace Tech_Boost_2020
{
    class TextFileReader : IFileReader<string>
    {
        public string[] Read(string fileName)
        {
            return File.ReadAllLines(fileName);
        }
    }
}
