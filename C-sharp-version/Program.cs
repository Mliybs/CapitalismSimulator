//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;
using CapiSimuUsing;

namespace CapitalismSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker jack = new Worker("Jack");

            Console.WriteLine(jack.WorkerName);
        }
    }
}
