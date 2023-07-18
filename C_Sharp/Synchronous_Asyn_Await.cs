// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // //Synchronous programming
        // static void Main(string[] args)
        // {
        //     Task1();
        //     Task2();
        //     Task3();
        //     Task4();

        // }

        // public static void Task1()
        // {
        //     Console.WriteLine("Start Task1");
        //     Thread.Sleep(4000);
        //     Console.WriteLine("End Task1");
        // }

        // public static void Task2()
        // {
        //     Console.WriteLine("Start Task2");
        //     Thread.Sleep(3000);
        //     Console.WriteLine("End Task2");
        // }

        // public static void Task3()
        // {
        //     Console.WriteLine("Start Task3");
        //     Thread.Sleep(5000);
        //     Console.WriteLine("End Task3");
        // }

        // public static void Task4()
        // {
        //     Console.WriteLine("Start Task4");
        //     Thread.Sleep(6000);
        //     Console.WriteLine("End Task4");
        // }

        //// End Synchronous programming


        // Asynchronous programming

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine(); // For not writing this line I've spend 1 hour to find out why the program is not working
                               // The reason is that the main thread is finished before the other threads
                               // So we need to wait for the other threads to finish their work
                               // which means we wait for the user to press any input while the other threads are working



        }

        public static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Start Task1");
                Thread.Sleep(4000);
                Console.WriteLine("End Task1");
            });

        }

        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Start Task2");
                Thread.Sleep(3000);
                Console.WriteLine("End Task2");
            });

        }

        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Start Task3");
                Thread.Sleep(5000);
                Console.WriteLine("End Task3");
            });

        }

        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Start Task4");
                Thread.Sleep(6000);
                Console.WriteLine("End Task4");
            });

        }

    }


}
