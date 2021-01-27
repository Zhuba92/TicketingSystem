using System;
using System.IO;
using System.Collections;

namespace TicketingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "Tickets.csv";

            StreamWriter ticket = new StreamWriter(file);

            Console.WriteLine("Enter a ticket number");
            string number = Console.ReadLine();

            Console.WriteLine("Enter a summary");
            string summary = Console.ReadLine();

            Console.WriteLine("Enter a status");
            string status = Console.ReadLine();

            Console.WriteLine("Enter a priority");
            string priority = Console.ReadLine();

            Console.WriteLine("Enter a submitter");
            string submitter = Console.ReadLine();

            Console.WriteLine("Enter an assigned to");
            string assigned = Console.ReadLine();

            Console.WriteLine("How many people are watching the ticket?");
            int numWatchers = Convert.ToInt32(Console.ReadLine());
            string[] watchers = new string[numWatchers];

            for (int i = 0; i < watchers.Length; i++)
            {
                Console.WriteLine("Enter a watcher name");
                watchers[i] = Console.ReadLine();
            }
            string names = "";

            for (int i = 0; i < watchers.Length; i++)
            {
                if (i < watchers.Length - 1)
                {
                    names += watchers[i] + "|";
                }
                else names += watchers[i];
            }

            ticket.WriteLine("{0},{1},{2},{3},{4},{5},{6}", number, summary, status, priority, submitter, assigned, names);
            ticket.Close();

        }
    }
}
