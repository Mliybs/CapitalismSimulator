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

            plank.W = "木板";

            screw.W = 4;

            screw.name = "螺丝";
        }
        public Ware plank;

        public Ware screw;
    }

    struct Ware
    {
        public int W;

        public string name;
    }
}