//资本主义模拟器

namespace CapiSimuUsing
{
    public class CapitalismSimulator
    {
        public CapitalismSimulator() => WriteLine("资本主义模拟器开始运行！");

        public List<Worker> workers = new();

        public void General()
        {
            foreach (var item in this.workers)
                item.Work(item.workInfo);
        }
    }

    public class Worker
    {
        public SelfInfo selfInfo { get; set; }

        public WorkInfo workInfo { get; set; }

        public void Work(WorkInfo info)
        {}
    }

    public struct SelfInfo
    {
        public string Name;

        public int Age;

        public int Anger;

        public Jobs Job;
    }

    public struct WorkInfo
    {
        public Jobs Type;

        public int Times;
    }

    public enum Jobs
    {
        Worker = 0
    }

    public static class StaticClass
    {
        public static void Print() => WriteLine("ouo");
    }
}