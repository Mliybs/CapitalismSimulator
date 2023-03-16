//资本主义模拟器

namespace CapiSimuUsing
{
    public class CapitalismSimulator
    {
        public CapitalismSimulator() => WriteLine("资本主义模拟器开始运行！");

        public static Dictionary<string, Action<string, int>> allwork = new();

        public static Dictionary<string, Dictionary<string, int>> allworkproperties = new();

        public static void Macro()
        {
            foreach(var item in allwork)
            {
                try
                {
                    item.Value.Invoke(item.Key, allworkproperties[item.Key]["type"]);
                }
                catch(Exception)
                {
                    throw new FormatErrorException();
                }
            }
        }
    }

    public abstract class Worker
    //未完成
    {
        public static void Work(string nanoid, int type)
        {
            switch(type)
            {
                case 1:
                    //执行
                    break;
            }

            allworkproperties[nanoid]["rounds"] -= 1;
        }
    }

    public class Jack : Worker
    {}

    public static class StaticClass
    {
        public static void Print() => WriteLine("ouo");

        public static void WorkListAdd(this Dictionary<string, Action<string, int>> self, Action<string, int> callback, int rounds, int type)
        {
            string nanoid = Nanoid_Net.Generate();

            nanoid = self.ContainsKey(nanoid) ? Nanoid_Net.Generate() : nanoid;

            self.Add(nanoid, callback);

            allworkproperties.Add(nanoid, new(){{"rounds", rounds}, {"type", type}});
        }

        public struct Plank
        {
            public const int code = 1;
        }
    }

    public class CapitalismSimulatorException : ApplicationException
    {
        public CapitalismSimulatorException(string message = null) : base("资本主义模拟器遭遇异常" + message) {}
    }

    public class FormatErrorException : CapitalismSimulatorException
    {
        public FormatErrorException() : base("：参数的数量、顺序或类型出现错误！") {}
    }
}