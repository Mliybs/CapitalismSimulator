//资本主义模拟器

namespace CapitalismSimulatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalismSimulator CapiSimu = new();

            allwork.WorkListAdd(new(Worker.Work), 5, 1);
        }
    }
}
