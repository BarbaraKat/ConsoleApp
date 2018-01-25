using System;
using System.IO;
using System.Text;

namespace ChangeFileProject
{
    class Program
    {
        public static string option { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hey, möchten Sie einen Quiz spielen?");
            Console.WriteLine("Ja.(Option 1)");
            Console.WriteLine("Nein.(Option 2)");

            
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Okay. Die erste Frage ist folgende: Was war schon seit Mai 1969 ein beliebtes Zahlungsmittel im europäischen Raum?");
                Console.WriteLine("1 Euronoten(option 1)");
                Console.WriteLine("2 Eurocheques(option 2)");
                Console.WriteLine("3 Euroscheine(option 3)");
                Console.WriteLine("4 Euromünzen(option 4)");
                option = Console.ReadLine();
            }

            if (option == "2")
            {
                Console.WriteLine("Super, das war richtig.");
                Console.WriteLine("Weiter(Option 1)");
                option = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Das war leider falsch, die richtige Antwort wäre 2 Eurocheque gewesen.");
                Console.WriteLine("Weiter(Option 1)");
                option = Console.ReadLine();
            }

            if(option == "1")
            {
                Console.WriteLine("Die nächste Frage lautet: Welche Staaten einigten sich Ende des Jahres 2012 über die Festsetzung eines Grenzverlauf?");
                Console.WriteLine("Deutschland und Australien(Option 1)");
                Console.WriteLine("Polen und Südafrika(Option 2)");
                Console.WriteLine("Dänemark und Kanada(Option 3)");
                Console.WriteLine("Österreich und Japan(Option 4)");
                option = Console.ReadLine();
            }
            if(option == "3")
            {
                Console.WriteLine("Super, das war richtig.");
                Console.WriteLine("Weiter(Option 1)");
                option = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Das war leider falsch, die richtige Antwort wäre 2 Eurocheque gewesen.");
                Console.WriteLine("Weiter(Option 1)");
                option = Console.ReadLine();
            }

            if (option == "1")
            {
                Console.WriteLine("Die nächste Frage lautet:Für was steht die Abkürzung \"GmbH\"?");
                Console.WriteLine("Geschäft mit beschränkter Haftung(Option 1)");
                Console.WriteLine("Gesellschaft mit bekannter Haftung(Option 2)");
                Console.WriteLine("Gesellschafter mit beschränkter Haftung(Option 3)");
                Console.WriteLine("Gesellschaft mit beschränkter Haftung(Option 4)");
                
            }










            ///FileStream s = File.OpenWrite(@"C:\Users\j.gabele.4614\Desktop\Ihr_Ergebnis.txt");
            ///Byte[] info = (new UTF8Encoding(true).GetBytes("Das hier ist ein toller Text."));
            ///s.Write(info, 0, info.Length);
            ///s.Close();
            Console.ReadLine();
        }
    }
}

