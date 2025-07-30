using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Project
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

            public static void Timer()
            {
                // Create 4 windows once
                windows.Add(new Window());
                windows.Add(new Window());
                windows.Add(new Window());
                windows.Add(new Window());

                // Set up timer
                aTimer = new System.Timers.Timer(3000); // 3 seconds
                aTimer.Elapsed += HandleTimer;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }

            // Timer Event Handler
            public static void HandleTimer(Object source, ElapsedEventArgs e)
            {

                int numberOfpeople = 24;
                while (numberOfpeople != 0)
                {
                    // Add person to smallest queue
                    int minIndex = 0;
                    long min = windows[0].Line.Count;

                    for (int i = 1; i < windows.Count; i++)
                    {
                        if (windows[i].Line.Count < min)
                        {
                            min = windows[i].Line.Count;
                            minIndex = i;
                        }
                    }
                    windows[minIndex].Line.Enqueue(1);
                    numberOfpeople -= 1;
                }

                // Print windows after interval
                PrintWindow();
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

            public static void Main(String[] args)
            {
                Timer();
                Console.WriteLine("Main function is free now. Timer will print every 3 seconds!");

                // Keep main thread alive so timer keeps running
                Console.ReadLine();
                //System.Threading.Thread.Sleep(Timeout.Infinite);
            }
        }

    }
}
