using System.Drawing;
using Console = Colorful.Console;
using S7.Net;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(150, 30);
            try
            {
                Animation(0, 45);
                FullFill();
                Animation(45, 96);
                CaptinKurk();
                Animation(96, 135);

               /* 
                Plc _S71200 = new Plc(CpuType.S71200,"set ip here u dumb fuck", 0, 1);
                Console.WriteLine("Connecting");
                _S71200.Open();


                if (_S71200.IsConnected)
                {
                    while (true)
                    {

                        bool DB1 = (bool)_S71200.Read("DB1.DBX0.0");
                        bool DB2 = (bool)_S71200.Read("DB1.DBX0.1");
                        bool DB3 = (bool)_S71200.Read("DB1.DBX0.2");

                        if (DB1)
                        {
                            Animation(1, 46);
                        }

                        
                           //prob never used _S71200.Write("DB1.DBX0.0", true);

                      

                    }



                }
               */

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
        static void FullFill()
        {
            for(int i = 0; i < 50; i++)
            {
                Console.Clear();

                for (int l = 0; l < 10; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(45);
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " L_____˩", Color.Silver);
                if(i%2 == 0)
                {
                    Console.WriteLine(margin + "   &8", Color.Gold);
                    Console.WriteLine(margin + "    $%", Color.Gold);
                    Console.WriteLine(margin + "   &%", Color.Gold);
                }
                else
                {
                    Console.WriteLine(margin + "    9%", Color.Gold);
                    Console.WriteLine(margin + "   &3", Color.Gold);
                    Console.WriteLine(margin + "    $&", Color.Gold);
                }

                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   ˩ L", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/‾\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " L_____˩", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                Thread.Sleep(100);
            }


        }
        static void CaptinKurk()
        {
            int k = 5;
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();

                for (int l = 0; l < 8; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(95);
                for (int j = 0; (j+k) < 5; j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " L_____˩", Color.Silver); 
                for (int j = 0; j < k; j++)
                {
                    Console.WriteLine();
                }
                if (k == 0) { }
                else
                {
                    k--;
                }

                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   ˩ L", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/‾\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " L_____˩", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                Thread.Sleep(100);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Clear();

                for (int l = 0; l < 8; l++)
                {

                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(95);
                for (int j = 1; (j + k) < 5; j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " |||||||", Color.Silver);
                Console.WriteLine(margin + " L_____˩", Color.Silver);
                for (int j = 1; j < k; j++)
                {
                    Console.WriteLine();
                }
                if (k == 4) { }
                else
                {
                    k++;
                }
                if (k >= 2) { Console.WriteLine(margin + "   ___", Color.Silver); }
                if (k >= 1) { Console.WriteLine(margin + "  (   )", Color.Silver); }
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   ˩ L", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/‾\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " L_____˩", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                Thread.Sleep(100);
            }
        }
        static void Animation(int start,int stop)
        {

            for (int j = start; j < stop; j++)
            {
                

                Console.Clear();

                for (int l = 0; l < 14; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(j);
                if (j >= 96)
                {
                    Console.WriteLine(margin + "   ___", Color.Silver);
                    Console.WriteLine(margin + "  (   )", Color.Silver);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   ˩ L", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/‾\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " L_____˩", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "‾‾‾‾‾" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.Silver);
                Thread.Sleep(100);

                //0-45,45-96,96-135
            }

        }
    }

}