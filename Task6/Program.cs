using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task6
{
    class Program
    {
        /// <summary>
        /// Закомментарена реализация исходного .exe при которой образуется deadLock
        /// </summary>
        
        //private static object knife = new object();
        //private static object cuttingBoard = new object();
        private static object kitchenStuff = new object();

        static void Main(string[] args)
        {
            Console.WriteLine("Girls are going to start cooking....");
           
            Thread wife = new Thread(WifeCoocks);
            Thread mother = new Thread(MotherCoocks);
            wife.Start();
            mother.Start();
           
            Console.ReadLine();
        }

        public static void WifeCoocks()
        {
            lock (kitchenStuff)
            {
                Console.WriteLine("Wife took the knife!");
                Console.WriteLine("Wife would like to take a cutting board....");
              
                //Thread.Sleep(1);
                //lock (cuttingBoard)
                //{
                    Console.WriteLine("Wife took the cuttingBoard!");

                // }
                Thread.Sleep(1000);
            }

        }

        public static void MotherCoocks()
        {

            lock (kitchenStuff)
            {
                Console.WriteLine("Mother took the cuttingBoard!");
                Console.WriteLine("Mother would like to take the knife....");
                //Thread.Sleep(1);
                //lock (knife)
                //{
                    Console.WriteLine("Mother took the knife!");

                Thread.Sleep(1000);
                //}
            }

           
        }
    }
}
