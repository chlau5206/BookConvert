/// ConvePub: console version of Convert ePub
/// Using .Net FW 4.8

using System;
using System.IO;

// using BookConvert;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace BookConvert {
    internal class Program {
        static void Main(string[] args) {
            //string filePath = (args.Length > 0) ? args[0] : "";
            string filePath = args[0];
            int retry = 0;

            while (((String.IsNullOrEmpty(filePath)
                || !File.Exists(filePath))
                || Path.GetExtension(filePath).ToLower() != ".epub")
                && retry < 3) {
                Console.Write("\nEnter the file path: ");
                filePath = Console.ReadLine();
                retry++;
            };

            Console.Write(DateTime.Now.ToString() + "\t");
            Console.WriteLine($"Convert EPub From GBK to Big5: {filePath} ");
            if (!String.IsNullOrEmpty(filePath))

                ePubBig5Converter.convertEPub(filePath);
            else
                throw new FileNotFoundException();

            /***************  The End  *******************/
            Console.Write(DateTime.Now.ToString() + "\t");
            Console.WriteLine("Convert successful. ");

#if (DEBUG)
            Console.ReadKey();
#endif

        }
    }
}
