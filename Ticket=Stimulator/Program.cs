using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ticket_Stimulator
{
    internal class Program
    {
        class Window
        {
            public Queue<int> Line = new Queue<int>();
        }

        public class TicketCounter
        {
            private static System.Timers.Timer aTimer;
            private static List<Window> windows = new List<Window>();
            private static StreamReader sr;

            public static void Timer()
            {
                // Create 4 windows once
                windows.Add(new Window());
                windows.Add(new Window());
                windows.Add(new Window());
                windows.Add(new Window());

                sr = new StreamReader("d:\\C#\\Data.txt");

                aTimer = new System.Timers.Timer(3000); // 3 seconds
                aTimer.Elapsed += HandleTimer;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }

           
            public static void HandleTimer(Object source, ElapsedEventArgs e)
            {
                if (!sr.EndOfStream)
                {                    string ln = sr.ReadLine();
                    if (int.TryParse(ln, out int Burst))
                    {

                        Console.WriteLine($"New Burst: {Burst}");

                        while (Burst > 0)
                        {
                            // Find the window with the smallest queue
                            int minIndex = 0;
                            int minCount = windows[0].Line.Count;

                            for (int i = 1; i < windows.Count; i++)
                            {
                                if (windows[i].Line.Count < minCount)
                                {
                                    minCount = windows[i].Line.Count;
                                    minIndex = i;
                                }
                            }

                            windows[minIndex].Line.Enqueue(1);
                            Burst--;
                            
                        }

                        LeavingtheWindow();
                        WaitingTime();
                        PrintWindow();
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line in file: {ln}");
                    }
                }
                else
                {
                    Console.WriteLine("No more bursts in the file.");
                    aTimer.Stop();
                    sr.Close();
                }
            }
            public static void LeavingtheWindow()
            {
                for(int i = 0; i < windows.Count; i++)
                {
                    if (windows[i].Line.Count != 0)
                    {
                        if (windows[i].Line.Count == 1) 
                        {
                            windows[i].Line.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Leaving 2 person for per minute");
                            windows[i].Line.Dequeue();
                            windows[i].Line.Dequeue();

                        }
                    }
                }
            }
            static void PrintWindow()
            {
                Console.WriteLine("---- Current Counter Status ----");
                for (int i = 0; i < windows.Count; i++)
                {
                    Console.WriteLine($"Counter {i + 1}: {windows[i].Line.Count} people");
                }
                Console.WriteLine("--------------------------------");
            }

            static async Task WaitingTime()
            {
                Console.WriteLine("waiting for 6 seconds");
                await Task.Delay(3000);//
                for(int i = 0; i < windows.Count; i++)
                {
                    int peoplebeforeLast=windows[i].Line.Count- 1;
                    int WaitingTime = peoplebeforeLast*30;

                    Console.WriteLine($"The waiting for the last person is {WaitingTime} seconds");
                }
            }

            public static void Main(String[] args)
            {
                Timer();
                Console.WriteLine("Main function is free now. Timer will print every 3 seconds!");

                Console.ReadLine();
                //System.Threading.Thread.Sleep(Timeout.Infinite)
            }
        }

    }
}
