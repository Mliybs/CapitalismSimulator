//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;

namespace CapitalismSimulatorUsing
{
    class CapitalismSimulator
    {
        public CapitalismSimulator()
        {
            Console.WriteLine("资本主义模拟器开始运行！");
        }

        public static int gelt = 1000;

        public static int Workers { get { return workers; } }

        internal static int workers;

        public void hire<T>(T hired)
        {
            if(hired.GetType().GetInterface("IWorker") != null)
            {
                Console.WriteLine(hired.GetType().ToString() == "CapiSimuUsing.Jack");
            }
        }
    }

    class Wares
    {
        public Wares()
        {
            plank.code = 1;
            
            plank.W = 20;

            plank.name = "木板";

            screw.code = 2;

            screw.W = 4;

            screw.name = "螺丝";
        }
        public Ware plank;

        public Ware screw;
    }

    struct Ware
    {
        public int code;

        public int W;

        public string name;
    }

    class Robot : IWorker
    {
        public void Work() {}

        void IWorker.Die()
        {
            throw new RobotDieException();
        }
    }

    class Worker : IWorker
    {
        public Worker(string name)
        {
            workername = name;

            CapitalismSimulator.workers += 1;

            Console.WriteLine($"已雇用{workername}！");
        }

        public string WorkerName{get{return workername;}}

        protected string workername;

        public static List<Dictionary<string, Dictionary<object, object>>> workerdoing = new List<Dictionary<string, Dictionary<object, object>>>();

        public const int hire = 0;

        public const int fire = 0;

        public virtual void Work() {}

        public void Die() {}
    }

    interface IWorker
    {
        void Work();

        void Die();
    }

    class Jack : Worker, IWorker
    {
        public Jack() : base("Jack")
        {
            Worker.workerdoing.Add(new Dictionary<string, Dictionary<object, object>>(){{"CapiSimuUsing.Jack", new Dictionary<object, object>()}});
        }

        new public int hire = 10;

        new public int fire = 5;

        public override void Work() {}

        ~Jack()
        {
            Console.WriteLine("寄");
        }
    }

    class CapitalismSimulatorException : ApplicationException
    {
        public CapitalismSimulatorException(string message = null) : base("资本主义模拟器遭遇异常" + message) {}
    }

    class RobotDieException : CapitalismSimulatorException
    {
        public RobotDieException() : base("：机器人无法死亡") {}
    }
}