//资本主义模拟器

namespace CapiSimuUsing
{
    public class CapitalismSimulator
    {
        public CapitalismSimulator() => WriteLine("资本主义模拟器开始运行！");

        public Dictionary<string, Action> allwork = new();
    }

    public class Worker
    {
        public void Work(int rounds, int type)
        {
            for(;rounds >= 0; rounds--) Print();
        }

        public void Work()
        {}
    }

    public static class StaticClass
    {
        public static void Print() => WriteLine("ouo");
    }
}