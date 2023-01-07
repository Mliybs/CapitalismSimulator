//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;

namespace CapiSimuUsing
{
    class CapitalismSimulator
    {
        public int gelt;
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

        void IWorker.Die() {}
    }

    class Worker : IWorker
    {
        public Worker(string name)
        {
            workername = name;

            Console.WriteLine($"已雇用{workername}！");
        }

        public string WorkerName{get{return workername;}}

        string workername;

        public List<List<int>> workerdoing;

        public int hire;

        public int fire;

        public virtual void Work() {}

        public void Die() {}
    }

    interface IWorker
    {
        void Work();

        void Die();
    }

    class Jack : Worker
    {
        public Jack() : base("Jack") {}

        public override void Work() {}

        
    }
}