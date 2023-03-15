//资本主义模拟器

namespace CapitalismSimulatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalismSimulator CapiSimu = new();

            Worker worker = new();

            worker.Work(5,1);
        }
    }
}
