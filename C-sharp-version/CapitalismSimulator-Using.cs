//资本主义模拟器
//待修改

namespace CapiSimuUsing
{
    public class CapitalismSimulator
    {
        public CapitalismSimulator() => WriteLine("资本主义模拟器开始运行！");

        public static Dictionary<string, Action<string, int, int>> allwork = new();
        //待修改

        public static void Macro()
        {
            foreach(var item in allwork)
            {}
        }
    }

    public abstract class Worker
    {
        public static void Work(string nanoid, int rounds, int type)
        {
            switch(type)
            {
                case 1:
                    //执行
                    break;
            }

            allwork[nanoid] = Worker.Work;
        }
    }

    public class Jack : Worker
    {
        public new void Work(string nanoid, int rounds, int type)
        {}
    }

    public static class StaticClass
    {
        public static void Print() => WriteLine("ouo");

        public static void WorkListAdd(this Dictionary<string, Action<string, int, int>> self, string nanoid, Action<string, int, int> callback) => self.Add(nanoid, callback);

        public struct plank
        {}
    }
}