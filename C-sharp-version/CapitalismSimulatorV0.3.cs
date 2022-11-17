//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class backup //主要参数类
{
    public bool pause = false;

    public int round = 0;

    public int temp = 0;

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
            ListAll = ListAll + element + " ";
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
            backup.temp = 0;

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

            Console.WriteLine($"\n\n货币：{backup.G}￥，生产资料：{backup.Pm}￥，劳动力：{backup.A}￥\n{T1.intro}\n{T2.intro}\n\n目前在生产的商品有：", backup.ListPrintAll<string>(backup.listing));

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