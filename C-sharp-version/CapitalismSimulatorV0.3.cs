//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class backup //主要参数类
{
    public bool pause = false;

    public int round = 0;

    public string temp = "";

    public int number = 0;

    public int item = 0;

    public int G = 1000;
    
    public int Pm = 0;

    public int A = 0;

    public List<List<int>> list = new List<List<int>>();

    public List<string> listing = new List<string>();

    public string ListPrintAll<T>(List<T> UsingList)
    {
        string ListAll = "";

        foreach(T element in UsingList)
        {
            ListAll = ListAll + $"{element} ";
        }

        return ListAll;
    }
}
class main //程序主进程
{
    public static void Main(string[] args)
    {
        T1 T1;

        T2 T2;

        T1.number = 0;

        T2.number = 0;

        backup backup = new backup();

        //初始化

        while(backup.pause == false)
        {
            backup.temp = "";

            backup.number = 0;

            backup.item = 0;

            backup.round += 1;

            //缓存重置

            if(backup.list.Count != 0)
            {
                if((backup.list[0])[1] > 0)
                {
                    (backup.list[0])[1] -= 1;

                    switch((backup.list[0])[0])
                    {
                        case 1:

                            T1.number += 1;

                            backup.listing[0] = $"{(backup.list[0])[1]}个木板";

                            break;

                        case 2:
                            
                            T2.number += 1;

                            backup.listing[0] = $"{(backup.list[0])[1]}个螺丝";

                            break;
                    }
                }

                if((backup.list[0])[1] == 0)
                {
                    backup.list.RemoveAt(0);

                    backup.listing.RemoveAt(0);
                }
            }

            //进程刷新

            T1.intro = $"\n{T1.code}.{T1.name}（生产资料{T1.Pm}￥+劳动力{T1.A}￥+剩余价值{T1.m}￥，总价值{T1.W}￥，持有{T1.number}个）";

            T2.intro = $"\n{T2.code}.{T2.name}（生产资料{T2.Pm}￥+劳动力{T2.A}￥+剩余价值{T2.m}￥，总价值{T2.W}￥，持有{T2.number}个）";

            //商品状态刷新

            Console.WriteLine($"\n\n————————————————————————————资本主义模拟器回合分界线——第{backup.round}回合————————————————————————————");

            Console.WriteLine($"\n\n货币：{backup.G}￥，生产资料：{backup.Pm}￥，劳动力：{backup.A}￥\n{T1.intro}\n{T2.intro}\n\n目前在生产的商品有："+ backup.ListPrintAll<string>(backup.listing));

            Console.Write("\n\n跳过本回合输入0，购买生产资料输入1，购买劳动力输入2，进行生产活动输入3，售卖商品输入4，输入其它值结束游戏（不保存）：");

            backup.temp = Console.ReadLine();

            backup.number = Math.Abs(Convert.ToInt32(backup.temp));

            backup.temp = 0;

            switch(backup.number)
            {
                case 0:

                    Console.WriteLine("\n\n本回合跳过！");

                    break;

                case 1:

                    Console.Write($"\n\n你要购买多少￥的生产资料呢？最多可购买{backup.G}￥");

                    backup.temp = Console.ReadLine();

                    backup.number = Math.Abs(Convert.ToInt32(backup.temp));

                    if(backup.number <= backup.G)
                    {
                        backup.G -= backup.number;

                        backup.Pm += backup.number;
                    }
                    
                    else
                    {
                        Console.WriteLine("\n\n你所持有的￥不够！");
                    }
            }

            backup.pause = true;
            
        }
    }
}
struct T1 //木板相关数值结构
{
    public const int code = 1;

    public const string name = "木板";

    public int number;

    public const int Pm = 16;

    public const int A = 4;

    public const int m = 4;

    public const int W = 24;

    public string intro;
}
struct T2 //螺丝相关数值结构
{
    public const int code = 2;

    public const string name = "螺丝";

    public int number;

    public const int Pm = 2;

    public const int A = 2;

    public const int m = 2;

    public const int W = 6;

    public string intro;
}