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
            plank.W = 20;

            plank.name = "木板";

            screw.W = 4;

            screw.name = "螺丝";
        }
        public Ware plank;

        public Ware screw;
    }

    class Worker
    {
        public Worker(string name)
        {
            WorkerName = name;
        }

        public string WorkerName;
    }

    struct Ware
    {
        public int W;

        public string name;
    }
}