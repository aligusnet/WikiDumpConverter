using System;
using System.Diagnostics;
using static wikidump.WikiDumpTransformer;

namespace WikiDumpConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string dumpFilePath = @"F:\wikipedia\enwiki-20190101-pages-articles-multistream.xml";
            string pathToSave = @"F:\wikipedia\enwiki";

            var timer = new Stopwatch();
            timer.Start();
            Transform(dumpFilePath, pathToSave);
            timer.Stop();
            Console.WriteLine("Finished in {0}", timer.Elapsed);
        }
    }
}
