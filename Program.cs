using System;

namespace UPCCodeGenerator
{
    class Program
    {
        public int[] genCode = new int[12];
        public const int MAX_PREFIX = 999;

        public static string upcGen(int prefix, int numToGen)
        {
            return $"Prefix: {prefix} \n" +
                   $"Num Gen: {numToGen}";

        }

        public static void Main(string[] args)
        {
            Console.WriteLine("||============|| UPC Code Generator ||============||\n" +
                              "                   by Hunter Jones                  \n" +
                              "                                                    \n" +
                              "                                                    \n" +
                              "                                                    \n" +
                              "                                                    \n");
            
            int prefixNum;
            do{
                Console.WriteLine("Please Enter a 3 number UPC prefix (leave blank for default): ");
                string? prefixInput = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(prefixInput))
                {
                    prefixNum = 0;
                }
                else
                {
                    int.TryParse(prefixInput, out prefixNum);
                }
                
            }while (!(prefixNum >= 0 && prefixNum <= MAX_PREFIX));
            
            int numGen;
            do{
                Console.WriteLine("Please Enter Number of Times Generated (Default: 1)");
                string? numgenInput = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(numgenInput))
                {
                    numGen = 1;
                }
                else
                {
                    int.TryParse(numgenInput, out numGen);
                }
            }while(!(numGen > 0));
            
            Console.WriteLine(upcGen(prefixNum, numGen));
        }
    }
}

