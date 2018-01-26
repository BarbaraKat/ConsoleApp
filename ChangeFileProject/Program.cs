using System;
using System.IO;
using System.Text;

namespace ChangeFileProject
{
    class Program
    {
        public static string option { get; private set; }

        private static int _result = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hey, möchten Sie einen Quiz spielen?");
            Console.WriteLine("Wenn ja, geben Sie bitte die 1 ein.");
            Console.WriteLine("Wenn nein, geben Sie bitte die 2 ein.");

            option = Console.ReadLine();


            if (option == "1")
            {
                Console.WriteLine("Okay. Die erste Frage ist folgende: Was war schon seit Mai 1969 ein beliebtes Zahlungsmittel im europäischen Raum?");
                Console.WriteLine("1 Euronoten");
                Console.WriteLine("2 Eurocheques");
                Console.WriteLine("3 Euroscheine");
                Console.WriteLine("4 Euromünzen");
                option = Console.ReadLine();
            }

            if (option == "2")
            {
                MyProcedure1();
            }
            else
            {
                MyProcedure2();
            }

            Console.WriteLine(MyFunction(0, 10));

            _result = _result + 1;

            _result++;
            if (option == "1")
            {
                Console.WriteLine("Die nächste Frage lautet: Welche Staaten einigten sich Ende des Jahres 2012 über die Festsetzung eines Grenzverlauf?");
                Console.WriteLine("1 Deutschland und Australien");
                Console.WriteLine("2 Polen und Südafrika");
                Console.WriteLine("3 Dänemark und Kanada");
                Console.WriteLine("4 Österreich und Japan");
                option = Console.ReadLine();
            }
            if(option == "3")
            {
                MyProcedure1();
            }
            else
            {
                MyProcedure2();
            }

            if (option == "1")
            {
                Console.WriteLine("Die nächste Frage lautet:Für was steht die Abkürzung \"GmbH\"?");
                Console.WriteLine("1 Geschäft mit beschränkter Haftung");
                Console.WriteLine("2 Gesellschaft mit bekannter Haftung");
                Console.WriteLine("3 Gesellschafter mit beschränkter Haftung");
                Console.WriteLine("4 Gesellschaft mit beschränkter Haftung");
                option = Console.ReadLine();
            }
            if (option == "1")
            {
                MyProcedure1();
            }
            else
            {
                MyProcedure2();
            }
            if (option == "1")
            {
                Console.WriteLine("Welche Stadt benutzt das Kennzeichen \"FF\"?");
                Console.WriteLine("1 Friedlingen am Fluß");
                Console.WriteLine("2 Flensburg");
                Console.WriteLine("3 Frankfurt an der Oder");
                Console.WriteLine("4 Friedlingen am Fluß");
                Console.ReadLine();
            }

            if (option == "3")
            {
                MyProcedure1();
            }
            else
            {
                MyProcedure2();
            }
             if(option == "1")
            {
                Console.WriteLine("Wie lautet der frühere Name von Istambul?");
                Console.WriteLine("1 Delphi");
                Console.WriteLine("2 Herat");
                Console.WriteLine("3 Konstantinopel");
                Console.WriteLine("4 Metropolis");
                Console.ReadLine();
            }
             if(option == "3")
            {
                MyProcedure1();
            }
             else
            {
                MyProcedure2();
            }

            if (option == "1")
            {
                Console.WriteLine("Das war die letzte Frage. Danke, dass Sie an diesem Quiz teilgenommen haben.");
                Console.WriteLine("Ergebniss: " + _result);
            }



                ///FileStream s = File.OpenWrite(@"C:\Users\j.gabele.4614\Desktop\Ihr_Ergebnis.txt");
                ///Byte[] info = (new UTF8Encoding(true).GetBytes("Das hier ist ein toller Text."));
                ///s.Write(info, 0, info.Length);
                ///s.Close();
                Console.ReadLine();
        }
  

        static int MyFunction(int a, int b)
        {
            return a + b;
                        
        }

        static void MyProcedure1()
        {
            Console.WriteLine("Super, das war richtig.");
            Console.WriteLine("Wenn Sie weiterspielen wollen, geben sie bitte die 1 ein.");
            option = Console.ReadLine();
        }
        static void MyProcedure2()
        {
            Console.WriteLine("Das war leider falsch.");
            Console.WriteLine("Um weiter zu spielen, geben sie bitte die 1 ein.");
            option = Console.ReadLine();
        }
    }
}

