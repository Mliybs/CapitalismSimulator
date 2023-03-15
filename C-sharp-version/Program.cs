//资本主义模拟器
//待修改

namespace CapitalismSimulatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            CapitalismSimulator CapiSimu = new();

            allwork.WorkListAdd(Nanoid_Net.Generate(), (new(Worker.Work)));
        }
    }
}
