using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ahnenverlusst
{
    internal class Program
    {
        /*
        Jedes Paar gebkommt ein Kind.
        Das Durschschnittsalter ist 60 Jahr.
        */

        static void Main(string[] args)
        {
            //----------------INTRO----------------//
            string Antwort, Weltbevölkerung2, Jahr2;
            double Weltbevölkerung, Generationen;
            int Zähler, Jahr;
            do
            {
                Console.CursorVisible = false;
                Zähler = 1;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Wollen Sie eine fixe Weltbevölkerung haben oder eine dynamische?");
                    Console.Write("     [F] = Fix  |  [D] = Dynamisch");
                    Antwort = Console.ReadKey(true).KeyChar.ToString();
                    Antwort = Antwort.ToLower();
                } while (Antwort != "d" && Antwort != "f");

                //----------------DYNAMISCH----------------//
                if (Antwort == "d")
                {

                    //----------------DYNAMISCHE WELTBEVÖLKERUNG EINGABE----------------//
                    do
                    {
                        Console.Clear();
                        Console.Write("Bitte geben Sie die derzeitige Weltbevölkerung an: ");
                        Console.CursorVisible = true;
                        Weltbevölkerung2 = Console.ReadLine();
                        Console.CursorVisible = false;
                        double.TryParse(Weltbevölkerung2, out Weltbevölkerung);
                    } while (Weltbevölkerung <= 0);

                    //----------------DYNAMISCHE JAHR EINGABE----------------//
                    do
                    {
                        Console.Clear();
                        Console.Write("Bitte geben Sie das derzeitige Jahr ein: ");
                        Console.CursorVisible = true;
                        Jahr2 = Console.ReadLine();
                        Console.CursorVisible = false;
                        int.TryParse(Jahr2, out Jahr);
                    } while (Jahr == 0);

                    //----------------DYNAMISCH ALGORYTHMUS----------------//
                    Console.Clear();
                    Generationen = 1;
                    Zähler = 1;
                    Jahr -= 60;
                    Console.Write(Zähler + ". Generation          ");
                    if (Jahr > 0)
                    {
                        Console.WriteLine(Jahr + " n. Chr.");
                    }
                    else
                    {
                        Console.WriteLine((Jahr * -1) + " v. Chr.");
                    }
                    Console.WriteLine("Generationen  =  " + Generationen);
                    Console.WriteLine("Menschenanzahl = " + Convert.ToUInt64(Weltbevölkerung) + "\n\n");
                    while (Generationen <= Weltbevölkerung)
                    {
                        Zähler++;
                        Generationen *= 2;
                        Jahr -= 60;
                        if (Zähler < 3)
                        {
                            Weltbevölkerung /= 2;
                        }
                        else
                        {
                            Weltbevölkerung *= 0.75;
                        }
                        Thread.Sleep(100);
                        Console.Write(Zähler + ". Generation               ");
                        if (Jahr > 0)
                        {
                            Console.WriteLine(Jahr + " n. Chr.");
                        }
                        else
                        {
                            Console.WriteLine((Jahr * -1) + " v. Chr.");
                        }
                        Console.WriteLine("Generationen  =  " + Generationen);
                        Console.WriteLine("Menschenanzahl = " + Convert.ToUInt64(Weltbevölkerung) + "\n\n");
                    }
                }

                //----------------FIX----------------//
                if (Antwort == "f")
                {

                    //----------------FIX WELTBEVÖLKERUNG EINGABE----------------//
                    do
                    {
                        Console.Clear();
                        Console.Write("Bitte geben Sie die derzeitige Weltbevölkerung an: ");
                        Console.CursorVisible = true;
                        Weltbevölkerung2 = Console.ReadLine();
                        Console.CursorVisible = false;
                        double.TryParse(Weltbevölkerung2, out Weltbevölkerung);

                    } while (Weltbevölkerung <= 0);

                    //----------------DYNAMISCHE JAHR EINGABE----------------//
                    do
                    {
                        Console.Clear();
                        Console.Write("Bitte geben Sie das derzeitige Jahr ein: ");
                        Console.CursorVisible = true;
                        Jahr2 = Console.ReadLine();
                        Console.CursorVisible = false;
                        int.TryParse(Jahr2, out Jahr);
                    } while (Jahr == 0);

                    //----------------FIX ALGORYTHMUS----------------//
                    Console.Clear();
                    Generationen = 1;
                    Zähler = 1;
                    Jahr -= 60;
                    Console.Write(Zähler + ". Generation               ");
                    if (Jahr > 0)
                    {
                        Console.WriteLine(Jahr + " n. Chr.");
                    }
                    else
                    {
                        Console.WriteLine((Jahr * -1) + " v. Chr.");
                    }
                    Console.WriteLine("Generationen  =  " + Generationen);
                    Console.WriteLine("Menschenanzahl = " + Convert.ToUInt64(Weltbevölkerung) + "\n\n");
                    while (Generationen <= Weltbevölkerung)
                    {
                        Zähler++;
                        Generationen *= 2;
                        Jahr -= 60;
                        Thread.Sleep(100);
                        Console.Write(Zähler + ". Generation          ");
                        if (Jahr > 0)
                        {
                            Console.WriteLine(Jahr + " n. Chr.");
                        }
                        else
                        {
                            Console.WriteLine((Jahr * -1) + " v. Chr.");
                        }
                        Console.WriteLine("Generationen  =  " + Generationen);
                        Console.WriteLine("Menschenanzahl = " + Convert.ToUInt64(Weltbevölkerung) + "\n\n");
                    }
                }
                Console.WriteLine("          (Drücke eine Taste)");
                Console.ReadKey(true);

                //----------------PROGRAMM WIEDERHOLEN EINGABE----------------//
                do
                {
                    Console.Clear();
                    Console.WriteLine("Wollen Sie das Programm wiederholen?");
                    Console.Write("     [J] = Ja  |  [N] = Nein");
                    Antwort = Console.ReadKey(true).KeyChar.ToString();
                    Antwort = Antwort.ToLower();
                } while (Antwort != "j" && Antwort != "n");
            } while (Antwort == "j");
        }
    }
}
