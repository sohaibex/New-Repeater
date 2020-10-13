using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            string choice = "";

            do
            {
                try
                {
                    int i = 0;
                    int counter = 0;
                    string line;
                    string Text1 = "";
                    string Text2 = "";
                    string Text3 = "";
                    int typo;
                    int j=0;
                    string path = Directory.GetCurrentDirectory();
                    string path2;




                    Console.Write("Type a Txt File Name:");
                    path2 = Console.ReadLine();
                    StreamReader file = new StreamReader(@"" + path + @"\" + path2 +".txt");



                    Console.WriteLine("First Text:"); Text1 = Console.ReadLine();
                    Console.WriteLine("Second Text:"); Text2 = Console.ReadLine();
                    Console.WriteLine("Third Text:"); Text3 = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("\nChoose Format Type");
                    Console.WriteLine("1: Text1 + Array");
                    Console.WriteLine("2: Text1 + Array + Text2");
                    Console.WriteLine("3: Text1 + Array + Text2 + Array");
                    Console.WriteLine("4: Text1 + Array + Text2 + Array + Text3");
                    Console.WriteLine("5: Array + Text1");
                    Console.WriteLine("6: Array + Text1 + Array");
                    Console.WriteLine("7: Array + Text1 + Array + Text2");
                    Console.WriteLine("8: Array + Text1 + Array + Text2 + Array");
                    Console.WriteLine("9: Array + Text1 + Array + Text2 + Array + Text3");
                    Console.WriteLine("10: Text1 + Number + Text2 + Array + Text3");
                    Console.WriteLine("11: Text1 + Number + Text2 ");
                    Console.Write("\nChoice:");
                    typo = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine("-----------------------------------------------------------------------");

                    if (typo == 1) { while ((line = file.ReadLine()) != null) { Console.WriteLine(Text1 + line); counter++; i++; } }
                    if (typo == 2) { while ((line = file.ReadLine()) != null) { Console.WriteLine(Text1 + line + Text2); counter++; i++; } }
                    if (typo == 3) { while ((line = file.ReadLine()) != null) { Console.WriteLine(Text1 + line + Text2 + line); counter++; i++; } }
                    if (typo == 4) { while ((line = file.ReadLine()) != null) { Console.WriteLine(Text1 + line + Text2 + line + Text3); counter++; i++; } }
                    if (typo == 5) { while ((line = file.ReadLine()) != null) { Console.WriteLine(line + Text1); counter++; i++; } }
                    if (typo == 6) { while ((line = file.ReadLine()) != null) { Console.WriteLine(line + Text1 + line); counter++; i++; } }
                    if (typo == 7) { while ((line = file.ReadLine()) != null) { Console.WriteLine(line + Text1 + line + Text2); counter++; i++; } }
                    if (typo == 8) { while ((line = file.ReadLine()) != null) { Console.WriteLine(line + Text1 + line + Text2 + line); counter++; i++; } }
                    if (typo == 9) { while ((line = file.ReadLine()) != null) { Console.WriteLine(line + Text1 + line + Text2 + line + Text3); counter++; i++; } }
                    if (typo == 10) { while ((line = file.ReadLine()) != null) { Console.WriteLine(Text1 + i + Text2 + line + Text3); counter++; i++; } }

                    if (typo == 11) { Console.WriteLine("Pick the Maximum Number Repeat."); j = Int32.Parse(Console.ReadLine()); }
                    if (typo == 11) { while ( i <= j ) { System.Console.WriteLine(Text1 + i + Text2); counter++; i++; } }

                   
                    Console.WriteLine("-----------------------------------------------------------------------");
                    file.Close();
                    System.Console.WriteLine("There were {0} lines.", counter);
                  }

                catch
                {
                    Console.Write("Path Doesn't Exist"); System.Console.ReadLine();
                }

               
              
                Console.Write("\nUse Again ? Yes(Y) or No(N): ");
                choice = Console.ReadLine();

                if ( choice == "Y" || choice == "y" || choice == "1" || choice == "Yes" || choice == "yes" )
                {
                    done = true;
                    Console.Clear();


                }

                if (choice == "n" || choice == "N" || choice == "2" || choice == "No" || choice == "no")
                {
                    done = false;
                }


            } while (done == true);

            Console.ReadLine();
        }
    }


}
