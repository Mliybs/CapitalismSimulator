//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;

namespace CapiSimuUsing
{
    class CapitalismSimulator
    {
        
    }

    class Wares
    {
        public Wares()
        {
            plank.code = 1;
            
            plank.W = 20;

            plank.name = "木板";

            screw.W = 4;

            screw.name = "螺丝";
        }
        public Ware plank;

        public Ware screw;
    }

    class Robot : IWorker
    {}

    class Worker : IWorker
    {
        public Worker(string name)
        {
            workername = name;
        }

        public string WorkerName
        {
            get
            {
                return workername;
            }
        }

        int workername;

        public List<List<int>> workerdoing;

        public void Work()
        {}
    }

    interface IWorker
    {
        void Work();
    }

    struct Ware
    {
        public int code;

        public int W;

        public string name;
    }
}