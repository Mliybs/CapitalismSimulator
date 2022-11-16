//资本主义模拟器

using System;
using System.Collections;
using System.Collections.Generic;

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
}
class main //程序主进程
{
    public static void Main(string[] args)
    {
        T1 T1;

        T2 T2;

        backup backup = new backup();

        //初始化

        while (backup.pause == false)
        {
            backup.temp = 0;

            backup.number = 0;

            backup.item = 0;

            backup.round += 1;

            //缓存重置
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
}