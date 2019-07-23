using System;
using System.IO;
using System.Text;

namespace UsingDeclarations
{
    class Program
    {
        //public static StringBuilder ReadFile()
        //{
        //    using var file = new FileStream("e:\\temp\\input.txt", FileMode.OpenOrCreate);
        //    using var Stream = new StreamReader(file);

        //    var str = Stream.ReadToEnd();

        //    var fileContent = new StringBuilder();
        //    fileContent.Append(str);


        //    return fileContent;
        //}

        public static StringBuilder ReadFile()
        {
            var fileContent = new StringBuilder();

            using (var file = new FileStream("e:\\temp\\input.txt", FileMode.OpenOrCreate))
            using (var Stream = new StreamReader(file))
            {
                var str = Stream.ReadToEnd();
                fileContent.Append(str);
            }

            return fileContent;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ReadFile());
        }
    }
}
