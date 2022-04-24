using System.Drawing;
using Console = Colorful.Console;
using S7.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {

            try
            {
                //todo:
                //for loop for animation so every loop is checked if killswitch is enabled
                //time shit pls
                //fix bugz
                //zap zap bugzapper
                for (int i = 0; i < 64; i++)
                {



                }
                Thread.Sleep(100);
                Console.Clear();
                Animation(40, 64);
                FullFill();
                /*for (int i = 0; i < 10; i++)
                {
                    ICE();
                }*/
                Animation(64, 132);
                CaptinKurk();
                Animation(132, 192);

                Plc _S71200 = new Plc(CpuType.S71200, "192.168.2.11", 0, 1);
                Console.WriteLine("Connecting");
                _S71200.Open();


                if (_S71200.IsConnected)
                {
                    Console.Clear();
                    while (true)
                    {

                        bool DB0 = (bool)_S71200.Read("DB4.DBX0.0"); //noodstop
                        bool DB1 = (bool)_S71200.Read("DB4.DBX0.1"); //start sensor
                        bool DB2 = (bool)_S71200.Read("DB4.DBX0.2"); //fill sensor
                        bool DB3 = (bool)_S71200.Read("DB4.DBX0.3"); //kurk sensor
                        bool DB4 = (bool)_S71200.Read("DB4.DBX0.4"); //end sensor
                        bool DB5 = (bool)_S71200.Read("DB4.DBX0.5"); //motor running ?
                        
                        if (DB1)
                        {
                            while(DB2 == false && DB0 == false && DB5)
                            {
                                for(int i = 0; i < 64; i++)
                                {
                                    DB2 = (bool)_S71200.Read("DB4.DBX0.2");
                                    DB0 = (bool)_S71200.Read("DB4.DBX0.0");
                                    Animation(i, (i + 1));
                                }
                                
                            }
                        }
                        if (DB2&& DB0 == false && DB5== false)
                        {
                            FullFill();
                        }
                        if(DB2 && DB0 == false && DB5)
                        {
                            while (DB3 == false && DB0 == false && DB5)
                            {
                                for (int i = 64; i < 132; i++)
                                {
                                    DB3 = (bool)_S71200.Read("DB4.DBX0.3");
                                    DB0 = (bool)_S71200.Read("DB4.DBX0.0");
                                    Animation(i, (i + 1));
                                }
                            }
                        }
                        if (DB3 && DB0 == false && DB5 == false)
                        {
                            CaptinKurk();
                        }
                        if (DB3 && DB0 == false && DB5)
                        {
                            while (DB4 == false && DB0 == false && DB5)
                            {
                                for (int i = 132; i < 192; i++)
                                {
                                    DB4 = (bool)_S71200.Read("DB4.DBX0.4");
                                    DB0 = (bool)_S71200.Read("DB4.DBX0.0");
                                    Animation(i, (i + 1));
                                }
                            }
                        }
                        if (DB4)
                        {
                            while (DB4 && DB0 == false)
                            {
                                DB4 = (bool)_S71200.Read("DB4.DBX0.4");
                                DB0 = (bool)_S71200.Read("DB4.DBX0.0");
                                Animation(192, 192);
                            }
                        }
                        while (DB0)
                        {
                            ICE();
                        }



                        //prob never used _S71200.Write("DB1.DBX0.0", true);



                    }



                }
               
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            
        }
        static void FullFill()
        {
            Console.Clear();
            for(int i = 0; i < 50; i++)
            {
                Console.SetCursorPosition(0, 0);

                for (int l = 0; l < 10; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.UTF8;
                var margin = "".PadLeft(63);
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |_____|", Color.White);
                if(i%2 == 0)
                {
                    Console.WriteLine(margin + "   &8 ", Color.Gold);
                    Console.WriteLine(margin + "    $%", Color.Gold);
                    Console.WriteLine(margin + "   &% ", Color.Gold);
                }
                else
                {
                    Console.WriteLine(margin + "    9%", Color.Gold);
                    Console.WriteLine(margin + "   &3 ", Color.Gold);
                    Console.WriteLine(margin + "    $&", Color.Gold);
                }

                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/\"\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " |_____|", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.White);
                Thread.Sleep(100);
            }
            Console.Clear();

        }
        static void CaptinKurk()
        {
            Console.Clear();
            int k = 5;
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, 0);

                for (int l = 0; l < 8; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(131);
                for (int j = 0; (j+k) < 5; j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |_____|", Color.White); 
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
                Console.Write(margin + "   |", Color.Green);
                Console.Write("~", Color.Gold);
                Console.WriteLine("|", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/\"\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " |_____|", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.White);
                Thread.Sleep(100);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, 0);

                for (int l = 0; l < 8; l++)
                {

                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(131);
                for (int j = 1; (j + k) < 5; j++)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |||||||", Color.White);
                Console.WriteLine(margin + " |_____|", Color.White);
                for (int j = 1; j < k; j++)
                {
                    Console.WriteLine(margin + "        ");
                }
                if (k == 4) { }
                else
                {
                    k++;
                }
                if (k >= 2) { Console.WriteLine(margin + "   ___  ", Color.White); }
                if (k >= 1) { Console.WriteLine(margin + "  (   )  ", Color.White); }
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.Write(margin + "   |", Color.Green);
                Console.Write("~", Color.Gold);
                Console.WriteLine("|", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/\"\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " |_____|", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.White);
                Thread.Sleep(100);
            }
            Console.Clear();
        }
        static void Animation(int start,int stop)
        {

            for (int j = start; j < stop; j++)
            {
                
                Console.SetCursorPosition(0, 0);
                for (int l = 0; l < 14; l++)
                {
                    Console.WriteLine();
                }

                Console.OutputEncoding = System.Text.Encoding.Unicode;
                var margin = "".PadLeft(j);
                if (j >= 132)
                {
                    Console.WriteLine(margin + "   ___", Color.White);
                    Console.WriteLine(margin + "  (   )", Color.White);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.Write(margin + "   |", Color.Green);
                if (j >= 64)
                {
                    Console.Write("~", Color.Gold);
                }
                else { Console.Write(" "); }
                Console.WriteLine("|", Color.Green);
                Console.WriteLine(margin + "   | |", Color.Green);
                Console.WriteLine(margin + "  /   \\", Color.Green);
                Console.Write(margin + " | ", Color.Green);
                Console.Write("/\"\\", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write("|   |", Color.White);
                Console.WriteLine("|", Color.Green);
                Console.Write(margin + " |", Color.Green);
                Console.Write(" \\_/", Color.White);
                Console.WriteLine(" |", Color.Green);
                Console.WriteLine(margin + " |_____|", Color.Green);
                Console.WriteLine("   +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+[" + "\x1B[4m" + "\"\"\"\"\"" + "\x1B[0m" + "]+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+", Color.White);

                Thread.Sleep(100);

                //0-45,45-96,96-135
            }

        }
        static void ICE()
        {
            
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int i = (Console.WindowWidth / 2)-16;
            var margin = "".PadLeft(i);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(margin + "       _______________________",Color.Red);
            Console.WriteLine(margin + "      / _____________________ \\", Color.Red);
            Console.WriteLine(margin + "     / /                     \\ \\", Color.Red);
            Console.WriteLine(margin + "    / /                       \\ \\", Color.Red);
            Console.WriteLine(margin + "   / /                         \\ \\", Color.Red);
            Console.WriteLine(margin + "  / /                           \\ \\", Color.Red);
            Console.WriteLine(margin + " / / SSSSSS TTTTTT OOOOOO PPPPPP \\ \\", Color.Red);
            Console.WriteLine(margin + "| |  SS       TT   OO  OO PP  PP  | |", Color.Red);
            Console.WriteLine(margin + "| |  SS       TT   OO  OO PP  PP  | |", Color.Red);
            Console.WriteLine(margin + "| |  SSSSSS   TT   OO  OO PPPPPP  | |", Color.Red);
            Console.WriteLine(margin + "| |      SS   TT   OO  OO PP      | |", Color.Red);
            Console.WriteLine(margin + "| |      SS   TT   OO  OO PP      | |", Color.Red);
            Console.WriteLine(margin + " \\ \\ SSSSSS   TT   OOOOOO PP     / /", Color.Red);
            Console.WriteLine(margin + "  \\ \\                           / /", Color.Red);
            Console.WriteLine(margin + "   \\ \\                         / /", Color.Red);
            Console.WriteLine(margin + "    \\ \\                       / /", Color.Red);
            Console.WriteLine(margin + "     \\ \\                     / /", Color.Red);
            Console.WriteLine(margin + "      \\ \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\" /", Color.Red);
            Console.WriteLine(margin + "       \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"", Color.Red);
            Thread.Sleep(500);
            Console.SetCursorPosition(0, 0);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(margin + "       _______________________", Color.Orange);
            Console.WriteLine(margin + "      / _____________________ \\", Color.Orange);
            Console.WriteLine(margin + "     / /                     \\ \\", Color.Orange);
            Console.WriteLine(margin + "    / /                       \\ \\", Color.Orange);
            Console.WriteLine(margin + "   / /                         \\ \\", Color.Orange);
            Console.WriteLine(margin + "  / /                           \\ \\", Color.Orange);
            Console.WriteLine(margin + " / / SSSSSS TTTTTT OOOOOO PPPPPP \\ \\", Color.Orange);
            Console.WriteLine(margin + "| |  SS       TT   OO  OO PP  PP  | |", Color.Orange);
            Console.WriteLine(margin + "| |  SS       TT   OO  OO PP  PP  | |", Color.Orange);
            Console.WriteLine(margin + "| |  SSSSSS   TT   OO  OO PPPPPP  | |", Color.Orange);
            Console.WriteLine(margin + "| |      SS   TT   OO  OO PP      | |", Color.Orange);
            Console.WriteLine(margin + "| |      SS   TT   OO  OO PP      | |", Color.Orange);
            Console.WriteLine(margin + " \\ \\ SSSSSS   TT   OOOOOO PP     / /", Color.Orange);
            Console.WriteLine(margin + "  \\ \\                           / /", Color.Orange);
            Console.WriteLine(margin + "   \\ \\                         / /", Color.Orange);
            Console.WriteLine(margin + "    \\ \\                       / /", Color.Orange);
            Console.WriteLine(margin + "     \\ \\                     / /", Color.Orange);
            Console.WriteLine(margin + "      \\ \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\" /", Color.Orange);
            Console.WriteLine(margin + "       \"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"", Color.Orange);
            Thread.Sleep(500);
            Console.Clear();

        }
    }

}